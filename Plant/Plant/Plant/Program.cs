using System;

namespace Plant
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerPlanta controllerPlanta = new ControllerPlanta();
           // controllerPlanta.PrintAllPlants();
            //Planta v = new Planta(true, 1, "Rosie ornamentala", 201);
            //controllerPlanta.Add(v);
            
            controllerPlanta.Delete("Muscata");
            controllerPlanta.saveToFileTxt();
            controllerPlanta.PrintAllPlants();
        }
    }
}
