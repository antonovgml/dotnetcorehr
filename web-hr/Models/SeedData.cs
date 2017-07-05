using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webhr.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider svcProvider)
        {
            using (var ctx = new HRContext(svcProvider.GetRequiredService<DbContextOptions<HRContext>>()))
            {
                // Look for any person.
                if (ctx.Persons.Any())
                {
                    return;   // DB has been seeded
                }

                Department[] depts = new Department[2];

                depts[0] = new Department { Title = "Lotus" };
                depts[1] = new Department { Title = "Java" };

                ctx.Departments.AddRange(depts);


                ctx.Persons.AddRange(
                    new Person {
                        BirthDate = DateTime.Parse("2000-10-20"),
                        FirstName = "Ivan",
                        LastName = "Ivanov",
                        PatronymicName = "Ivanovich",
                        Salary = 1000.1M,
                        Title = "Mr.",
                        Department = depts[0]
                    },
                    new Person
                    {
                        BirthDate = DateTime.Parse("2000-10-21"),
                        FirstName = "Petr",
                        LastName = "Petrov",
                        PatronymicName = "Petrovich",
                        Salary = 2000,
                        Title = "Dr.",
                        Department = depts[0]

                    },

                    new Person
                    {
                        BirthDate = DateTime.Parse("2000-10-22"),
                        FirstName = "Sidor",
                        LastName = "Sidorov",
                        PatronymicName = "Sidorovich",
                        Salary = 3000.3M,
                        Title = "Herr.",
                        Department = depts[1]
                    },

                    new Person
                    {
                        BirthDate = DateTime.Parse("2000-10-23"),
                        FirstName = "Vasya",
                        LastName = "Pupkin",
                        PatronymicName = "",
                        Salary = 4000.004M,
                        Title = "Mr.",
                        Department = depts[1]
                    }

                );




                ctx.SaveChanges();
            }

        }
    }
}
