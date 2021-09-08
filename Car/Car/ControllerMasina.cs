using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Incapsulare3.Controllers
{
    class ControllerMasina
    {
        private List<Masina> masini;
        public ControllerMasina()
        {
            masini = new List<Masina>();

            readFileTxt();

        }
        public void printAllCars()
        {
            Console.WriteLine("Descrierea masinilor existente: ");
            for (int i = 0; i < masini.Count; i++)
            {
                Console.WriteLine(masini[i].descriereMasina());

            }
        }
        public Masina masinaPuternica()
        {
            Masina bigEngine = masini[0];
            for (int i = 1; i < masini.Count; i++)
            {
                if (bigEngine.getMotor() < masini[i].getMotor())
                {
                    bigEngine = masini[i];
                }

            }
            return bigEngine;
        }
        //find index of an elem
        public int carIndex(string marca)
        {
            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getMarca().Equals(marca))
                {
                    return i;
                }
            }
            return -1;
        }

        //Add car
        public bool AdaugareMasina(Masina masina)
        {
            int indexMasina = carIndex(masina.getMarca());
            if (indexMasina == -1)
            {
                this.masini.Add(masina);
                Console.WriteLine("Car added!");
                return true;
            }
            Console.WriteLine("Car exists");
            return false;
        }



        public bool DeleteCar(string masina)
        {

            int p = carIndex(masina);
            if (p != -1)
            {
                Console.WriteLine("Car " + masini[p].getMarca() + " deleted!");
                this.masini.RemoveAt(p);
                return true;

            }

            Console.WriteLine("Car not deleted");
            return false;


        }

        //functie care converteste obiectul care urmeaza sa fie salvat in fisier
        public void readFileTxt()
        {
            StreamReader read = new StreamReader(@"D:\C# Basics\Controllers\Car\Car\Masini.txt");
            //D:\C# Basics\Controllers\Car\Car\Masini.txt
            String line = "";
            //string marca, int pret, double motor, string culoare, int anFabricatie, string tractiune
            line = read.ReadLine();

            while (line != "" && line != null)
            //(string marca, int pret, double motor, string culoare, int anFabricatie, string tractiune)
            {

                String[] proprietati = line.Split(",");

                String marca = proprietati[0];
                int pret = int.Parse(proprietati[1]);
                double motor = double.Parse(proprietati[2]);
                String culoare = proprietati[3];
                int anFabricatie = int.Parse(proprietati[4]);
                String tractiune = proprietati[5];

                Masina masina = new Masina(marca, pret, motor, culoare, anFabricatie, tractiune);
                masini.Add(masina);
                line = read.ReadLine();
            }
            read.Close();
        }


        public string toStringAllObjectsFromFile()//functie care converteste din obiect in fisier cu parametrii, in string
        {
            string tot = "";

            for (int i = 0; i < masini.Count; i++)
            {

                tot += masini[i].takeCarPropertiesFromClassAndConvertToString() + "\n";
            }


            return tot;
        }

        public void saveToFileTxt()
        {

            StreamWriter write = new StreamWriter(@"D:\C# Basics\Controllers\Car\Car\Masini.txt");


            write.WriteLine(this.toStringAllObjectsFromFile());


            write.Close();
        }
    }
}
