using System;
using System.Collections;
namespace SRP
{
    public class Sector
    {
        public string nombreSector{get;}

        public Sector(string nombre)
        {
            this.nombreSector = nombre;
        }
        public ArrayList Shelves = new ArrayList();
        
        public void agregarshelve(Shelve shelve)
        {
            this.Shelves.Add(shelve);
        }
        public void eliminarshelve(Shelve shelve)
        {
            this.Shelves.Remove(shelve);
        }

        public override string ToString()
        {
            string texto = "";
            for (int i = 0 ; i < Shelves.Count; i ++)
            {
                texto += $"\n {Shelves[i].ToString()}";
            }
            return $"Sector: {this.nombreSector} contiene{texto}";
        }
    }




}