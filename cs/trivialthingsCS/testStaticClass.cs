using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trivialthingsCS
{
    class testNormalClass
    {
        public static void testStt()
        {
            Console.WriteLine("static method in normal class");
        }

        public void testnoStt()
        {
            Console.WriteLine("NO static in normal class");
        }
    }

    static class testSttClass
    {
        public static void testSttInSttclass()
        {
            Console.WriteLine("static method in static class");
        }

        //public void testnoSttInSttclass() // can't do this only allow static method in static class
        //{
        //    Console.WriteLine("NO static in static class");
        //}
    }
}
