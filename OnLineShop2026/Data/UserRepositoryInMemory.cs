using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UserRepositoryInMemory : IUserRepository
    {
        List<User> users = new List<User>()
        {
            new User("Элинка", "Кокоева", "elinaaaaaa@mail.ru", "/images/elina.jpg"),
            new User("Аринка", "Цагарка", "arin@mail.ru", "/images/arinka.jpg"),
            new User("я", "Хубулова", "khubul@mail.ru", "/images/lera.jpg")
        };

        public void Add(User user)
        {
            user.Id = Guid.NewGuid();
            users.Add(user);
        }
        
        public List<User> GetAll() => users;

        public User? TryGetById(Guid userId) => users.FirstOrDefault(user => user.Id == userId);
    }
}
