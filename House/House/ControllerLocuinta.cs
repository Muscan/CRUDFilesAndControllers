using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace House
{
    //D:\C# Basics\Controllers\House\House\Houses.txt
    class ControllerLocuinta
    {
        private List<Locuinta> locuinte;
        public ControllerLocuinta()
        {
            /*locuinte = new List<Locuinta>();
            Locuinta locuinta1 = new Locuinta("Caramida", 230, "Alba", 230000.23);
            Locuinta locuinta2 = new Locuinta("Lemn", 123, "Maro", 102220);
            Locuinta locuinta3 = new Locuinta("Caramida", 189, "Rosie", 210110.45);

            locuinte.Add(locuinta1);
            locuinte.Add(locuinta2);
            locuinte.Add(locuinta3);*/

            locuinte = new List<Locuinta>();
            readFileTxt();
        }

        public void PrintLocuinte()
        {
            Console.WriteLine("Descrierea locuintelor:");
            for (int i = 0; i < locuinte.Count; i++)
            {
                Console.WriteLine(locuinte[i].DescriereLocuinta());
            }
        }

        public int LocuinteMaterial()
        {
            Console.WriteLine("Locuintele din acelasi material: ");
            int contor = 0;
            for (int i = 0; i < locuinte.Count; i++)
            {
                if (locuinte[i].getMaterial() == "Caramida")
                {
                    Console.WriteLine(locuinte[i].DescriereLocuinta());
                    contor++;
                }
            }
            return contor;
        }

        //find index of an elem
        public int HouseIndex(string material)
        {
            for (int i = 0; i < locuinte.Count; i++)
            {
                if (locuinte[i].getMaterial().Equals(material))
                {
                    return i;
                }
            }
            return -1;
        }

        //Add a house
        public bool AddHouse(Locuinta locuinta)
        {
            int indexLocuinta = HouseIndex(locuinta.getMaterial());
            if (indexLocuinta == -1)
            {
                this.locuinte.Add(locuinta);
                Console.WriteLine("House added");
                return true;
            }
            Console.WriteLine("House already added");
            return false;
        }


        public bool UpdateHouse(string material, double pret)
        {

            int indexPosition = HouseIndex(material);

            if (indexPosition != -1)
            {
                locuinte[indexPosition].setPret(pret);
                Console.WriteLine("Pretul casei a fost updatat");
                return true;
            }
            Console.WriteLine("Casa nu a fost gasita");
            return false;

        }

        public bool DeleteHouse(string material)
        {
            int position = HouseIndex(material);
            if (position != -1)
            {
                Console.WriteLine("House " + locuinte[position].getMaterial()+ " deleted");
                this.locuinte.RemoveAt(position);
                return true;
            }
            Console.WriteLine("House not deleted ");
            return false;

        }

        public void readFileTxt()
        {
            StreamReader read = new StreamReader(@"../../../Houses.txt");
            String line = "";
            line = read.ReadLine();

             while (line != "" && line != null)
                {
                //(string material, int mp, string culoare, double pret)
                String[] proprietati = line.Split(",");
                String material = proprietati[0];
                int mp = int.Parse(proprietati[1]);
                String culoare = proprietati[2];
                double pret = double.Parse(proprietati[3]);

                Locuinta locuinta = new Locuinta(material, mp, culoare, pret);
                locuinte.Add(locuinta);
                line = read.ReadLine();
            }
            read.Close();
        }
        //pune toate proprietatile obiectelor intr-un string
        public string toStringAllObjectsFromFile()//functie care converteste din obiect in fisier cu parametrii, in string
        {
            string propObiecte = "";
            for (int i = 0; i < locuinte.Count; i++)
            {
                propObiecte += locuinte[i].takeHousePropertiesFromClassAndConvertToString() + "\n";
            }
            return propObiecte;
        }
        public void saveToFileTxt()
        {
            StreamWriter write = new StreamWriter(@"../../../Houses.txt");

            write.WriteLine(this.toStringAllObjectsFromFile());
            write.Close();
        }
    }
}
