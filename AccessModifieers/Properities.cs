////////using System;
////////using System.Collections.Generic;
////////using System.Linq;
////////using System.Text;
////////using System.Threading.Tasks;

////////namespace AccessModifieers
////////{ 
////////    class student
////////    {
////////        private string name;

////////        public String Name
////////        {
////////            get
////////            {
////////                return name;
////////            }
////////            set
////////            {
////////                name = value;
////////            }
////////        }
////////    }
////////    internal class program
////////    {
////////        static void Main(string[] args)
////////        {
////////            student stud = new student();
////////            stud.Name = "RAM";
////////            Console.WriteLine(stud.Name);
            
////////        }
////////    }
////////}
