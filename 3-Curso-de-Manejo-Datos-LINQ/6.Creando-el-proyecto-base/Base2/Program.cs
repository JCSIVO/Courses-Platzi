// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


LinqQueries queries = new LinqQueries();

// Toda la colección 
// ImprimirValores(queries.TodaLaColeccion());

// Libros despues del 200
// ImprimirValores(queries.LibrosDespuesdel2000());

// Libros que contiene mas de 250 paginas y la palabra en el titulo in action
ImprimirValores(queries.LibrosConMasDe250PagConPalabrasInAction());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Título", "N.Paginas", "Fecha Publicación");
    foreach(var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.publishedDate.ToShortDateString());
    }
}