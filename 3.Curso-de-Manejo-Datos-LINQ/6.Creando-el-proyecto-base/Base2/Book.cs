using System;

public class Book
{
    public string Title { get; set; }
    public int PageCount { get; set; }
    public string Status { get; set; }
    public DateTime publishedDate { get; set; }
    public string[] Authors { get; set; }
    public string[] Categories { get; set; }
    public string ThumbnalURL { get; set; }
    public string ShortDescription { get; set; }
}