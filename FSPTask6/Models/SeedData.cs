using FSPTask6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSPTask6.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FSPTask6Context(serviceProvider.GetRequiredService<
                    DbContextOptions<FSPTask6Context>>()))
            {
                // Look for any passengers.
                if (context.Passenger.Any())
                {
                    return;   // DB has been seeded
                }

                var passengers = new List<Passenger>
                {
                    new Passenger{FirstName = "Carson", LastName = "Alexander", DateOfBirth = new DateTime(1980, 04, 13)},
                    new Passenger{FirstName = "Arturo", LastName = "Justice", DateOfBirth = new DateTime(1993, 11, 04)},
                    new Passenger{FirstName = "Laura", LastName = "Norman", DateOfBirth = new DateTime(2000, 05, 9)},
                    new Passenger{FirstName = "Gytis", LastName = "Barzdukas", DateOfBirth = new DateTime(1997, 07, 03)}
                };

                passengers.ForEach(d => context.Passenger.Add(d));
                context.SaveChanges();

                var passports = new List<Passport>
                {
                    new Passport{ PassportNumber = 272273210, ValidDate =  new DateTime(2025, 01, 17), PassengerId=1 },
                    new Passport{ PassportNumber = 164872658, ValidDate =  new DateTime(2022, 12, 02), PassengerId=2 },
                    new Passport{ PassportNumber = 644782827, ValidDate =  new DateTime(2026, 01, 12), PassengerId=3 },
                    new Passport{ PassportNumber = 763279831, ValidDate =  new DateTime(2023, 09, 26), PassengerId=4 },
                };
                passports.ForEach(p => context.Passport.Add(p));
                context.SaveChanges();
            }
        }
    }
}
