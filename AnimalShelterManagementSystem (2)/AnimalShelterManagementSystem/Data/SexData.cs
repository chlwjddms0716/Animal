using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class SexData : EntityData<Sex>
    {
        public Sex Get(int sexId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Sexes.FirstOrDefault(a => a.SexId == sexId);
        }

        public void Delete(int sexId)
        {
            Sex sex = Get(sexId);

            if (sex == null)
                return;

            Delete(sex);
        }

        public int GetMaxId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.Sexes
                        orderby x.SexId descending
                        select x.SexId;

            return query.FirstOrDefault();
        }
    }
}

