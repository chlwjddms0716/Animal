using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class UserData : EntityData<User>
    {

        public User Get(int userId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Users.FirstOrDefault(a => a.UserId == userId);
        }

        public void Delete(int userId)
        {
            User user = Get(userId);

            if (user == null)
                return;

            Delete(user);
        }

        public int GetMaxId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.Users
                        orderby x.UserId descending
                        select x.UserId;

            return query.FirstOrDefault();
        }
        public User GetbyId(string id)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Users.FirstOrDefault(a => a.Id == id);

        }
    }
}


