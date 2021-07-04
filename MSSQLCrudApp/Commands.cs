using MSSQLCrudApp.Models;
using NHibernate;
using System;
using System.Collections.Generic;

namespace MSSQLCrudApp
{
    public class Commands
    {
        private ISessionFactory factory;

        public Commands(ISessionFactory factory)
        {
            // Simple DP

            this.factory = factory;
        }

        public void AddEmployee(string FullName, float Salary, float? Speed, float? Accuracy, float? Efficiency)
        {
            using (var session = factory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var employee = new Employee()
                {
                    FullName = FullName,
                    Salary = Salary,
                    Speed = Speed,
                    Accuracy = Accuracy,
                    Efficiency = Efficiency
                };

                session.Save(employee);
                transaction.Commit();
            }
        }

        public IList<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeeFullName(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> RemoveEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
