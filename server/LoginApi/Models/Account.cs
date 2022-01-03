namespace LoginApi.Models
{
    public class account
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        // password is saved hashed state
        public string Name { get; set; }
        public DateTime Created { get; set; }

    }
}