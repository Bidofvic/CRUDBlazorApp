using BlazorApp.Shared.Models;
namespace BlazorApp.Server.Interfaces
{
    public interface IUser
    {
        public List<User> GetCustomerDetails();
        public void AddUser(User user);
        public void UpdateCustomerDetails(User user);
        public User GetUserData(int id);
        public void DeleteUser(int id);
    }
}