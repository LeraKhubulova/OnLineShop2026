namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        public User(string name, string surName, string email, string avatar)
        {
            Id = Guid.NewGuid();
            Name = name;
            SurName = surName;
            Avatar = avatar;
            Email = email;
        }
    }
}
