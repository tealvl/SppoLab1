using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SppoLab1
{
    class Administrator
    {
        public void SignIn() 
        {
            UI.Print("Так так вы хотите войти как администратор, ну уж нет, пока!");

            App.SignIn();
        }
    }
}