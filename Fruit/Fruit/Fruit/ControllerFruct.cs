using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fruit
{
    class ControllerFruct
    {
        private List<Fruct> fructe;


        public ControllerFruct()
        {
            fructe = new List<Fruct>();

            readFileTxt();
        }
        
        public void PrintAll()
        {
            Console.WriteLine("Descriere: ");
            for (int i = 0; i < fructe.Count; i++)
            {

                Console.WriteLine(fructe[i].descriereFruct());
            }
        }

        public void afisareOneItem(Fruct fruct)
        {
            Console.WriteLine(fruct.descriereFruct());
        }




        public int pozitieFruct(string nume)
        {

            for (int i = 0; i < fructe.Count; i++)
            {
                if (fructe[i].getNume().Equals(nume))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool AddFruit(Fruct fruct)
        {

            int poz = pozitieFruct(fruct.getNume());

            if (poz == -1)
            {

                this.fructe.Add(fruct);
                Console.WriteLine("Item added!");
                return true;

            }
            Console.WriteLine("Item exists");
            return false;
        }


        public bool UpdateNumeFruct(string nume, int pret)
        {

            int p = pozitieFruct(nume);

            if (p != -1)
            {
                fructe[p].setPret(pret);
                Console.WriteLine("Pretul  a fost updatat");
                return true;
            }
            Console.WriteLine("Produsul nu a fost gasit");
            return false;

        }

     

 

        public double UpdatePret(string nume, int pret)
        {
            double pretNou = 0;
            int p = pozitieFruct(nume);

            if (p != -1)
            {
                fructe[p].setPret(pret);
                pretNou = pret;
            }
            return pretNou;

        }

     
        public bool Delete(string fruct)
        {

            int p = pozitieFruct(fruct);
            if (p != -1)
            {
                Console.WriteLine("Item " + fructe[p].getNume() + " deleted!");
                this.fructe.RemoveAt(p);

                return true;

            }
            Console.WriteLine("Not deleted");
            return false;

        }

        public void readFileTxt()
        {

            StreamReader read = new StreamReader(@"../../../Fruits.txt");

            String line = "";
            line = read.ReadLine();

            while (line != "")
            {


                String[] proprietati = line.Split(",");//imparte linia la ,
                //asociere parametrii cu pozitia in fisier

                String nume = proprietati[0];

                double greutate = double.Parse(proprietati[1]);

                bool isComestibil = Boolean.Parse(proprietati[2]);

                int pret = int.Parse(proprietati[3]);

                

                //declarare obiect de tip masina.
                //Initializare
                Fruct fruct = new Fruct(nume, greutate, isComestibil, pret);
                fructe.Add(fruct);
                line = read.ReadLine();
            }
            read.Close();
        }


        public string toStringAllObjectsFromFile()
        {
            string tot = "";

            for (int i = 0; i < fructe.Count; i++)
            {
                tot += fructe[i].takeFruitPropertiesFromClassAndConvertToString() + "\n";
             
            }


            return tot;
        }


        public void saveToFileTxt()
        {

            StreamWriter write = new StreamWriter(@"../../../Fruits.txt");


            write.WriteLine(this.toStringAllObjectsFromFile());


            write.Close();
        }

    }
}
