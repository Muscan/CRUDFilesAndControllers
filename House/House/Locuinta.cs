using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Locuinta
    {
        private string material;
        private int mp;
        private string culoare;
        private double pret;

        public Locuinta(string material, int mp, string culoare, double pret)

        {
            this.material = material;
            this.mp = mp;
            this.culoare = culoare;
            this.pret = pret;
        }


        public Locuinta()
        {

        }




        public void setMaterial(string material)
        {
            this.material = material;

        }

        public string getMaterial()
        {
            return this.material;
        }

        public void setMp(int mp)
        {
            this.mp = mp;
        }

        public int getMp()
        {
            return this.mp;

        }

        public void setCuloare(string culoare)
        {
            this.culoare = culoare;
        }

        public string getCuloare()
        {
            return this.culoare;
        }

        public void setPret(double pret)
        {
            this.pret = pret;
        }

        public double getPret()
        {
            return this.pret;
        }

        public string DescriereLocuinta()
        {
            string descriereLocuinta = "";
            descriereLocuinta += "material: " + this.material + "\n";
            descriereLocuinta += "mp: " + this.mp + "\n";
            descriereLocuinta += "culoare: " + this.culoare + "\n";
            descriereLocuinta += "pret: " + this.pret + "\n";

            return descriereLocuinta;
        }

        public void printOneHouse()
        {
            Console.WriteLine(this.DescriereLocuinta());
        }

        public String takeHousePropertiesFromClassAndConvertToString()
        {
            //(string material, int mp, string culoare, double pret)
            return material + "," + mp + "," + culoare + "," + pret;

        }

    }
}
