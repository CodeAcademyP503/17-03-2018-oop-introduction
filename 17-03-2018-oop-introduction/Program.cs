using System;
using System.Collections.Generic;

namespace _17_03_2018_oop_introduction
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Kitab adini daxil et: ");
                var ad = Console.ReadLine();
                Console.Write("Kitab yazarini daxil et: ");
                var yazar = Console.ReadLine();
                Kitab book = new Kitab(ad, yazar);
                Kitab.db.Add(book);
            }
            Kitab.Print();

        }

    }


    class Kitab
    {

        public static List<Kitab> db = new List<Kitab>();
        public string Name;
        public string Author;
     

        public Kitab(string _name,string _author)
        {
            Name = _name;
            Author = _author;
           
        }

        public static void Print()
        {
            foreach (var item in db)
            {
                Console.WriteLine(item.Name +"/"+item.Author);
            }
        }
       
    }
}
