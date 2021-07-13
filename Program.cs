using System;
using System.Linq;
using System.Collections.Generic;
using FizzWare.NBuilder.Dates;

namespace LinqAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("National Record!");

            var People_sData = new List<People>() {
                new People(){ Name="Billy", DOB =Convert.ToDateTime("29 October 2001"), NIN =25, Genotype="AA" },
                new People(){ Name="Noah", DOB =Convert.ToDateTime("4 July 2003"), NIN =35, Genotype="AS" },
                new People(){ Name="Nora", DOB =Convert.ToDateTime("2 April 2001"), NIN =62, Genotype="AA" },
                new People(){ Name="Seto", DOB =Convert.ToDateTime("14 July 2000"), NIN =232, Genotype="AS" },
                new People(){ Name="Sally", DOB =Convert.ToDateTime("10 August 1998"), NIN =52, Genotype="SC" },
                new People(){ Name="Billy", DOB =Convert.ToDateTime("4 February 1999"), NIN =113, Genotype="AC" },
                new People(){ Name="Bill", DOB =Convert.ToDateTime("22 March 2002"), NIN =112, Genotype="SS" },
                new People(){ Name="Alma", DOB =Convert.ToDateTime("16 May 2001"), NIN =231, Genotype="AS" },
                new People(){ Name="Ore", DOB =Convert.ToDateTime("3 November 2000"), NIN =21, Genotype="AS" },
                new People(){ Name="Salem", DOB =Convert.ToDateTime("1 June 1997"), NIN =12, Genotype="AA" },
                new People(){ Name="Ope", DOB =Convert.ToDateTime("7 February 1999"), NIN =2, Genotype="AA" },
                new People(){ Name="Sophia", DOB =Convert.ToDateTime("1 September 2003"), NIN =1, Genotype="SS" },
                new People(){ Name="Cherry", DOB =Convert.ToDateTime("13 January 1997"), NIN =5, Genotype="AS" },
                new People(){ Name="Saviy", DOB =Convert.ToDateTime("25 December 1999"), NIN =10, Genotype="AC" },
                new People(){ Name="Bliz", DOB =Convert.ToDateTime("4 October 2000"), NIN =102, Genotype="SC" }
        };

            Console.WriteLine("\n");
            Console.WriteLine("\t\tPeople's Data");
            Console.WriteLine("\n");

            var ppl = from s in People_sData
                      select s;
            
                Console.WriteLine("  Name" + "\t\tNIN" + "\t  DOB" + "\t\t    Genotype");
            foreach (var s in ppl)
                Console.WriteLine(" " + s.Name + "\t\t" + s.NIN + "\t" + s.DOB.ToString("dd MMMM yyyy     ") + "\t" + s.Genotype);


            var orderByName = from s in People_sData
                              orderby s.Name
                              select s;

            Console.WriteLine("\n\nAfter sorting their names alphabetically:\n");
            Console.WriteLine("  Name" + "\t\tNIN" + "\t  DOB" + "\t\t    Genotype");
            foreach (var s in orderByName)
                Console.WriteLine(" " + s.Name + "\t\t" + s.NIN + "\t" + s.DOB.ToString("dd MMMM yyyy     ") + "\t" + s.Genotype);



            var orderByMonth = from s in People_sData
                                orderby s.DOB
                                select s;

            Console.WriteLine("\n\nAfter sorting from the oldest to youngest person:\n");
            Console.WriteLine("  Name" + "\t\tNIN" + "\t  DOB" + "\t\t    Genotype");
            foreach (var s in orderByMonth)
                Console.WriteLine(" " + s.Name + "\t\t" + s.NIN + "\t" + s.DOB.ToString("dd MMMM yyyy     ") + "\t" + s.Genotype);



            var groupedByGenotype = from p in People_sData
                                    group p by p.Genotype;
            foreach (var aGroup in groupedByGenotype)
            {
                Console.WriteLine("\nPeople with genotype {0}", aGroup.Key);

                foreach (People p in aGroup)
                    Console.WriteLine("=> {0}", p.Name);
            }


            //var removeSomeMonths = from s in People_sData
            //                       where s.DOB.ToString("dd mmmm yyyy") > october
            //                       select s;

            //Console.WriteLine("\n\nwithout those born from september to december:\n");
            //Console.WriteLine("  name" + "\t\tnin" + "\t  dob" + "\t\t    genotype");
            //foreach (var s in removeSomeMonths)
            //Console.WriteLine(" " + s.Name + "\t\t" + s.NIN + "\t" + s.DOB + "\t\t" + s.Genotype);
        }
    }
}
