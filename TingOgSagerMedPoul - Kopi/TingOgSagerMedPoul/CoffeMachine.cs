using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TingOgSagerMedPoul
{
    class CoffeMachine
    {
        public bool bContainsCocoPowder;
        public bool bContainsCoffeePowder;
        public bool bContainsWater;
        public bool bCupRegistered;
        public bool bPowerConnected;

        public double cocoAmount;
        public double coffeeAmount;
        public double waterAmount;

        public Kaffekop RegisteredCup;

        
        public double FillingCupCoffee()
        {
            if (bCupRegistered && bPowerConnected)
            {
                if (bContainsWater && bContainsCoffeePowder)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Currently brewing your coffee!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1800);
                    double fillingAmount = 4.5; //dl //hardcoded med vilje
                    return fillingAmount;
                }
               
            }
            return 0;
        }

        public void PlaceCup(Kaffekop Cup)
        {
            if (!bCupRegistered)
            {
                RegisteredCup = Cup;
                bCupRegistered = true;
                Cup.bPlacedInMachine = true;
                Console.WriteLine("\nPlacing cup");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cup placed successfully.\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Cup.bPlacedInMachine = false;
                Console.WriteLine("Couldn't place cup. Already cup there\n");
            }
        }


        public void RemoveCup()
        {
            RegisteredCup = null;
            bCupRegistered = false;
        }

    }
}
