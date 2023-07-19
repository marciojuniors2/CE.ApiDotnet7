using CE.ApiDotnet7.Domain.Validations;


namespace CE.ApiDotnet7.Domain.Entities
{
    public sealed class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public ICollection<Purchase>? Purchases { get; set; }

        public User(string name, string email, int password)
        {
            Validation(name, email, password);
            Purchases = new List<Purchase>();
        }

        public User(int id, string name, string email, int password)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero!");
            Id = id;
            Validation(name, email, password);
            Purchases = new List<Purchase>();

        }

        private void Validation(string name, string email, int password)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(email), "email deve ser informado!");
            DomainValidationException.When(!int.TryParse(password.ToString(), out password), "Senha deve ser informada!");

            Name = name;
            Email = email;
            Password = password;

        }
    }
}
