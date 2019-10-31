using System;
using System.Collections.Generic;
using System.Text;

namespace TingOgSagerMedPoul
{
    class Huuman
    {
        public string hairColor;
        public string name;
        public bool bCurrentlySittingOnTable;
        public string bodyWear;
        public double hairLength;
        public bool bOwnsACar;

        public int LifeForce;

        public void DriveToMcD()
        {
            if (bOwnsACar)
            {
                Console.WriteLine("Niclas is now on his way to the McD, for more soul sucking!");
            }
            else
            {
                Console.WriteLine("Niclas does not own a car.");
            }
        }

        public void SuckSoul(Huuman prey)
        {
            if (hairColor.ToLower().Trim() == "red")
            {
                int damage = 30;
                LifeForce += damage;
                prey.LifeForce -= damage;

            }
            else
            {
                Console.WriteLine("ability failed - User not ginger");
            }
        }

        public Program Programming() // bare et meme Mads, okay?
        {
            Program program = new Program();
            LifeForce -= 5;

            return program;
        }



        // det var det han kunne

    }
}
