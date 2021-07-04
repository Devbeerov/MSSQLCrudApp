using MSSQLCrudApp;
using NHibernate;
using NHibernate.Cfg;
using NUnit.Framework;
using System.Data.SqlClient;

namespace TestProject
{
    public class Tests
    {
        private static string connectionString = "Data Source=777-ПК;Initial Catalog=CrudTestingDB;Integrated Security=True";

        private Commands commands;
        private SqlConnection connection;

        [SetUp]
        public void Setup()
        {
            // Setups two connections, to ensure that everything work correctly.

            connection = new SqlConnection(connectionString);
            connection.Open();

            // NHibernate setup

            var config = new Configuration().Configure();
            var factory = config.BuildSessionFactory();
            commands = new Commands(factory);
        }

        [Test]
        public void TestCreate()
        {
            string FullName = "Иванов Александр Александрович";
            float Salary = 60000;
            float Speed = 0.5f;
            float Accuracy = 0.6f;
            float Efficiency = 0.9f;

            commands.AddEmployee(FullName, Salary, Speed, Accuracy, Efficiency);

            Assert.DoesNotThrow(() =>
            {
                // Name

                var nameReader = new SqlCommand($"SELECT 1 FROM EmployeeInfoTable WHERE FullName = {FullName}", connection).ExecuteReader();
                Assert.AreEqual(FullName, nameReader.GetString(0));

                // Salary

                var salaryReader = new SqlCommand($"SELECT 1 FROM EmployeeInfoTable WHERE Salary = {Salary}", connection).ExecuteReader();
                Assert.AreEqual(Salary, salaryReader.GetString(0));


            });

        }

        [Test]
        public void TestRead()
        {
            Assert.Fail();
        }

        [Test]
        public void TestUpdate()
        {
            Assert.Fail();
        }

        [Test]
        public void TestDelete()
        {
            Assert.Fail();
        }
    }
}