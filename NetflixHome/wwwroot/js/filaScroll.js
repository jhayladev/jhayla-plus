// filaScroll.js
// Controla, por cada fila de películas con scroll horizontal, cuándo se
// muestra el difuminado (fade) izquierdo y derecho:
//  - Fade izquierdo: visible solo cuando ya hiciste scroll hacia la derecha
//    (hay contenido "escondido" detrás, a la izquierda).
//  - Fade derecho: visible solo cuando todavía queda contenido por ver
//    hacia la derecha.
// Se llama desde ListaPeliculas.razor (uno por cada fila, con ids únicos).

const MARGEN_PX = 8; // tolerancia para no parpadear justo en los extremos

export function iniciarFila(idFila, idFadeIzquierda, idFadeDerecha) {
    const fila = document.getElementById(idFila);
    const fadeIzq = document.getElementById(idFadeIzquierda);
    const fadeDer = document.getElementById(idFadeDerecha);

    if (!fila) {
        return { destruir() { } };
    }

    const actualizar = () => {
        const maxScroll = fila.scrollWidth - fila.clientWidth;

        // Si no hay overflow real, no mostramos ningún fade.
        if (maxScroll <= MARGEN_PX) {
            fadeIzq?.classList.remove("visible");
            fadeDer?.classList.remove("visible");
            return;
        }

        const mostrarIzquierda = fila.scrollLeft > MARGEN_PX;
        const mostrarDerecha = fila.scrollLeft < maxScroll - MARGEN_PX;

        fadeIzq?.classList.toggle("visible", mostrarIzquierda);
        fadeDer?.classList.toggle("visible", mostrarDerecha);
    };

    const onScroll = () => window.requestAnimationFrame(actualizar);

    fila.addEventListener("scroll", onScroll, { passive: true });
    window.addEventListener("resize", onScroll);

    // Estado inicial (por si la fila ya arranca con overflow, ej. resize
    // de ventana angosta a ancha, o carga inicial).
    actualizar();

    // Permite hacer scroll con la rueda del mouse en vertical y que
    // también mueva la fila horizontalmente (más cómodo en desktop).
    const onWheel = (evento) => {
        if (Math.abs(evento.deltaY) > Math.abs(evento.deltaX)) {
            fila.scrollLeft += evento.deltaY;
        }
    };
    fila.addEventListener("wheel", onWheel, { passive: true });

    return {
        destruir() {
            fila.removeEventListener("scroll", onScroll);
            fila.removeEventListener("wheel", onWheel);
            window.removeEventListener("resize", onScroll);
        }
    };
}
