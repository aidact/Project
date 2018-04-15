using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project
{
    class Profile
    {
        public string name, surname;
        public int age, cal;
        public Bitmap bmp;

        List<Day> days;

        public Profile(string name, string surname, int age, int cal)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            days = new List<Day>();
            this.cal = cal;
            bmp = new Bitmap(@"C:\Users\User\Desktop\1.gif", true);
        }
    }
}
