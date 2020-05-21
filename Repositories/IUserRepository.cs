
using qdg.Models;

namespace qdg.Repositories
{
   public interface IUserRepository
   {
      User GetByUsernameAndPassword(string username, string password);
   }
}