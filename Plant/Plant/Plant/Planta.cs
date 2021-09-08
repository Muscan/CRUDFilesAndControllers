using System;
using System.Collections.Generic;
using System.Text;

namespace Plant
{
    class Planta
    {
        private bool IsGreen;
        private int id;
        private string nume;
        private double inaltime;

        public Planta(bool IsGreen, int id, string nume)
        {

            this.IsGreen = IsGreen;
            this.id = id;
            this.nume = nume;
        }

        public Planta(bool IsGreen, int id, string nume, double inaltime)
        {
            this.IsGreen = IsGreen;
            this.id = id;
            this.nume = nume;
            this.inaltime = inaltime;
        }

        public void setIsGreen(bool IsGreen)
        {
            this.IsGreen = IsGreen;
        }
        public bool getIsGreen()
        {
            return IsGreen;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setNume(string nume)
        {
            this.nume = nume;
        }

        public string getNume()
        {
            return nume;
        }

        public string descPlanta()
        {
            string plantaDetails = "";
            plantaDetails += "Nume planta: " + this.nume + "\n";
            plantaDetails += "Id planta: " + this.id + "\n";
            plantaDetails += "Is Green: " + this.IsGreen + "\n";
            plantaDetails += "Height: " + this.inaltime + "\n";
            return plantaDetails;
        }
        //public Planta(bool IsGreen, int id, string nume, double inaltime)
        public void printOneHouse()
        {
            Console.WriteLine(this.descPlanta());
        }

        public string TakePropertiesFromClassAndConvertToString()
        {
            return IsGreen + "," + id + "," + nume + "," + inaltime;
        }

    }

}
