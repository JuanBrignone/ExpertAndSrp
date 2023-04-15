
using System;
using System.Text;

namespace Library
{

    public class Doctor
    {
        public string nombre {get; set;}

        public string especialidad {get; set;}


        public Doctor (String nombre, String especialidad)
        {
           Console.WriteLine("Se esta creando un Doctor");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El nombre no es valido");
                isValid = false;
            }
            if(string.IsNullOrEmpty(especialidad))
            {
                Console.WriteLine("La especialidad no es valida");
                isValid = false;
            }

            if (isValid){
                this.nombre = nombre;
                this.especialidad = especialidad;
                Console.WriteLine("El doctor se creo correctamente");
            }
               
        }



    }







}
