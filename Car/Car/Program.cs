using System;
using Incapsulare3;
using Incapsulare3.Controllers;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerMasina c = new ControllerMasina();
            //add car
             Masina m = new Masina("Dacia", 111, 123, "verde", 1112,"fata");
             c.AdaugareMasina(m);
             c.saveToFileTxt();
             m.afisareOneCar();
             c.printAllCars();

            //delete car
            //c.DeleteCar("Dacia");
            c.saveToFileTxt();
            c.printAllCars();
        }
    }
}
