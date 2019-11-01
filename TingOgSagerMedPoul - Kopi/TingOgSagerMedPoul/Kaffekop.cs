using System;
using System.Collections.Generic;
using System.Text;

namespace TingOgSagerMedPoul
{
    class Kaffekop
    {
        
        
        public double diameter; //In centimeters
        public double height;
        public double maxVolume;
        public double currentVolume;

        public string color;

        public bool bContainsLiquid;
        public bool bPlacedInMachine;

        public Huuman owner;

        public void Fill(double liquidAmount)
        {
            if (bPlacedInMachine) 
            { 
                if (liquidAmount > 0)
                {
                    bContainsLiquid = true;
                    currentVolume = currentVolume + liquidAmount;
                   if (currentVolume > maxVolume )
                    {
                        currentVolume = maxVolume;
                    }
                }
            }
        }
        public void Empty(double liquidAmount)
        {
            if (liquidAmount > 0)
            {
                currentVolume = currentVolume - liquidAmount;
                if (currentVolume <= 0)
                {
                    currentVolume = 0;
                    bContainsLiquid = false;
                }
                else
                {
                    bContainsLiquid = true;
                }
            }



        }

    }
}
