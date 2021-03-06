﻿using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTester();
            Console.ReadKey();
        }

        private static void AddTester()
        {
            Tester tester = new Tester
            {
                ID = "12345",
                Name = new Name { FirstName = "jojo", LastName = "chalass" },
                Address = new Address
                {
                    City = "Jerusalem",
                    Number = 21,
                    StreetName = "havvad haleumi",
                    //                  ZipCode = 91160
                },
                DayOfBirth = DateTime.Now.AddYears(-20),
                Gender = Gender.MALE,
                Experience = 10,
                Expertise = CarType.Truck_Heavy,
                MaxDistance = 2,
                MaxTestWeekly = 1,
                Luz = new Schedule(new bool[5, 6] {
                        { false, false, true, false, false, false},
                        { false, false, false, false, false, false},
                        { false, false, false, false, false, false},
                        { false, false, true, false, false, false},
                        { false, false, false, false, false, false} })
            };
            try
            {
                BL.IBL mofa = BL.FactorySingletonBL.getInstance();
                mofa.AddTester(tester);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
