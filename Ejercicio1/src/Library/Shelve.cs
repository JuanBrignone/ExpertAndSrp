using System;
using System.Collections;
namespace SRP
{

    public class Shelve 
    {
        public string nombreShelve{get;}

        public Shelve(string nombre)
        {
            this.nombreShelve = nombre;
        }
         ArrayList Libros = new ArrayList();

        public void agregarlibro(Book libro)
        {
            this.Libros.Add(libro);
        }

        public void removerlibro(Book libro)
        {   
            this.Libros.Remove(libro);
        }

        public override string ToString()
        {
            string texto = "";
            for (int i = 0; i < Libros.Count;i++)
            
            {
              texto += $"\n{Libros[i].ToString()}";
            
            }
            return $"Estenteria: {this.nombreShelve} contiene {texto} ";
        }
        
    }







}