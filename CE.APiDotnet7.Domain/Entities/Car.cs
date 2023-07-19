using CE.ApiDotnet7.Domain.Validations;

namespace CE.ApiDotnet7.Domain.Entities
{
    public sealed class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public string Color { get; set; }
        public string? Picture { get; set; } = null;
        public ICollection<Purchase> Purchases { get; set; }

        public Car(string name, string brand, string model, int price, int year, int km, string color, string picture)
        {
            Validation(name, brand, model, price, year, km, color, picture);
            Purchases = new List<Purchase>();
        }

        public Car(int id, string name, string brand, string model, int price, int year, int km, string color, string picture)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero!");
            Id = id;
            Validation(name, brand, model, price, year, km, color, picture);
            Purchases = new List<Purchase>();
        }

        private void Validation(string name, string brand, string model, int price, int year, int km, string color, string picture)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(brand), "Marca deve ser informada!");
            DomainValidationException.When(string.IsNullOrEmpty(model), "Modelo deve ser informado!");
            DomainValidationException.When(!int.TryParse(price.ToString(), out price), "Valor deve ser um número inteiro válido!");
            DomainValidationException.When(!int.TryParse(year.ToString(), out year), "Ano deve ser informado!");
            DomainValidationException.When(!int.TryParse(km.ToString(), out km), "Km deve ser informada!");
            DomainValidationException.When(string.IsNullOrEmpty(color), "Cor deve ser informada!");
            DomainValidationException.When(string.IsNullOrEmpty(picture), "Picture deve ser informada!");


            Name = name;
            Brand = brand;
            Model = model;
            Price = price;
            Year = year;
            Km = km;
            Color = color;
            Picture = picture;
        }

    }

}
