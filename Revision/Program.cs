using System.Collections;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Revision.Data;
using Revision.DbContexts;

namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        using CompanyDbContext dbContext = new CompanyDbContext();
        // dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        // Employee employee1 = new Employee()
        // {
        //     EmpName = "Omar",
        //     Age = 21,
        //     Email = "example@gmail.com",
        //     Password = "P@ssw0rd",
        //     Salary = 40000,
        //     PhoneNumber = "1234567890",
        //     MyProperty = 100
        // };
        //
        // Console.WriteLine(dbContext.Entry<Employee>(employee1).State); // Detached
        // dbContext.Add(employee1);
        // Console.WriteLine(dbContext.Entry<Employee>(employee1).State); // Added
        // dbContext.SaveChanges();
        // Console.WriteLine(dbContext.Entry<Employee>(employee1).State); // Unchanged
        // employee1.Salary = 45000;
        // Console.WriteLine(dbContext.Entry<Employee>(employee1).State); // Modified
        // dbContext.SaveChanges();
        // Console.WriteLine(dbContext.Entry<Employee>(employee1).State); // Unchanged
        // dbContext.Remove(employee1);
        // Console.WriteLine(dbContext.Entry<Employee>(employee1).State); // Deleted
        // dbContext.SaveChanges();
        // Console.WriteLine(dbContext.Entry<Employee>(employee1).State); // Detached

        // var emp01 = dbContext.Employees.AsNoTracking().FirstOrDefault(e => e.EmpId == 1);
        // if (emp01 is not null)
        // {
        //     Console.WriteLine(dbContext.Entry(emp01).State);
        //     Console.WriteLine($"{emp01.EmpName} {emp01.Salary} {emp01.Age} {emp01.Email} {emp01.Password} {emp01.PhoneNumber} {emp01.MyProperty}");
        // }
        // var emp02 = dbContext.Employees.FirstOrDefault(e => e.EmpId == 2);
        // emp02.EmpName = "John Doe";
        // Console.WriteLine(dbContext.Entry(emp02).State);
        // dbContext.SaveChanges();
        
        // var emp01 = dbContext.Employees.FirstOrDefault(e => e.EmpId == 1);
        // if (emp01 is not null)
        // {
        //     Console.WriteLine(dbContext.Entry(emp01).State);
        //     Console.WriteLine($"{emp01.EmpName} {emp01.Salary} {emp01.Age} {emp01.Email} {emp01.Password} {emp01.PhoneNumber} {emp01.MyProperty}");
        //     dbContext.Remove(emp01);
        //     Console.WriteLine(dbContext.Entry(emp01).State); // Deleted
        //     dbContext.SaveChanges();
        //     Console.WriteLine(dbContext.Entry(emp01).State); // Detached
        // }
    }
}