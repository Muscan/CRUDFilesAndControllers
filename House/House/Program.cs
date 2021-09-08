using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------LOCUINTE-------------------------*//*
            ControllerLocuinta controllerLocuinte = new ControllerLocuinta();
            controllerLocuinte.PrintLocuinte();
            int nrLocuinte = controllerLocuinte.LocuinteMaterial();
            Console.WriteLine("Numarul locuintelor din caramida este: " + nrLocuinte);

            */

            ControllerLocuinta c = new ControllerLocuinta();
            //add House
            Locuinta l = new Locuinta("Casa roz", 845, "Verde", 120);
            //c.AddHouse(l);

            l.printOneHouse();
            //c.UpdateHouse("Casa1", 123);
            
            //c.DeleteHouse("Casa in aer");
            c.saveToFileTxt();
            c.PrintLocuinte();
        }
    }
}
