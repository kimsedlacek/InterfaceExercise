using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var Car1 = new Car();
            var Truck1 = new Truck();
            var SUV1 = new SUV();

            Car1.Year = "2020";
            Car1.Make = "Ford";
            Car1.Model = "Fusion";
            Car1.HasSunroof = true;
            Car1.Mileage = 22000;
            Car1.WarningIndicators = 4;
            Car1.YearsOpen = 120;
            Car1.Motto = "Built Ford Tough";

            Truck1.Year = "2014";
            Truck1.Make = "Dodge";
            Truck1.Model = "Ram 1500";
            Truck1.DriveTrain = "4WD";
            Truck1.Color = "red";
            Truck1.WarningIndicators = 5;
            Truck1.YearsOpen = 100;
            Truck1.Motto = "If you ain't first, you're last!.";

            SUV1.Year = "2021";
            SUV1.Make = "Jeep";
            SUV1.Model = "Grand Cherokee";
            SUV1.NumberOfSeats = 5;
            SUV1.Spare = "full size";
            SUV1.WarningIndicators = 7;
            SUV1.YearsOpen = 80;
            SUV1.Motto = "Go Anywhere, Do Anything";

            Console.WriteLine($"\"{Car1.Year} {Car1.Make} {Car1.Model} For Sale\"\nThe {Car1.Make} {Car1.Model} " +
                $"is a solid and economical sedan.\nThis {Car1.Year} model has {Car1.Mileage.ToString("N0")} miles, " +
                $"{Car1.WarningIndicators} warning indicators to keep you safe and yes, it's " +
                $"{Car1.HasSunroof.ToString().ToLower()}, it has a sun roof! \nThe {Car1.Make} company has been in " +
                $"business for {Car1.YearsOpen} years, so you know they build a solid car, in fact, their motto is " +
                $"\"{Car1.Motto}!\"\n");

            Console.WriteLine($"We have a {Truck1.Year} {Truck1.Make} {Truck1.Model} that we use around our property" +
                $" to plow snow, haul wood, and move dirt.  Most of the original {Truck1.WarningIndicators} warning " +
                $"indicators no longer work, but that's okay because the {Truck1.DriveTrain} works great! {Truck1.Make}" +
                $" makes a great truck, they've been doing it for almost {Truck1.YearsOpen} years and their motto is \"" +
                $"{Truck1.Motto}\" We would gladly get another {Truck1.Make} {Truck1.Model}, but maybe in a different color so our " +
                $"kids don't call it \"BIG {Truck1.Color.ToUpper()}\" anymore.\n");

            Console.WriteLine($"My new car isn't brand new, it's a {SUV1.Year} {SUV1.Make} {SUV1.Model}, but so far," +
                $" I really like it!  It has {SUV1.NumberOfSeats} seats, {SUV1.WarningIndicators} warning indicators " +
                $"and a {SUV1.Spare} spare tire.  I've had {SUV1.Make}s before and I love them!  They've been around" +
                $" for over {SUV1.YearsOpen} years and their motto is true, you can \"{SUV1.Motto} in a Jeep!\"");
        }
    }
}
