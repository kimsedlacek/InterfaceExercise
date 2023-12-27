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

            var car1 = new Car();
            var truck1 = new Truck();
            var suv1 = new SUV();

            car1.Year = "2020";
            car1.Make = "Ford";
            car1.Model = "Fusion";
            car1.HasSunroof = true;
            car1.Mileage = 22000;
            car1.WarningIndicators = 4;
            car1.YearsOpen = 120;
            car1.Motto = "Built Ford Tough";

            truck1.Year = "2014";
            truck1.Make = "Dodge";
            truck1.Model = "Ram 1500";
            truck1.DriveTrain = "4WD";
            truck1.Color = "red";
            truck1.WarningIndicators = 5;
            truck1.YearsOpen = 100;
            truck1.Motto = "If you ain't first, you're last!.";

            suv1.Year = "2021";
            suv1.Make = "Jeep";
            suv1.Model = "Grand Cherokee";
            suv1.NumberOfSeats = 5;
            suv1.Spare = "full size";
            suv1.WarningIndicators = 7;
            suv1.YearsOpen = 80;
            suv1.Motto = "Go Anywhere, Do Anything";

            Console.WriteLine($"\"{car1.Year} {car1.Make} {car1.Model} For Sale\"\nThe {car1.Make} {car1.Model} " +
                $"is a solid and economical sedan.\nThis {car1.Year} model has {car1.Mileage.ToString("N0")} miles, " +
                $"{car1.WarningIndicators} warning indicators to keep you safe and yes, it's " +
                $"{car1.HasSunroof.ToString().ToLower()}, it has a sun roof! \nThe {car1.Make} company has been in " +
                $"business for {car1.YearsOpen} years, so you know they build a solid car, in fact, their motto is " +
                $"\"{car1.Motto}!\"\n");

            Console.WriteLine($"We have a {truck1.Year} {truck1.Make} {truck1.Model} that we use around our property" +
                $" to plow snow, haul wood, and move dirt.  Most of the original {truck1.WarningIndicators} warning " +
                $"indicators no longer work, but that's okay because the {truck1.DriveTrain} works great! {truck1.Make}" +
                $" makes a great truck, they've been doing it for almost {truck1.YearsOpen} years and their motto is \"" +
                $"{truck1.Motto}\" We would gladly get another {truck1.Make} {truck1.Model}, but maybe in a different color so our " +
                $"kids don't call it \"BIG {truck1.Color.ToUpper()}\" anymore.\n");

            Console.WriteLine($"My new car isn't brand new, it's a {suv1.Year} {suv1.Make} {suv1.Model}, but so far," +
                $" I really like it!  It has {suv1.NumberOfSeats} seats, {suv1.WarningIndicators} warning indicators " +
                $"and a {suv1.Spare} spare tire.  I've had {suv1.Make}s before and I love them!  They've been around" +
                $" for over {suv1.YearsOpen} years and their motto is true, you can \"{suv1.Motto} in a Jeep!\"");
        }
    }
}
