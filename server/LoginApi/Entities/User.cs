using System.Text.Json.Serialization;




namespace LoginApi.Entities
{
    public class User
    {
        public string Name { get; set; }
        // 김정연 이런 이름
        public string UserName { get; set; }
        // 이게 아이디
        public string Email { get; set; }
        public string Password { get; set; }
        // password is saved hashed state

        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}