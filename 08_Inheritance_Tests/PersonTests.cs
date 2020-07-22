using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();
            martha.PhoneNumber = "9707722";
            Console.WriteLine(martha.PhoneNumber);

            Customer bob = new Customer();
            bob.PhoneNumber = "123-1234";

            SalaryEmployee ted = new SalaryEmployee
            {
                PhoneNumber = "fakeNumber",
                HireDate = new DateTime(1304, 01, 01),
            };
            Console.WriteLine(ted.YearsWithCompany);
        }

        [TestMethod]
        public void CustomerIsPremium_ShouldGetCorrectBool()
        {
            Customer firstCustomer = new Customer();
            firstCustomer.IsPremium = true;

            Person newPerson = new Person();

            Console.WriteLine(newPerson.GetType());

            Console.WriteLine(firstCustomer.GetType());
            Assert.IsTrue(firstCustomer.IsPremium);
        }

        [TestMethod]
        public void EmployeeTests()
        {
            Employee jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            tony.HoursWorked = 55;
            tony.HourlyWage = 9003;
            pepper.Salary = 200000;

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(jarvis); //we never added any info so in the foreach loop it will be blank
            allEmployees.Add(tony); // we never set his name so in the foreach loop nothing will appear for worker.Name
            allEmployees.Add(pepper);
            //tony.Name = "Tony Stark";
            tony.SetFirstName("Tony");
            tony.SetLastName("Stark");

            foreach (Employee worker in allEmployees)
            {
                if (worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker; //casting because worker is of type List<Employee> and not SalaryEmployee
                    Console.WriteLine($"This is a salary employee that makes {sEmployee.Salary}");
                }
                else if (worker is HourlyEmployee hourlyWorker) //pattern matching-- so we don't have to cast like the below
                {
                    //HourlyEmployee hEmployee = (HourlyEmployee)hourlyWorker; -- casting
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }
        }
    }
}
