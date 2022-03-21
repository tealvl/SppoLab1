using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class Teacher : GetInfo
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string specialization { get; private set; }

        //private List<Course> courses;

        public void SignIn()
        {
            UI.Print("Так так вы хотите войти как Преподаватель, ну уж нет, пока!");

            App.SignIn();
        }
        public string GetFullInfo()
        {
            return ("Преподаватель\n" +
                    "Имя: " + name + "\n" +
                    "Возраст: " + age + "\n" +
                    "Специализация: " + specialization + "\n"
                    );
        }

        public string GetShortInfo() 
        {
            return name;
        }

    }
}
