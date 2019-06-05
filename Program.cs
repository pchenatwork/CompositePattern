using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee A1 = new Employee("Teammember A1");
            A1.GetData();
            Employee A2 = new Employee("Teammember A2");
            A2.GetData();
            Console.WriteLine("------------------------------");

            Manager TeamLeadA = new Manager("Team A Lead");
            TeamLeadA.ManageMember(A1);
            TeamLeadA.ManageMember(A2);
            TeamLeadA.GetData();
            Console.WriteLine("------------------------------");

            Employee B1 = new Employee("Developer B1");
            Employee B2 = new Employee("Developer B2");
            Employee B3 = new Employee("Developer B3");

            Manager TeamLeadB= new Manager("Team B Lead");
            TeamLeadB.ManageMember(B1);
            TeamLeadB.ManageMember(B2);
            TeamLeadB.ManageMember(B3);

            Manager DepartmentHead = new Manager("Department Head");
            Employee Secretary = new Employee("Department Secretary");

            DepartmentHead.ManageMember(TeamLeadA);
            DepartmentHead.ManageMember(TeamLeadB);
            DepartmentHead.ManageMember(Secretary);

            DepartmentHead.GetData();
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }
    }
}
