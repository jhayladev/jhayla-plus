// Activa/desactiva la difuminación izquierda de cada fila de tarjetas
// según su posición de scroll horizontal (a la derecha ya viene fija por CSS).
// Se puede llamar varias veces sin problema: cada fila solo se "engancha" una vez
// (marca data-scroll-listo) así que es seguro invocarla de nuevo tras cada render.
window.iniciarFilasScroll = function () {
    const filas = document.querySelectorAll('.fila-peliculas');

    filas.forEach((fila) => {
        const envoltura = fila.closest('.fila-envoltura');
        if (!envoltura) return;

        const actualizar = () => {
            if (fila.scrollLeft > 8) {
                envoltura.classList.add('fila-en-scroll');
            } else {
                envoltura.classList.remove('fila-en-scroll');
            }
        };

        if (!fila.dataset.scrollListo) {
            fila.dataset.scrollListo = '1';
            fila.addEventListener('scroll', actualizar, { passive: true });
            window.addEventListener('resize', actualizar);
        }

        // Estado inicial (por si la fila ya viene con scroll restaurado por el navegador).
        actualizar();
    });
};
