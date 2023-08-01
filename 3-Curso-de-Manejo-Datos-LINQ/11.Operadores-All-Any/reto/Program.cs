LinqQueries queries = new LinqQueries();

//Toda la coleccion
//ImprimirValores(queries.TodaLaColeccion());

//Libros despues del 2000
//ImprimirValores(queries.LibrosDespuesdel2000());

//Libros que tienen mas de 250 pags y tienen en el titulo la palabra in action
//ImprimirValores(queries.LibrosConMasde250PagConPalabrasInAction());

//Todos los libros tienen Status
//Console.WriteLine($" Todos los libros tienen status? - {queries.TodosLosLibrosTienenStatus()}");

//Si algun libro fue publicado en 2005
// Console.WriteLine($" Algun libro fue publicado en 2005? - {queries.SiAlgunLibroFuePublicado2005()}");

// Todos los libros tienen Status
// Console.WriteLine($"Todos los libros tienen status {queries.TodosLosLibrosTienenStatus()}");

// Si algún libro fu publicado en 2005
// Console.WriteLine($"Algun libro publciado en 2005 - { queries.SiAlgunLibroFuePublicado2005()}");

// Libros de Python
// ImprimirValores(queries.LibrosDePython());

// Libros de Java ordenados por nombre
// ImprimirValores(queries.LibrosDeJavaPorNombreAscendente());

// Libros que tienen mas de 450 pág. ordeandors por cantidad de págs.
// ImprimirValores(queries.LibroDeMasDe450PagOrdenadosPorNumPagDesc());

// Tres Libros de Java publicados recientemente
// ImprimirValores(queries.TresPrimerosLibrosJavaOrdenanosPorFecha());// 

// Tres Libros de Java publicados recientemente
// ImprimirValores(queries.TerceryCuartoLibrosDeMasde400pag());

// Tres Primeros Libros Filtrados con Select
// ImprimirValores(queries.TresPrimerosLibrosDeLaColeccion());

// Cantidad de libros que tienen entre 200 y 500 Pag.Tres Primeros Libros Filtrados con Select
// Console.WriteLine($"Cantidad de libros que tienen entre 200 y 500 pag. {queries.CantidadDeLibrosEntre200y500Pag()}");

// Fecha de punlicacion menor de todos los libros
// Console.WriteLine($"Fecha de publicación menor:  { queries.FechaPublicacionMenor()}");

// Numero de paginas del libro con mayor numero de paginas
// Console.WriteLine($"El libro con mayor numero de paginas tiene:  {queries.NumeroDePagLibroMayor()}");

// Libro con menor numero de paginas
// var libroMenorPag = queries.LibroConMenorNumeroDePag();
// Console.WriteLine($"{libroMenorPag.Title} - {libroMenorPag.PageCount}");

// Libro con la fecha publicación mas reciente
// var libroFechaPubReciente = queries.LibroFechaPublicacionMasReciente();
// Console.WriteLine($"{libroFechaPubReciente.Title} - {libroFechaPubReciente..PublishedDate.ToShortDateString()}");

// Suma de paginas de libros entre 0 y 500
// Console.WriteLine($"Suma de todas las paginas { queries.SumaDeTodasLasPaginasLibrosEntre0y500()}");

// libros publicados despues del 2015 concatenados
// Console.WriteLine(queries.TitulosDeLibrosDespuesDel2015Concatenados());

// Promedio de caracteres de los titulo de los libros
// Console.WriteLine($"Promedio caracteres de los titulos: {queries.PromedioCaracteresTitulo()}");

// Promedio de paginas  de los libros
// Console.WriteLine($"Promedio de paginas de los libros: {queries.PromedioDelNumeroPaginasQueTienenLosLibros()}");

// Libros publicados a partir del 2000 agrupados por año
// ImprimirGrupos(queries.LibrosDespuesDel200AgrupadosPorAno());

// Diccionario de libros agrupados por primera letra del titulo
// var diccionario = queries.DiccionarioDeLibrosPorLetra();
// ImprimirDiccionario(diccionarioLookup, 'A'); // 'S' 'P' 'Z'

// Libros filtrados con la clausula Join 
ImprimirValores(queries.LibrosDespuesDel2005ConMasDe500Pag());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach(var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void ImprimirGrupos(IEnumerable<IGrouping<int, Book>> listadelibros)
{
    foreach (var grupo in listadelibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: { grupo.Key }")
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(var item in grupo)
        {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.Date.ToShortDateString());

        }
    }
}

void ImprimirDiccionario(ILookup<char, Book> listadelibros, char letra)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in listadelibros[letra])
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.Date.ToShortDateString());
    }
}