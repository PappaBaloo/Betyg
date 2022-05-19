using System;
using System.Collections.Generic;

namespace Betyg
{
    public class basement : Building
    {

        public List<string> nameOfPotentialPrisoners = new List<string>() { "Aironas", "Rebecca", "Widell", "Gustav", "Eliss", "Villus", "Joel", "Leo" };
        public List<string> nameOfActualPrisoners = new List<string>();


        // Random generator = new Random();

        public int numberOfPrisoners;

        public basement()
        {

            for (int i = 0; i < nameOfPotentialPrisoners.Count; i++)
            {

                int result = generator.Next(1, 101);

                if (result >= 50)
                {

                    numberOfPrisoners += 1;

                    nameOfActualPrisoners.Add(nameOfPotentialPrisoners[i]);

                }


            }

        }

    }
}