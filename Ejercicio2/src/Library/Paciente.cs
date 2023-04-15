using System;
using System.Text;

namespace Library
{   
    public class Paciente 
    {
        public string nombre { get; set;}
        public string id {get; set;}
        public string edad {get;set;}


        

        public Paciente(String nombre, String id, String edad)
        {
            Console.WriteLine("Se esta creando un paciente");

            Boolean isValid = true;


            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El nombre no es valido");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("La id no es valida");
                isValid = false;
            }
            if(string.IsNullOrEmpty(edad)){
                Console.WriteLine("La edad no es valida");
                isValid = false;
            }



            if (isValid) {
            this.nombre = nombre;
            this.id = id;
            this.edad = edad;

            Console.WriteLine("El paciente se creo correctamente");
            }
            
        }
    }





}