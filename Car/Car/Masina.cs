using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulare3
{
    class Masina
    {



        private string marca;
        private int pret;
        private double motor;
        private string culoare;
        private int anFabricatie;
        private string tractiune;

        public Masina()
        {
        }


        public Masina(string marca, int pret, double motor, string culoare, int anFabricatie, string tractiune)
        {


            this.marca = marca;
            this.pret = pret;
            this.motor = motor;
            this.culoare = culoare;
            this.anFabricatie = anFabricatie;
            this.tractiune = tractiune;

        }

        public void setMarca(string marca)
        {

            this.marca = marca;

        }


        public string getMarca()
        {

            return this.marca;
        }

        public void setPret(int pret)
        {
            this.pret = pret;

        }
        public int getPret()
        {
            return this.pret;
        }


        public void setMotor(double motor)
        {
            this.motor = motor;

        }

        public double getMotor()
        {
            return this.motor;

        }

        public void setCuloare(string culoare)
        {
            this.culoare = culoare;

        }
        public string getCuloare()
        {
            return this.culoare;
        }

        public void setAnFabricatie(int anFabricatie)
        {
            this.anFabricatie = anFabricatie;
        }
        public int getAnFabricatie()
        {
            return anFabricatie;
        }

        public void setTractiune(string tractiune)
        {
            this.tractiune = tractiune;
        }

        public string getTractiune()
        {
            return tractiune;
        }

        public string descriereMasina()
        {
            string descriereMasina = "";

            descriereMasina += "Marca :" + this.marca + "\n";
            descriereMasina += "Pret: " + this.pret + "\n";
            descriereMasina += "Motor: " + this.motor + "\n";
            descriereMasina += "Culoare: " + this.culoare + "\n";
            descriereMasina += "An fabricatie: " + this.anFabricatie + "\n";
            descriereMasina += "Tractiune: " + this.tractiune + "\n";

            return descriereMasina;

        }

        public void afisareOneCar()
        {
            Console.WriteLine(this.descriereMasina());
        }

        public String takeCarPropertiesFromClassAndConvertToString()
        {
            return marca + "," + pret + "," + motor + "," + culoare + "," + anFabricatie + "," + tractiune;

        }

        //TBD
        /*Add relative path(curs plus tema)
         Recap apelare obiecte in main(Add, stergere)
        Adaugare CRUD peste obiectele din proiect*/




    }
}
