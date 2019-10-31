using System;
using System.Collections.Generic;
using System.Text;

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
                Console.WriteLine("Cup placed successfully.");
            }
            else
            {
                Cup.bPlacedInMachine = false;
                Console.WriteLine("Couldn't place cup. Already cup there");
            }
        }


        public void RemoveCup()
        {
            RegisteredCup = null;
            bCupRegistered = false;
        }

    }
}
