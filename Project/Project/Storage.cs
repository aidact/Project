using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Storage
    {
        private static Storage instance;

        private Storage()
        {
            Foods = new List<Food>();
            Users = new List<Profile>();
        }

        public static Storage Instance {
            get {
                if (instance == null) {
                    instance = new Storage();
                }
                return instance;
            }
        }

        public List<Food> Foods { get; set; }

        public List<Profile> Users { get; set; }

        public Food GetFood(string name)
        {
            return Foods.Select(food => food).Where(food => food.name.Contains(name)).Take(1).ToList().ElementAt(0);
        }

        public Profile GetUser(string surname)
        {
            return Users.Select(user => user).Where(user => user.surname.Contains(surname)).Take(1).ToList().ElementAt(0); 
        }
    }
}
