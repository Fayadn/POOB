using System;
using System.Globalization;
using Lambda7.Entities;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lambda7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double avg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> listEmp = new List<Employee>();

            using (StreamReader read = File.OpenText(path))
            {
                while (!read.EndOfStream)
                {
                    string[] fields = read.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    listEmp.Add(new Employee(name, email, salary));
                }
            }
            var emails = listEmp.Where(p => p.Salary > avg).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than 2000.00:");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
            var sum = listEmp.Where(p => p.Name[0] == 'M').Sum(p => p.Salary).ToString("f2", CultureInfo.InvariantCulture);
            Console.Write("Sum of salary of people whose name starts with 'M': ");
            Console.WriteLine(sum);
        }
    }
}
