using CE.ApiDotnet7.Domain.Validations;


namespace CE.ApiDotnet7.Domain.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int CarId { get; private set; }
        public int UserId { get; private set; }
        public DateTime Date { get; private set; }
        public User User { get; set; }
        public Car Car { get; set; }


        public Purchase() { }

        public Purchase(int carId, int userId)
        {
            Validation(carId, userId);
        }

        //for update
        public Purchase(int id, int carId, int userId)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero!");
            Id = id;
            Validation(carId, userId);
        }

        private void Validation(int carId, int userId)
        {
            DomainValidationException.When(carId < 0, "Id produto deve ser informado!");
            DomainValidationException.When(userId < 0, "Id Pessoa deve ser informada!");

            UserId = userId;
            CarId = carId;
            Date = DateTime.Now;
        }
    }
}
