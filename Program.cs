using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("National Record!");

            var People_sData = new List<People>() {
                new People(){ Name="Billy", DOB ="October 2001", NIN =25, Genotype="AA" },
                new People(){ Name="Noah", DOB ="July 2003", NIN =35, Genotype="SS" },
                new People(){ Name="Nora", DOB ="April 2001", NIN =62, Genotype="AA" },
                new People(){ Name="Seto", DOB ="July 2000", NIN =232, Genotype="AS" },
                new People(){ Name="Sally", DOB ="August 1998", NIN =52, Genotype="SC" },
                new People(){ Name="Billy", DOB ="February 1999", NIN =113, Genotype="AC" },
                new People(){ Name="Bill", DOB ="March 2002", NIN =112, Genotype="SS" },
                new People(){ Name="Alma", DOB ="May 2001", NIN =231, Genotype="AS" },
                new People(){ Name="Ore", DOB ="November 2000", NIN =21, Genotype="AS" },
                new People(){ Name="Salem", DOB ="June 1997", NIN =12, Genotype="AA" },
                new People(){ Name="Ope", DOB ="Februuary 1999", NIN =2, Genotype="AA" },
                new People(){ Name="Sophia", DOB ="Semptember 2003", NIN =1, Genotype="SS" },
                new People(){ Name="Cherry", DOB ="January 1997", NIN =5, Genotype="AS" },
                new People(){ Name="Saviy", DOB ="December 1999", NIN =10, Genotype="AC" },
                new People(){ Name="Bliz", DOB ="October 2000", NIN =102, Genotype="SC" }
        };

            Console.WriteLine("\n");
            Console.WriteLine("\t\tPeople's Data");
            Console.WriteLine("\n");

            var ppl = from s in People_sData
                      select s;
            
                Console.WriteLine("  Name" + "\t\tNIN" + "\t  DOB" + "\t\t    Genotype");
            foreach (var s in ppl)
                Console.WriteLine(" " + s.Name + "\t\t" + s.NIN + "\t" + s.DOB + "\t\t" + s.Genotype);


            var orderlyName = from s in People_sData
                              orderby s.Name
                              select s;

            Console.WriteLine("\n\nAfter sorting their names alphabetically:\n");
            Console.WriteLine("  Name" + "\t\tNIN" + "\t  DOB" + "\t\t    Genotype");
            foreach (var s in orderlyName)
                Console.WriteLine(" " + s.Name + "\t\t" + s.NIN + "\t" + s.DOB + "\t\t" + s.Genotype);



            var orderlyMonth = from s in People_sData
                                orderby s.DOB
                                select s;

            Console.WriteLine("\n\nAfter sorting their month of birth alphabetically:\n");
            Console.WriteLine("  Name" + "\t\tNIN" + "\t  DOB" + "\t\t    Genotype");
            foreach (var s in orderlyMonth)
                Console.WriteLine(" " + s.Name + "\t\t" + s.NIN + "\t" + s.DOB + "\t\t" + s.Genotype);



            var groupedByGenotype = from p in People_sData
                                    group p by p.Genotype;
            foreach (var aGroup in groupedByGenotype)
            {
                Console.WriteLine("\nPeople with genotype {0}", aGroup.Key);

                foreach (People p in aGroup)
                    Console.WriteLine("=> {0}", p.Name);
            }
        }
    }
}
