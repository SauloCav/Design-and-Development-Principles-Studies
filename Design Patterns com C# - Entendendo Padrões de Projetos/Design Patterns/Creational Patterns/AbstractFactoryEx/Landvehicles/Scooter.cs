using System;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Encomenda na mochila!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entraga com patinete...");
        }
    }
}
