
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public abstract class EmployeeBase
    {
        protected string _name;
        public EmployeeBase(string name)
        {
            _name = name;
        }
        /// <summary>
        /// Unified Operation() among components
        /// </summary>
        public abstract void GetData();
    }

    public class Employee : EmployeeBase
    {
        /* Private constructor force the class to be created using EmployeeFactory  */
        public Employee(string Name) : base(Name) { }

        public override void GetData()
        {
            Console.WriteLine(base._name);
        }
    }

    public class Manager : EmployeeBase
    {
        private List<EmployeeBase> _teamMembers = new List<EmployeeBase>();

        public Manager(string Name) : base(Name) { }
        public void ManageMember(EmployeeBase employee)
        {
            _teamMembers.Add(employee);
        }

        public override void GetData()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Manager Name = " + base._name );

            if (_teamMembers.Count>0)
                sb.Append(", has " + _teamMembers.Count.ToString() + " teammate");

            Console.WriteLine(sb.ToString());

            foreach (var worker in _teamMembers)
            {
                worker.GetData();
            }
        }
    }
}
