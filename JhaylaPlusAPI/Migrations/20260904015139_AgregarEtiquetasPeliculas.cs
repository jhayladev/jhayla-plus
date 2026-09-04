using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JhaylaPlusAPI.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEtiquetasPeliculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Clasificacion",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duracion",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Etiqueta",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Formatos",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reparto",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sinopsis",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "12+", "Camila Duarte", "52m", "Original Jhayla+", "HD, 5.1, CC", "Romance, Drama", "Valeria Ospina, Martín Reyes, Daniela Cortés", "Dos jóvenes que se conocieron por internet sostienen una relación a distancia mientras enfrentan la duda de si algún día podrán encontrarse en persona. Una historia intimista sobre la paciencia, los mensajes de texto a medianoche y el amor que resiste el tiempo y la distancia." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "12+", "Adrián Salcedo", "2h 21m", "Estreno", "HD, 5.1, CC", "Acción, Aventura, Ciencia ficción", "Bruno Estrada, Naomi Vidal, Tomás Ferreira, Lucía Mendoza", "Un equipo de héroes debe unir fuerzas por última vez para enfrentar una amenaza capaz de borrar el mundo tal como lo conocen. Alianzas viejas se ponen a prueba mientras el destino del planeta pende de un hilo." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "12+", "Renata Falcón", "2h 08m", "Tendencia", "HD, 5.1, CC", "Acción, Aventura, Superhéroes", "Iker Salazar, Camila Rentería, Diego Guzmán", "Un joven héroe enmascarado debe proteger su ciudad de una nueva amenaza mientras intenta equilibrar su vida personal con la responsabilidad de llevar el traje. Acción trepidante entre los rascacielos y decisiones que lo marcarán para siempre." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "15+", "Howard Steiner", "2h 15m", "Terror Pop", "HD, 5.1, CC", "Terror, Suspenso", "Simon Wade, Charlotte Byrne, Milo Kagan", "En un pequeño pueblo, un grupo de niños se enfrenta a una entidad ancestral que se alimenta del miedo y toma la forma de sus peores pesadillas. Una historia de terror y amistad a partes iguales." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Estudios Costa Azul", "1h 47m", "Familiar", "HD, 5.1, CC", "Animación, Aventura, Familia", "Voces originales: Malia Kealoha, James Nuanez", "La hija de un jefe tribal se embarca en un viaje por el océano para salvar a su pueblo, guiada por la fuerza del mar y la ayuda de un semidiós algo arrogante. Aventura, música y descubrimiento personal en altamar." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "12+", "Gary Feldstein", "1h 41m", "Comedia", "HD, 5.1, CC", "Comedia, Familia", "Dennis Kohler, Marco Rubbio, Salma Trent", "Un grupo de amigos de toda la vida se reúne otra vez de vacaciones junto a sus familias, y el caos y las bromas están garantizados. Una comedia ligera sobre la amistad, la nostalgia y las vacaciones que nunca salen como se planean." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "15+", "Wren Ashdown", "1h 38m", "Próximamente", "HD, 5.1, CC", "Terror, Suspenso", "Ivy Callahan, Noah Prescott, Elias Vance", "Una familia se muda a una casa aislada con un pasado oscuro, sin saber que algo dentro de sus paredes lleva años esperando compañía. El terror psicológico se apodera de cada rincón de su nuevo hogar." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Rosa Delgadillo", "1h 31m", "Infantil", "HD, 5.1, CC", "Comedia, Familia", "Voces originales: Andy García, Paz Vega", "Una pequeña chihuahua acostumbrada al lujo de Beverly Hills se pierde durante un viaje y debe encontrar el camino de regreso a casa junto a nuevos e inesperados amigos." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Alicia Montfort", "1h 45m", "Clásico", "HD, 5.1, CC", "Fantasía, Romance, Familia", "Elle Sinclair, Cate Ashworth, Robert Hale", "La versión en imagen real del clásico cuento de hadas: una joven bondadosa soporta el maltrato de su madrastra hasta que la magia y un baile real cambian su destino para siempre." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Estudios Corona Real", "1h 40m", "Aventura Mágica", "HD, 5.1, CC", "Animación, Fantasía, Familia", "Voces originales: Mandy Halloway, Zack Levinson", "Una princesa de cabello mágico y extraordinariamente largo escapa de la torre donde ha vivido encerrada toda su vida, junto a un carismático forajido, para descubrir por fin el mundo exterior." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Estudios Ruta 66", "1h 57m", "Favorita", "HD, 5.1, CC", "Animación, Familia, Deportes", "Voces originales: Owen McQueen, Larry Hudson", "Un joven auto de carreras arrogante queda varado en un pequeño pueblo de la Ruta 66 y aprende, entre sus excéntricos habitantes, el verdadero significado de la amistad y la humildad." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Estudios Lámpara Amarilla", "1h 21m", "Imperdible", "HD, 5.1, CC", "Animación, Familia, Aventura", "Voces originales: Tom Halbert, Timothy Allan", "Un vaquero de juguete ve amenazado su lugar como el favorito de su dueño con la llegada de una moderna figura de acción espacial. Juntos deberán aprender a trabajar en equipo para volver a casa." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Constance Fielding", "2h 09m", "Musical", "HD, 5.1, CC", "Fantasía, Romance, Musical", "Emmeline Rousse, Daniel Ashcombe, Ludovic Marchetti", "Versión en imagen real del clásico cuento: una joven inteligente y curiosa es retenida en un castillo encantado por una bestia con apariencia aterradora pero un corazón que aprende a abrirse." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Estudios Pantano Dulce", "1h 37m", "Aclamada", "HD, 5.1, CC", "Animación, Fantasía, Musical", "Voces originales: Anika Noni Rose, Bruno Campos", "Una joven trabajadora y soñadora de Nueva Orleans se convierte en rana tras un beso inesperado, y junto a un príncipe hechizado emprende una aventura mágica por los pantanos." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "12+", "Rowena Ashcroft", "1h 37m", "Fantasía", "HD, 5.1, CC", "Fantasía, Aventura", "Ainsley Deveraux, Elle Fanshawe, Sam Riordan", "La verdadera historia detrás del hada oscura: una traición en su juventud despierta una maldición que lanza sobre un reino entero, hasta que una niña inocente pone a prueba su corazón endurecido." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "12+", "Rowena Ashcroft", "1h 59m", "Secuela", "HD, 5.1, CC", "Fantasía, Aventura", "Ainsley Deveraux, Elle Fanshawe, Marguerite Colt", "Con el compromiso real en puerta, viejas tensiones entre humanos y criaturas mágicas resurgen, obligando al hada oscura a decidir hasta dónde llegar para proteger a quienes ama." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Estudios Arrecife de Coral", "1h 23m", "Clásico Animado", "HD, 5.1, CC", "Animación, Fantasía, Musical", "Voces originales: Jodi Benson, Pat Carroll", "Una joven sirena fascinada por el mundo humano hace un trato peligroso con una bruja del mar a cambio de piernas y la oportunidad de vivir en tierra firme." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Estudios Arrecife de Coral", "1h 15m", "Próximamente", "HD, 5.1, CC", "Animación, Fantasía, Musical", "Voces originales: Jodi Benson, Tara Strong", "Años después de dejar el mar, la hija de la sirena debe redescubrir su propia conexión con el océano cuando un viejo peligro familiar regresa a amenazar su hogar en tierra." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "15+", "Marcus Thorne", "1h 30m", "Suspenso", "HD, 5.1, CC", "Terror, Suspenso", "Ellery Voss, Grant Halliwell, Priya Anand", "En una casa donde el más mínimo sonido puede significar el fin, una familia debe aprender a comunicarse en absoluto silencio para sobrevivir a una presencia que acecha en la oscuridad." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "15+", "Marcus Thorne", "1h 39m", "Éxito", "HD, 5.1, CC", "Terror, Suspenso, Ciencia ficción", "Grant Halliwell, Priya Anand, Owen Castellanos", "El relato de las primeras horas de una invasión silenciosa: una ciudad entera aprende, de la forma más brutal, que hacer ruido puede costarle la vida a cualquiera." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "15+", "Selene Kowalski", "1h 46m", "Novedad", "HD, 5.1, CC", "Suspenso, Drama", "Nadia Ferro, Julián Vasconcelos, Marina Estep", "Una racha de sucesos cada vez más inquietantes convence a una mujer de que la suerte, buena o mala, se puede heredar como una maldición familiar que ahora le toca romper." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "15+", "Ibrahim Castell", "1h 52m", "Policial", "HD, 5.1, CC", "Suspenso, Drama, Crimen", "Renata Ibarra, Tomás Aldunate, Greta Solheim", "Un detective obsesionado con un caso sin resolver se acerca peligrosamente a la verdad, solo para descubrir que atrapar al culpable puede costarle todo lo que ama." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Priscilla Nkemelu", "1h 35m", "Romance", "HD, 5.1, CC", "Comedia, Romance", "Holly Marchbanks, Cody Trentham, Bianca Suárez", "Una estudiante que trabaja en el restaurante familiar sueña con salir de su pequeño pueblo, y encuentra en un chat anónimo con un compañero de escuela la esperanza de un futuro distinto." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Priscilla Nkemelu", "1h 30m", "Juvenil", "HD, 5.1, CC", "Comedia, Romance", "Holly Marchbanks, Devon Ashworth, Bianca Suárez", "Una nueva generación revive el cuento moderno de Cenicienta: una chica trabajadora usa un alias en línea para perseguir sus sueños, sin imaginar a quién va a encontrar del otro lado." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Desmond Aldwych", "1h 55m", "Imperdible", "HD, 5.1, CC", "Fantasía, Familia, Musical", "Warrick Feathering, Ida Loncar, Percy Whitmore", "Un niño de escasos recursos gana un boleto dorado para visitar la fábrica de chocolates más misteriosa del mundo, dirigida por un excéntrico e impredecible chocolatero." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Documental Colectivo Sur", "1h 47m", "Documental", "HD, 5.1, CC", "Documental, Biografía, Deportes", "Con la participación de figuras del fútbol mundial", "Un repaso documental a la vida de uno de los futbolistas más influyentes de la historia, desde su infancia humilde hasta convertirse en leyenda del deporte a nivel global." });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Clasificacion", "Director", "Duracion", "Etiqueta", "Formatos", "Genero", "Reparto", "Sinopsis" },
                values: new object[] { "TP", "Winona Halbrook", "1h 32m", "Comedia", "HD, 5.1, CC", "Comedia, Familia", "Desmond Pratchett, Ainsley Marek, Cora Bellweather", "Cuando una familia se muda a una nueva ciudad, su casa parece tener vida propia y decide literalmente ponerlo todo patas arriba, generando una serie de enredos tan caóticos como divertidos." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clasificacion",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Duracion",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Etiqueta",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Formatos",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Reparto",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Sinopsis",
                table: "Peliculas");
        }
    }
}
