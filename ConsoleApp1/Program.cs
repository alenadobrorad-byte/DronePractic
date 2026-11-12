using ConsoleApp1;
using DronePractic;
using DronePractic1;

class Program
{
    static void Main()
    {
        AttackReconDrone orion = new AttackReconDrone(
        "Орион", "Кронштадт",
        200, 250, 30, 1150,  // общие параметры
        60, 7000,            // параметры разведчика
        "крылатая ракета", 4 // параметры ударного вооружения
        );

        orion.PerformReconAndStrike();

        LoiteringMunition lancet2 = new LoiteringMunition(
        "Ланцет-3", "ZALA",
        110, 100, 1, 12,
        5, "бронетехника",
        30, "оптико-электронное"
        );

        lancet2.LoiterAndStrike();

        TransportDrone koshchey = new TransportDrone(
        "Кощей", "Авирон",
        80, 250, 6, 500,   // общие параметры (примерные)
        320, "медицинский"
        );
        koshchey.DeliverCargo();

        // «Форпост-Р» — разведывательный БПЛА
        ReconDrone forpost = new ReconDrone(
            "Форпост-Р", "УЗГА",
            200, 250, 18, 500,   // общие параметры
            60, 6000             // камера 60 Мп, высота 6000 м
        );

        // «Ланцет-3» — ударный БПЛА
        AttackDrone lancet = new AttackDrone(
            "Ланцет-3", "ZALA",
            110, 100, 1, 12,     // общие параметры
            5, "бронетехника"    // боевая часть 5 кг
        );

        Drone[] drones =
        {
        forpost,
        lancet,
        koshchey,
        lancet2,
        orion
        };

        Console.WriteLine("=== Массив дронов ===");

        foreach (Drone drone in drones)
        {
            Console.WriteLine(drone.GetInfo());
        }

        Console.WriteLine("=== Унаследованный метод GetInfo() ===");
        Console.WriteLine(forpost.GetInfo());
        Console.WriteLine(lancet.GetInfo());

        Console.WriteLine("\n=== Собственные методы ===");
        forpost.PerformReconnaissance();
        lancet.PerformStrike();
    }
}