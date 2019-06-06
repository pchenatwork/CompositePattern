using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// Generic Singlton Factory base to any Factory class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class FactoryBase<T> where T : class
    {
        private static readonly Lazy<T> instance = new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);
        public static T Instance => instance.Value;
    }

    public class EmployeeFactory : FactoryBase<EmployeeFactory>
    {
        public Employee CreateEmployee(string Name)
        {
            object[] args = { Name };

            ///return Activator.CreateInstance(Type.GetType(typeof(Employee).FullName)) as Employee;

            return Activator.CreateInstance(typeof(Employee),
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null,
                    args, null) as Employee;
        }
    }
}
