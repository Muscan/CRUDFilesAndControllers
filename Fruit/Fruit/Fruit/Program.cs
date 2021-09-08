using System;

namespace Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerFruct cf = new ControllerFruct();
            //cf.PrintAll();
            Fruct fr = new Fruct("Mar", 12, true, 2342);
            //cf.AddFruit(fr);
            cf.saveToFileTxt();
            cf.afisareOneItem(fr);

            //cf.Delete("Mar");
           //cf.saveToFileTxt();
            //cf.PrintAll();
           
        }
    }
}
