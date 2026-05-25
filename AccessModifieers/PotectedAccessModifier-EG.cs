using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifieers
{
    class student
    {
        protected int sid;
        protected string sname;
        protected string scollege;

        public student(int sid, string sname, string scollege)
        {
            this.sid = sid;
            this.sname = sname;
            this.scollege = scollege;
        }
        public void displaydetails()
        {
            Console.WriteLine("Student ID is:-" + sid);
            Console.WriteLine("Student Name is:-"+sname);
            Console.WriteLine("Student College is:-" + scollege);
        }
    }
    class Branch : student
    {
        int bid;
        string bname;
        string baddress;

        public Branch(int  bid, string bname, string baddress):base(8,"Ashok","DIET")
        {
           this.bid = bid;
            this.bname = bname;
            this.baddress = baddress;
        }

        public void details()
        {
            base.displaydetails();
            Console.WriteLine("Branch id is:-" + bid);
            Console.WriteLine("Branch Name is:-" + bname);
            Console.WriteLine("Branch Address is:-" + baddress);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Branch id = new Branch(125,"GNM","Akp");
            id.details();

        }
    }
}
