using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Plant
{
    class ControllerPlanta
    {
        private List<Planta> plante;
        public ControllerPlanta()
        {
            plante = new List<Planta>();
            readFileTxt();

        }

        public void PrintAllPlants()
        {
            Console.WriteLine("Descrierea plantelor:");
            for (int i = 0; i < plante.Count; i++)
            {
                Console.WriteLine(plante[i].descPlanta());
            }
        }

        public int PlantaIndex(string nume)
        {
            for (int i = 0; i < plante.Count; i++)
            {
                if (plante[i].getNume().Equals(nume))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Add(Planta planta)
        {
            int indexPlanta = PlantaIndex(planta.getNume());
            if (indexPlanta == -1)
            {
                this.plante.Add(planta);
                Console.WriteLine("Item added");
                return true;
            }
            Console.WriteLine("Item already added");
            return false;
        }

        public bool Update(string nume, double pret)
        {

            int indexPosition = PlantaIndex(nume);

            if (indexPosition != -1)
            {
                plante[indexPosition].setNume(nume);
                Console.WriteLine("Pretul  a fost updatat");
                return true;
            }
            Console.WriteLine("Planta nu a fost gasita");
            return false;


        }


        public bool Delete(string nume)
        {
            int position = PlantaIndex(nume);
            if (position != -1)
            {
                Console.WriteLine("Planta " + plante[position].getNume() + " deleted");
                this.plante.RemoveAt(position);
                return true;
            }
            Console.WriteLine("Planta not deleted ");
            return false;

        }

        public void readFileTxt()
        {
            StreamReader read = new StreamReader(@"../../../Plante.txt");
            String line = "";
            line = read.ReadLine();

            while (line != "" && line != null)
            {
                //public Planta(bool IsGreen, int id, string nume, double inaltime)
                String[] proprietati = line.Split(",");
                Boolean isGreen = Boolean.Parse(proprietati[0]);
                int id = int.Parse(proprietati[1]);
                String nume = proprietati[2];
                double inaltime = double.Parse(proprietati[3]);

                Planta planta = new Planta(isGreen, id, nume, inaltime);
                plante.Add(planta);
                line = read.ReadLine();
            }
            read.Close();
        }
        public string toStringAllObjectsFromFile()//functie care converteste din obiect in fisier cu parametrii, in string
        {
            string propObiecte = "";
            for (int i = 0; i < plante.Count; i++)
            {
                propObiecte += plante[i].TakePropertiesFromClassAndConvertToString() + "\n";
            }
            return propObiecte;
        }
        public void saveToFileTxt()
        {
            StreamWriter write = new StreamWriter(@"../../../Plante.txt");

            write.WriteLine(this.toStringAllObjectsFromFile());
            write.Close();
        }
    }
}