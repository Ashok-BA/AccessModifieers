////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace AccessModifieers
////{
////    class myclass
////    {
////        protected int a = 10;

////        public void displaymyclass()
////        {
////            Console.WriteLine("value of a under myclass is:-" + a);
////        }

////    }

////    class newclass:myclass
////    {
////        public void displaynewclass()
////        {
////            base.displaymyclass();

////            Console.WriteLine("value of a under new class"+a);
            
////        }
////    }
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            newclass obj = new newclass();
////            obj.displaynewclass();
////        }
////    }
////}
