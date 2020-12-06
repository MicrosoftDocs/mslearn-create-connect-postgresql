namespace PaymentUsersApp.Models
{
    public class Users
    {
        public string UserId { get; }
        public string UserName { get; }
        public int UserAge { get; }

        public Users(string userId, string userName, int userAge)
        {
            this.UserId = userId;
            this.UserName = userName;
            this.UserAge = userAge;
        }
    }
}