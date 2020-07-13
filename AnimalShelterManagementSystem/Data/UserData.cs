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

        public List <User> GetbyName(string name)
        {
            List<User> user = new List<User>();
            AnimalShelterManagementEntities context = CreateContext();
            foreach(User userr in context.Users)
            {
                if (String.Equals(userr.Name, name) == true)
                    user.Add(userr);
            }
            return user;
        }

        public List<User> Search(string name, string id, int adminCode, int blacklistCode)
        {
            var context = CreateContext();

            var query = from x in context.Users
                        select x;

            if(string.IsNullOrEmpty(name) == false)
                query = query.Where(x => x.Name.Contains(name) == true);
           
            if (string.IsNullOrEmpty(id) == false)
                query = query.Where(x => x.Id.Contains(id) == true);

            if (adminCode != 2)
            {
                bool IsAdmin = adminCode == 1 ? true: false;
                query = query.Where(x => x.IsAdministrator == IsAdmin);
            }


            if (blacklistCode != 2)
            {
                bool IsBlack = blacklistCode == 1 ? true : false;
                query = query.Where(x => x.IsBlacklist == IsBlack);
            }
              

            var list = query.ToList();

            return list;
        }
    }
}


