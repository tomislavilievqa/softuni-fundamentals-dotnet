using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Songs
{
    public class Song
    {
        // { get - може да се чете; set - може да се записва; }
        public string TypeList { get; set; } // class property

        public string Name { get; set; } // class property
        public string Time { get; set; } // class property

        string Play()
        {

            return "ShaSha";

        }

        //може да си правим и конструктори. Toй винаги има същото име като това на класа. 
        //Приема задължителни стойности и се държи като метод
        // може да имаме много на брой конструктори с едно и също име
        //class DateTime има 12 на брой конструктора - ПРИМЕР! 
        //public Songs(string TypeList, string Name, string Time)
        //{
            
        //}
   

    }
}
