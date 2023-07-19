namespace CE.ApiDotnet7.Application.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public string Color { get; set; }
        public string? Picture { get; set; }
    }
}
