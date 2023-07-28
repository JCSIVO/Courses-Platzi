public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();

    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> LibrosDespuesdel2000()
    {
        //extension method
        //return librosCollection.Where(p=> p.PublishedDate.Year > 2000);

        //query expresion

        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }

    public IEnumerable<Book> LibrosConMasde250PagConPalabrasInAction()
    {
        //extension methods
        //return librosCollection.Where(p=> p.PageCount > 250 && p.Title.Contains("in Action"));

        //query expression
        return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
    }

    /*public bool TodosLosLibrosTienenStatus()
    {
        return librosCollection.All(p=> p.Status!= string.Empty);
    }*/

    public bool SiAlgunLibroFuePublicado2005()
    {
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
    }

    public bool TodosLosLibrosTienenStatus()
    {
        return librosCollection.All(p => p.Status != string.Empty);
    }

    public IEnumerable<Book> LibrosDePython()
    {
        return librosCollection.Where(p => p.Categories.Contains("Python"));
    }

    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(propa => propa.Title);
    }

    public IEnumerable<Book> LibroDeMasDe450PagOrdenadosPorNumPagDesc()
    {
        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
    }

    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenanosPorFecha()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderByDescending(p => p.PublishedDate).Take(3);
        // .OrderBy(p=> p.PublishedDate)
        // .TakeLast(3);
    }

    public IEnumerable<Book> TerceryCuartoLibrosDeMasde400pag()
    {
        return librosCollection
            .Where(p => p.PageCount > 400)
            .Take(4)
            .Skip(2);
    }

    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
    {
        return librosCollection.Take(3)
            .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
    }

    public int CantidadDeLibrosEntre200y500Pag() // No código limpio
    {
        return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();
    }

    public long CantidadDeLibrosEntre200y500Pag() // No código limpio
    {
        return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).LongCount();
    }

    public long CantidadDeLibrosEntre200y500Pag()
    {
        return librosCollection.LongCount(p => p.PageCount >= 200 && p.PageCount <= 500);

    }

    public DateTime FechaPublicacionMenor()
    {
        return librosCollection.Min(p => p.PublishedDate);
    }

    public int NumeroDePagLibroMayor()
    {
        return librosCollection.Max(p => p.PageCount);
    }

    public Book LibroConMenorNumeroDePag()
    {
        return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
    }

    public Book LibroFechaPublicacionMasReciente()
    {
        return librosCollection.MaxBy(p => p.PublishedDate);
    }

    public int SumaDeTodasLasPaginasLibrosEntre0y500()
    {
        return librosCollection.Where(p => p.PageCount >= 0 && p.PageCount <= 500 ).Sum(p => p.PageCount);
    }

    public string TitulosDeLibrosDespuesDel2015Concatenados()
    {
        return librosCollection.Where(p => p.PublishedDate.Year > 2015).Aggregate("", (TitulosLibros, next) =>
        {
            if (TitulosLibros != string.Empty)
            {
                TitulosLibros + = " - " next.Title;
            }
            else
            {
                TitulosLibros += next.Title; 
            }
            return TitulosLibros;
        });
    }

    public double PromedioCaracteresTitulo()
    {
        return librosCollection.Average(p => p.Title.Length);
    }

    public double PromedioDelNumeroPaginasQueTienenLosLibros()
    {
        return booksCollection.Where(x => x.PageCount > 0).Average(p => p.PageCount);
    }

    public IEnumerable<IGrouping<int, Book>> LibrosDespuesDel200AgrupadosPorAno()
    {
        return librosCollection.Where(p => p.PublishedDate.Year >= 2000).GroupBy(p => p.PublishedDate.Year);
    }

    public ILookup<char, Book> DiccionarioDeLibrosPorLetra()
    {
        return librosCollection.ToLookup(p => p.Title[0], p => p);
    }

    public IEnumerable<Book> LibrosDespuesDel2005ConMasDe500Pag()
    {
        var LibrosDespuesDel2005 = librosCollection.Where(p => p.PublishedDate.Year > 2005);
        
        var LibrosConMasDe500Pag = librosCollection.Where(p => p.PageCount > 500);

        // return LibrosDespuesDel2005.Join(LibrosConMasDe500Pag, p => p.Title, x => x.Title, (p, x) => p);

        return LibrosDespuesDel2005;
    }
}