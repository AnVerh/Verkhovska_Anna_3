using System;
using System.Collections.Generic;

namespace lab_3_sem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Country Ukraine = new Country("Kyiv", 24);
            Oblast o1 = new Oblast(Ukraine, "Poltavska", "Poltava");
            Oblast o2 = new Oblast(Ukraine, "Volinska", "Lusk");
            Ukraine.All_Oblast_Centers();
        }

    }
    class City
    {
        public string city_name;
    }
    class Rayon
    {

    }
    class Oblast
    {
        public int oblast_count;
        public string Oblast_name;
        public string Oblast_center;
        public Oblast(Country c, string obl_name, string obl_center)
        {
            oblast_count++;
            Oblast_center = obl_center;
            Oblast_name = obl_name;
            c.All_Oblasts.Add(this);
        }
        public void GetOblName()
        {
            Console.WriteLine($"{Oblast_name} oblast, center - {Oblast_center} city");
        }
    }
    class Country 
    {
        public List<Oblast> All_Oblasts ;
        public string Capital;
        public int Oblast_quantity;
        public Country(string capital,int obl_c)
        {
            Capital = capital;
            Oblast_quantity = obl_c;
        }
        public void All_Oblast_Centers()
        {
            foreach(Oblast o in All_Oblasts)
            {
                o.GetOblName();
            } 
        }

    }
}
