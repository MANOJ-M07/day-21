using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class EmpCollection
    {
        static List<Emp> emplist = new List<Emp>()
        {
            new Emp{Id = 1, Name ="sam", Salary=85654.32},
            new Emp{Id = 2, Name ="Anderson", Salary=85654.32},
            new Emp{Id = 3, Name ="Jimmy", Salary=85654.32},
            new Emp{Id = 4, Name ="Cortan", Salary=85654.32},
            new Emp{Id = 5, Name ="King", Salary=85654.32},
            new Emp{Id = 6, Name ="Kholi", Salary=85654.32},
        };
        public static void AddEmp()
        {
            Emp emp = new Emp();
            Console.WriteLine("Enter Employee Id");
            emp.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            emp.Salary = double.Parse(Console.ReadLine());
            emplist.Add(emp);
            Console.WriteLine("Added in employee List");
        }

        public static void RemoveEmp()
        {
            Console.WriteLine("enter Employee Id");
            int id = int.Parse(Console.ReadLine());
            Emp emp = emplist.SingleOrDefault(e=>e.Id == id);
            if (emp != null)
            {
                emplist.Remove(emp);
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        public static void DisplayList()
        {
            foreach(Emp e  in emplist)
            {
                Console.WriteLine("ID"+e.Id);
                Console.WriteLine("Name"+e.Name);
                Console.WriteLine("salary"+e.Salary);
            }
        }
    }
}
