using WeaponProject.Models;

namespace Test2;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("==============================START==============================");
        Console.Write("Max Ammo: ");
        int maxAmmo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ammo: ");
        int ammo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mag Fixed Empty Seconds: ");
        int magFixedMtSec = Convert.ToInt32(Console.ReadLine());
        Console.Write("Is Auto(true/false): ");
        bool isAuto = Convert.ToBoolean(Console.ReadLine());
        Weapon weapon = new Weapon(maxAmmo, ammo, magFixedMtSec, isAuto);
        ShowControls();

        while (true)
        {

            bool stopTheGame = false;
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 0:
                    weapon.Shoot();
                    break;
                case 1:
                    weapon.Fire();
                    break;
                case 2:
                    Console.Write("Is Auto(true/false): ");
                    bool Auto = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine(Auto);
                    weapon.ChangeFireMode(Auto);
                    Console.WriteLine(weapon.IsAuto);
                    break;
                case 3:
                    if (weapon.GetRemainBulletCount() == 0) Console.WriteLine("Mag is full!");
                    Console.WriteLine("You need " + weapon.GetRemainBulletCount() + " bullets for a full mag!"); ;
                    break;
                case 4:
                    weapon.MagInfo();
                    break;
                case 5:
                    weapon.Reload();
                    break;
                case 6:
                    stopTheGame = true;
                    Console.WriteLine("==============================END==============================");
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine("Here is a list of the control inputs! (and a cat)");
                    ShowControls();
                    break;
            }
            if (stopTheGame) break;
        }
    }

    static void ShowControls()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("""
                          0 - Shoot
                          1 - Fire
                          2 - Fire Mode              /\_/\
                          3 - Remaining bullets     ( o.o )
                          4 - Info                    >^<
                          5 - Reload
                          6 - Exit
                          """);
        Console.WriteLine("-------------------------------------");
    }
}