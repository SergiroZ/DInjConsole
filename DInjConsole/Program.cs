using Autofac;
using System;
using IContainer = Autofac.IContainer;

namespace DInjConsole
{
    internal class Program
    {
        internal static IContainer GetBuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeRepository>()
                .As<IEmployeeRepository>()
                .InstancePerDependency();
            builder.RegisterType<EmployeeService>()
                .As<IEmployeeService>()
                .InstancePerDependency();
            return builder.Build();
        }

        private static void Main(string[] args)
        {
            var container = GetBuildContainer();
            var employeeServe = container.Resolve<IEmployeeService>();
            employeeServe.Print(1);
            employeeServe.Print(2);
            employeeServe.Print(3);
            Console.ReadLine();
        }
    }
}