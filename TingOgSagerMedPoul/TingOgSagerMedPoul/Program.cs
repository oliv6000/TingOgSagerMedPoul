using System;

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

            Niclas.hairColor = "red";
            Niclas.hairLength = 100000;
            Niclas.LifeForce = 50;
            Niclas.name = "Niclas";
            Niclas.bodyWear = "hættetrøje";
            Niclas.bCurrentlySittingOnTable = true;

            Poul.LifeForce = 30;
            Poul.hairColor = "leverpostej";

            //=================================================00000000000000
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

            //================================================00

            myMachine.bContainsCocoPowder = true;
            myMachine.bContainsCoffeePowder = true;
            myMachine.bContainsWater = true;
            myMachine.bCupRegistered = false;
            myMachine.bPowerConnected = true;
            myMachine.cocoAmount = 5500;
            myMachine.coffeeAmount = 5500;
            myMachine.waterAmount = 10000;

            //===============================================================:D
            Console.WriteLine("The machine is occupied currently: " + myCup.bPlacedInMachine);

            myMachine.PlaceCup(myCup);
            Console.WriteLine("you press *Coffee* and the machine starts humming");
            myCup.Fill(myMachine.FillingCupCoffee());
            Console.WriteLine("\nYour cup has sucesfully been filled with " + myCup.currentVolume + " dl coffee");
            Console.ReadLine();

            myMachine.RemoveCup();
            Console.WriteLine("sadsd");
            Console.ReadLine();
            myMachine.PlaceCup(poulCup);
            Console.WriteLine("Pouls cup placed sucesfully: " + myCup.bPlacedInMachine);
            myCup.Fill(myMachine.FillingCupCoffee());
            Console.WriteLine(myCup.currentVolume);
            myMachine.PlaceCup(myCup);
            myMachine.RemoveCup();
            myMachine.PlaceCup(myCup);


            Niclas.SuckSoul(Poul);
            Console.WriteLine(Niclas.LifeForce + "\n" + Poul.LifeForce);
            Console.WriteLine("Poul tries to get revenge on Niclas, because he took some of his lifeForce");
            //Poul.SuckSoul(Niclas);
            //Console.WriteLine(Niclas.LifeForce + "\n" + Poul.LifeForce);

            Console.WriteLine("Now nicklas leaves");
            Niclas.bOwnsACar = true;
            Niclas.DriveToMcD();


        }
    }
}
