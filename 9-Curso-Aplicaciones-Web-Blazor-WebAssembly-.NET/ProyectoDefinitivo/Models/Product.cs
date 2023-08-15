namespace blazorappdemo;

public class Product
{
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string[] Images { get; set; }
        public string? Image { get; set; }
}