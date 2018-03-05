using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your full Name please");
            string name= Console.ReadLine();
            WeDrive gogogo = new WeDrive(name);

            string select;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Driver:"+" " +name);
                Console.WriteLine("1. Drive");
                Console.WriteLine("2. Add Fuel");
                Console.WriteLine("3. Local Km");
                Console.WriteLine("4. Global Km");
                Console.WriteLine("0. Exit");
                Console.WriteLine(" ");
                select = Console.ReadLine();
                switch (Convert.ToInt32(select))
                {
                    case 1:
                        Console.WriteLine("\n");
                        Console.WriteLine("You have choosen to Drive");
                        Console.WriteLine("How many Km you want to Drive?");
                        string drivekm = Console.ReadLine();
                        int driveKm = 0;
                        while (!int.TryParse(drivekm,out driveKm))
                        {
                            Console.WriteLine("Error. Integers only ");
                            drivekm = Console.ReadLine();
                            
                        }
                        gogogo.CalcKM(driveKm);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        Console.WriteLine("You have choosen to Add some Fuel");
                        Console.WriteLine("How many Lt of Fuel you want to Add?");
                        string addfuel = Console.ReadLine();
                        int addFuel = 0;
                        while (!int.TryParse(addfuel, out addFuel))
                        {
                            Console.WriteLine("Error. Integers only ");
                            addfuel = Console.ReadLine();
                        }
                        gogogo.AddFuel(addFuel);
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        Console.WriteLine("You have choosen Local Km");
                        Console.WriteLine("Do you want to Reset Local Km? Y/N");
                        string yesorno = Console.ReadLine();
                        if (yesorno == "Y")
                        {
                            Console.WriteLine("You have reset Local Km ");
                            gogogo.ResetLocal(yesorno);
                        }
                        else
                        {
                            gogogo.LocalKm();
                        };
                        break;
                    case 4:
                        Console.WriteLine("\n");
                        Console.WriteLine("You have choosen Global Km");
                        gogogo.GlobalKm();
                        Console.WriteLine("\n");
                        break;
                }
            } while (Convert.ToInt32(select) != 0);

            Console.ReadLine();
        }
    }
}
