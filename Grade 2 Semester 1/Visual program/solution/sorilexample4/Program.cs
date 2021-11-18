using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace sorilexample4
{
    delegate string del(string str);

    class sample
    {
        public static string DelSample(string a)
        {
            return a.Replace(',', '*');
        }
    }


    class Program
    {

        
            

        static void Main(string[] args)
        {
            del str1 = new del(sample.DelSample);
            string str = str1("Welcome,,friends,,to,,TechBeamers");
            Console.WriteLine(str);
        }


    }
    






}
