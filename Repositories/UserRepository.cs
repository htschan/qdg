using System.Collections.Generic;
using System.Linq;
using qdg.Extensions;
using qdg.Models;

namespace qdg.Repositories
{
   public class UserRepository : IUserRepository
   {
      private List<User> users = new List<User>
        {
            new User { Id = 3522, Name = "hts", Password = "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=",
                FavoriteColor = "blue", Role = "Admin"}
        };

      public User GetByUsernameAndPassword(string username, string password)
      {
         var user = users.SingleOrDefault(u => u.Name == username &&
             u.Password == password.Sha256());
         return user;
      }
   }
}
