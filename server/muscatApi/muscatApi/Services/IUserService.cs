using muscatApi.Models;

namespace muscatApi.Services
{
    public interface IUserService
    {
        public List<MyUser> GetAll();

        public MyUser? GetById(int id);

        public MyUser Create(MyUser newUser);

        //public MyUser Update(MyUser newUser);

        public bool DeleteById(int id);

    }
}
