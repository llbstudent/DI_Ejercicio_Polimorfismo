using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    /// <summary>
    /// Clase Persona de la que heredará la Clase 'Puesto_de_Trabajo'
    /// </summary>
    class Persona
    {
        //Constantes
        private String NOMBRE_DEFECTO = "";
        private int EDAD_DEFECTO = 0;
        private char SEXO_DEFECTO = 'H';
        private Double PESO_DEFECTO = 0.00;
        private Double ALTURA_DEFECTO = 0.00;

        //Atributos
        protected String nombre;
        protected int edad;
        protected String dni;
        protected char sexo;
        protected Double peso;
        protected Double altura;




        //Constructores
        //Por Defecto
        public Persona() {
            this.dni = generarDNI();
            this.nombre = NOMBRE_DEFECTO;
            this.edad = EDAD_DEFECTO;
            this.sexo = SEXO_DEFECTO;
            this.peso = PESO_DEFECTO;
            this.altura = ALTURA_DEFECTO;
        }

        //Nombre, Edad y Sexo
        public Persona(string nombre, int edad, char sexo) {
            this.dni = generarDNI();
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = PESO_DEFECTO;
            this.altura = ALTURA_DEFECTO;
        }

        //Todos los atributos
        public Persona(string nombre, int edad, char sexo, Double peso, Double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = generarDNI();
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        /// <summary>
        /// Este cosntructor nos lo ha generado automáticamente VisualStudio al instanciar en 'Program'
        /// Una clase hija 'Puesto_Trabajo' cone stos 2 atributos
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        public Persona(double peso, double altura)
        {
            this.nombre = NOMBRE_DEFECTO;
            this.edad = EDAD_DEFECTO;
            this.dni = generarDNI();
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }


        //Modificadores de Acceso
        public string NOMBRE { get => nombre; set => nombre = value; }
        public int EDAD { get => edad; set => edad = value; }
        
        public String DNI { get => dni; } //Sin set
        public char SEXO { get => sexo; set => sexo = value; }
        public double PESO { get => peso; set => peso = value; }
        public double ALTURA { get => altura; set => altura = value; }


        //----------------------
        //  MÉTODOS
        //----------------------

        /// <summary>
        /// calculara si la persona esta en su peso ideal.
        /// Si el método nos devuelve un valor menor que 20, la función devuelve un -1.
        /// Si devuelve un número entre 20 y 25, significa que esta por debajo de su peso ideal la función devuelve un 0
        /// Si devuelve un valor mayor que 25 significa que tiene sobrepeso, la función devuelve un 1
        /// </summary>
        /// <returns></returns>
        public int calcularIMC()
        {
            int resultado = 0;
            //Formula
            Double imc = (this.peso/(Math.Pow(this.altura, 2)));


            if(imc < 20)
            {
                resultado = -1;
            
            }else if (imc >= 20 && imc <= 25)
            {
                resultado = 0;
            
            }else if (imc > 25)
            {
                resultado = 1;
            }

            return resultado;

        }



        /// <summary>
        /// Nos comprueba la edad de la persona y dice si es o no mayor de edad.
        /// Si es mayor devolverá -true
        /// Sino devolverá - false
        /// </summary>
        /// <returns></returns>
        public Boolean esMayor_de_Edad()
        {
            Boolean mayorDeEdad = true;

            if (this.edad < 18)
                mayorDeEdad = false;

            return mayorDeEdad;

        }


        /// <summary>
        /// Noz comprueba que el sexo introducido es correcto. 
        /// Si no es correcto, sera H. No sera visible al exterior.
        /// Lo utilizaremos a la hora de instanciar/crear nuestros objetos de tipo 'Personas'
        /// </summary>
        /// <param name="sexo"></param>
        /// <returns></returns>
        public static char comprobarSexo(char sexo)
        {
            if (!(sexo == 'h' || sexo == 'H') || !(sexo == 'm' || sexo == 'M'))
               sexo = 'H';

            return sexo;
        }


        
        /// <summary>
        /// Nos devuelve toda la información de la instancia 'Persona'
        /// </summary>
        /// <returns></returns>
        public String mostrarInformacion()
        {
            String datos =  this.nombre + ", Edad: " +this.edad+ ", Sexo: \'" +this.sexo+ "\' DNI: " +this.dni + 
                "\n-Peso: " +this.peso+ ", Altura: " +this.altura;
            return datos;
        }


        /// <summary>
        /// Nos genera un número aleatorio de 8 cifras y una letra. 
        /// Este método sera invocado cuando se construya el objeto.
        /// </summary>
        /// <returns></returns>
        private String generarDNI()
        {
            String dni = "";
            //Primero nos creamos un número aleatorio de '8' cifras que comprenda del '11111111' al '99999999'
            Random rnd = new Random();
            int num = rnd.Next(11111111, 99999999);
            dni += num;
            
            //Ahora le añadimos una letra al 'dni'
            dni += (char)rnd.Next('A', 'Z');

            //Lo devolvemos
            return dni;
        }

    }
}
