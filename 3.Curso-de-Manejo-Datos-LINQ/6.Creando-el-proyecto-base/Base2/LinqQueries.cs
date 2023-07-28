using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

public class LinqQueries
{
    private List<Book> librosCollection = new List<Book> ();

    public LinqQueries() 
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true});
        }

    }
    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> LibrosDespuesdel2000()
    {
        // Extension method
        // return librosCollection.Where(p => p.publishedDate.Year > 2000);

        // Query Expresion
         return from l in librosCollection where l.publishedDate.Year > 2000 select l;
    }

    public IEnumerable<Book> LibrosConMasDe250PagConPalabrasInAction()
    {
        // Extension method
        // return librosCollection.Where(p=> p.PageCount > 250 && p.Title.Contains("in Action"));

        // Query Expresion
         return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
    }
}