using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.Models;
using AutoLotDAL.DataOperations;
namespace xx
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car lexus = new Car();
            // lexus.CarId = 8;
            // lexus.Color = "Black";
            // lexus.Make = "Lexus";
            // lexus.PetName = "Davo";
            // InventoryDAL x = new InventoryDAL();
            //Car cd = x.GetCar(5);
            // Console.WriteLine(cd.PetName);
            // List<Car> cars = x.GetAllInventory();
            // foreach (var d in cars)
            //     Console.WriteLine($"{d.CarId}   {d.Color}  {d.Make}  {d.PetName}");
            //// x.InsertAuto("Black", "Lexus", "Davo");
            //// x.DeleteCar(12);
            // Console.WriteLine(x.LookUpPetName(5));
            MoveCustomer();
            Console.Read();
        }

        public static void MoveCustomer()
        {
            Console.WriteLine("***** Simple Transaction Example *****\n");
            // A simple way to allow the tx to succeed or not.
            bool throwEx = true;
            Console.Write("Do you want to throw an exception (Y or N): ");
            var userAnswer = Console.ReadLine();
            if (userAnswer?.ToLower() == "n")
            {
                throwEx = false;
            }
            var dal = new InventoryDAL(); // Process customer 1 – enter the id for the customer to move.
            dal.ProcessCreditRisk(throwEx, 2);
            Console.WriteLine("Check CreditRisk table for results");
            Console.Write("ghf");
            Console.ReadLine();
            //55
        }
    }
}
