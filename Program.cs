using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee developer1 = EmployeeFactory.Instance.CreateEmployee("Developer D1");
            developer1.GetData();
            Employee A1 = EmployeeFactory.Instance.CreateEmployee("Teammember A1");
            A1.GetData();
            Employee A2 = EmployeeFactory.Instance.CreateEmployee("Teammember A2");
            A2.GetData();
            Console.WriteLine("------------------------------");

            Manager TeamLeadA = new Manager("Team A Lead");
            TeamLeadA.ManageMember(A1);
            TeamLeadA.ManageMember(A2);
            TeamLeadA.GetData();
            Console.WriteLine("------------------------------");

            Employee B1 = EmployeeFactory.Instance.CreateEmployee("Developer B1");
            Employee B2 = EmployeeFactory.Instance.CreateEmployee("Developer B2");
            Employee B3 = EmployeeFactory.Instance.CreateEmployee("Developer B3");

            Manager TeamLeadB = new Manager("Team B Lead");
            TeamLeadB.ManageMember(B1);
            TeamLeadB.ManageMember(B2);
            TeamLeadB.ManageMember(B3);

            Manager DepartmentHead = new Manager("Department Head");
            Employee Secretary = EmployeeFactory.Instance.CreateEmployee("Department Secretary");

            DepartmentHead.ManageMember(TeamLeadA);
            DepartmentHead.ManageMember(TeamLeadB);
            DepartmentHead.ManageMember(Secretary);

            DepartmentHead.GetData();
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }
    }
}
