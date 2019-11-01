using System;
using System.Threading;

namespace TingOgSagerMedPoul
{
    class Program
    {
        static void Main(string[] args)
        {
            Huuman Niclas = new Huuman();
            Huuman Poul = new Huuman();
            Kaffekop myCup = new Kaffekop();
            Kaffekop poulCup = new Kaffekop();
            CoffeMachine myMachine = new CoffeMachine();

            // ============================== NEW HUUMAN
            Niclas.hairColor = "red";
            Niclas.hairLength = 100000;
            Niclas.LifeForce = 50;
            Niclas.name = "Niclas";
            Niclas.bodyWear = "hættetrøje";
            Niclas.bCurrentlySittingOnTable = true;
            // ================================== NEW HUUMAN
            Poul.LifeForce = 30;
            Poul.hairColor = "leverpostej";

            //================================================= NEW CUP
            myCup.diameter = 7.8;
            myCup.height = 8;
            myCup.color = "Titanium hwite";
            myCup.currentVolume = 0;
            myCup.bContainsLiquid = false;
            myCup.maxVolume = myCup.diameter * myCup.height;
            myCup.owner = Niclas;

            poulCup.diameter = 7.8;
            poulCup.height = 8;
            poulCup.color = "black";
            poulCup.currentVolume = 0;
            poulCup.bContainsLiquid = false;
            poulCup.maxVolume = myCup.diameter * myCup.height;
            poulCup.owner = Poul;

            //================================================ NEW CUP

            myMachine.bContainsCocoPowder = true;
            myMachine.bContainsCoffeePowder = true;
            myMachine.bContainsWater = true;
            myMachine.bCupRegistered = false;
            myMachine.bPowerConnected = true;
            myMachine.cocoAmount = 5500;
            myMachine.coffeeAmount = 5500;
            myMachine.waterAmount = 10000;

            //=============================================================== Program start

            Console.WriteLine("The machine is occupied currently: " + myCup.bPlacedInMachine);

            myMachine.PlaceCup(myCup);
            Console.WriteLine("you press *Coffee* and the machine starts humming");
            myCup.Fill(myMachine.FillingCupCoffee());
            Console.WriteLine("\nYour cup has sucesfully been filled with " + myCup.currentVolume + " dl coffee\n\n");
            Console.WriteLine("myCup being removed\n");
            Thread.Sleep(1400);
            myMachine.RemoveCup();

            Console.WriteLine("myCup is removed!");
            Console.ReadKey();

            Console.WriteLine("\n\nBut now Poul wants his morning coffee!");
            myMachine.PlaceCup(poulCup);
            Console.WriteLine("Pouls cup placed sucesfully: " + myCup.bPlacedInMachine);
            Console.WriteLine("\nPoul presses *coffee* and the machine starts humming!");
            poulCup.Fill(myMachine.FillingCupCoffee());

            Console.WriteLine("\nPouls cup has sucesfully been filled with " + poulCup.currentVolume + " dl coffee\n\n");
            Console.WriteLine("Pouls cup being removed\n");
            Thread.Sleep(1400);
            myMachine.RemoveCup();

            Console.WriteLine("Pouls cup is removed!");
            Console.ReadKey();
            // ==================================================

            Console.WriteLine("\n\nNiclas comes up to Poul and says goodmorning.");
            Console.WriteLine("BUT! because Niclass hair collor is " + Niclas.hairColor + ", Pouls life force starts to fade!");
            Console.ReadKey();

            Console.WriteLine("\nPuls life force was at " + Poul.LifeForce);
            Niclas.SuckSoul(Poul);
            Console.WriteLine("BUT! after Niclas came up to him, Pouls life force hit " + Poul.LifeForce);
            Console.ReadKey();

            Console.WriteLine("\nSo their individual life forces are now at ----->" + "\nNicklas: " +Niclas.LifeForce + "\nPoul: " + Poul.LifeForce);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nPouls self defence tries to get revenge on Niclas, but since Pouls hair color is " + Poul.hairColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Poul.SuckSoul(Niclas);
            Console.ReadKey();



            Console.WriteLine("\n\nNow nicklas leaves!");
            Niclas.bOwnsACar = true;
            Niclas.DriveToMcD();


        }
    }
}
