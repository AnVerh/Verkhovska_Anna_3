using System;
using System.Collections.Generic;

namespace laba_3._2_sem_2
{
    class Program
    {
        static void Main()
        {
            Tresh banana = new Tresh("organic tresh", "banana", 0.4);
            Tresh glass = new Tresh("glass", "glass", 5.9);
            Tresh notebook = new Tresh("paper", "notebook", 890);
            Tresh metal = new("metal", "metal",  2);
            Tresh bottle = new("plastic", "bottle", 1);
            Tresh apple = new("organic tresh", "apple",  1000);
            Tresh cigarette = new("cigarette", "cigarette", 0.05);
            Tresh GlassBottle = new("glass", "glass bottle", 0.8);
            List<Tresh> alltresh = new List<Tresh>() { banana, glass, notebook,metal,bottle,apple,cigarette,GlassBottle};
            alltresh.Sort();
            alltresh.ForEach(tresh => Console.WriteLine(tresh.TreshName));
            Console.WriteLine("--------------------");
            bottle.GetInfo();
            GlassBottle.GetInfo();
        }
    }
    public class Tresh : IComparable<Tresh>
    {
        protected string treshType ;
       
        public double Capacity { get; set; }
        public string TreshName { get; set; }

        public Tresh(string atreshType, string treshName, double capacity) 
        {
            TreshType = atreshType;
            Capacity = capacity;
            if (Capacity > MaxCapacity(this))
            {
                TreshName = treshName + " is bigger than the max capacity ";
            }
            else 
            { TreshName = treshName;}
            
        }
        public string TreshType
        {
            set 
            {
                if (value == "organic tresh" || value=="paper"||value=="plastic"||value=="glass"||value=="metal")
                {
                    treshType = value;
                }
                else
                {
                    treshType = "not recycling";
                }
            }
            get { return treshType; }
        }

        public Tresh() { }
        public void GetInfo()
        {
            Console.WriteLine($"the {TreshName} is {treshType},  it's capacity - {Capacity}");
        }
        public int CompareTo(Tresh other)
        {
            if(this.TreshType =="organic tresh")
            {
                return -1;
            }
            else if(this.TreshType=="paper" && other.TreshType != "organic tresh")
            {
                return -1;
            }
            else if(this.TreshType=="paper" && other.TreshType=="organic tresh")
            {
                return 11;
            }
            else if(this.TreshType=="plastic" && (other.TreshType=="glass" || other.TreshType == "metal"))
            {
                return -1;
            }
            else if(this.TreshType == "plastic" && (other.TreshType == "organic tresh" || other.TreshType == "paper"))
            {
                return 11;
            }
            else if(this.TreshType=="glass" && other.TreshType != "metal")
            {
                return 1;
            }
            else if (other.TreshType == "metal")
            {
                return -1;
            }
            else if(this.TreshType=="not recycling")
            {
                string name = TreshName;
                TreshName = $"is not recycling ";
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public double MaxCapacity(Tresh t)
        {
            if(t.TreshType=="organic tresh")
            {
                return 27;
            }
            if (t.TreshType == "paper")
            {
                return 95.6;
            }
            if (t.TreshType == "plastic")
            {
                return 37.4;
            }
            if (t.TreshType == "glass")
            {
                return 16;
            }
            if (t.TreshType == "metal")
            {
                return 58.2;
            }
            else
            {
                return 0;
            }
        }
    }

}
