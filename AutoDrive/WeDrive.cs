using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDrive
{
    class WeDrive
    {
        public string fullname;
        public int driveKM = 0;
        public int fuel = 140;
        public int addfuel = 0;
        public int spentFuel = 0;
        public int globalKM = 0;
        public int localKM = 0;
        public int fuelСonsumption /*per 100km*/ = 20;
        public string yesorno = "N";

        public WeDrive(string fullname)
        {
            this.fullname = fullname;
        }


        public void CalcKM(int drivekm)
        {
            this.spentFuel = drivekm * fuelСonsumption / 100;

            if (fuel> spentFuel)
            {
                this.driveKM = drivekm;
                this.localKM += drivekm;
                this.globalKM += drivekm;
                this.fuel -= this.spentFuel;
                Console.WriteLine("==============================");
                Console.WriteLine("You Drive" + " " + driveKM + " " + "Km");
                Console.WriteLine("You have spent" + " " + spentFuel + " " + "Lt of Fuel");
                Console.WriteLine(fuel + " " + "Lt of Fuel left");
                Console.WriteLine("\n");
                Console.WriteLine("Local Km is" + " " + localKM + " " + "Km");
                Console.WriteLine("Global Km is" + " " + globalKM + " " + "Km");
                Console.WriteLine("==============================");
            }
            else
            {
                Console.WriteLine("You don't have enough fuel for this trip");
                Console.WriteLine(fuel + " " + "Lt of Fuel left");
            }
        }

        public void AddFuel(int addFuel)
        {
            this.addfuel = addFuel;
            string leftspace = Convert.ToString(140 - fuel);
            if (addFuel < 140 - fuel)
            {
                this.fuel += addFuel;
                Console.WriteLine("Now you have" +" "+ fuel+" " +"Lt of Fuel");
            }
            else
            {
                Console.WriteLine("You have space only for"+" " +  leftspace + " "+"Lt of fuel");
            }

        }

        public void ResetLocal(string Yesorno)
        {
            this.yesorno = Yesorno;
            if (this.yesorno == "Y" )
            {
                localKM = 0;
            };
        }

        public void GlobalKm()
        {
            Console.WriteLine("Global Km is" + " " + globalKM + " " + "Km");
        }
        public void LocalKm()
        {
            Console.WriteLine("Local Km is" + " " + localKM + " " + "Km");
        }
    }


}
