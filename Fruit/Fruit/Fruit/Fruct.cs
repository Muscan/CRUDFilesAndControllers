using System;
using System.Collections.Generic;
using System.Text;

namespace Fruit
{
    class Fruct
    {
        private string nume;
        private double greutate;
        private bool isComestibil;
        private int pret;
        private string tara;//il folosesc doar intr-un get si set tara

        public Fruct(string nume, double greutate, bool isComestibil, int pret)
        {
            this.nume = nume;
            this.greutate = greutate;
            this.isComestibil = isComestibil;
            this.pret = pret;
        }

        //constructor pentru pret si nume
        public Fruct(string nume, int pret)
        {
            this.nume = nume;
            this.pret = pret;
        }
        public Fruct() { }

        public void setNume(string paramNume)
        {
            this.nume = paramNume;

        }

        public string getNume()
        {
            return this.nume;
        }

        public void setGreutate(double greutate)
        {
            this.greutate = greutate;
        }

        public double getGreutate()
        {
            return this.greutate;
        }

        public void setIsComestibil(bool isComestibil)
        {
            this.isComestibil = isComestibil;
        }
        public bool getIsComestibil()
        {
            return this.isComestibil;
        }

        public void setPret(int pret)
        {
            this.pret = pret;
        }

        public int getPret()
        {
            return this.pret;
        }

        public void setTara(string tara)
        {
            this.tara = tara;
        }
        public string getTara()
        {
            return this.tara;
        }

        public string descriereFruct()
        {
            string propFruct = "";
            propFruct += "Nume fruct: " + this.nume + "\n";
            propFruct += "Greutate: " + this.greutate + "\n";
            propFruct += "Is comestibil: " + this.isComestibil + "\n";
            propFruct += "Pret: " + this.pret + "\n";
            return propFruct;
        }
        // public Fruct(string nume, double greutate, bool isComestibil, int pret)

        public void printOneElem()
        {
            Console.WriteLine(this.descriereFruct());
        }
        public String takeFruitPropertiesFromClassAndConvertToString()
        {


            return nume + "," + greutate + "," + isComestibil + "," + pret;

        }


    }
}
