using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;

namespace Polimorfismo
{
    /// <summary>
    /// Ejecución del programa, nos crearemos un menú para que sea más facil
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Introducción por consola
            Console.WriteLine("*****************.:. EJERCICIO DE POLIMORFISMO .:.***************");
            Console.WriteLine("\n*\t\t---- PROFESOR - ÁLVARO LÓPEZ JURADO ----\t*");
            Console.WriteLine("*\t\t---- AUTOR - LAURA LUCENA BUENDÍA ----\t\t*");
            pulsarParaSeguir("PULSE PARA INICIAR");

            //Variable que nos ayudará con un menú que hemos creado en el programa
            Boolean menuActivo = true;

            //Bucle para la ejecución del programa
            //No se detendrá hasta que no pulsemos la tecla correspondiente
            do
            {
                Console.WriteLine("------------------------------------" +
                    "\n[0]- Salir" +
                    "\n[1]- Ejecución Programa" +
                    "\n------------------------------------");

                try
                {
                    Console.Write("Seleccione una de las opciones: ");
                    int opcionMenu = Convert.ToInt32(Console.ReadLine());

                    switch (opcionMenu)
                    {
                        // Salir del programa
                        case 0:
                            menuActivo = false;
                            Console.WriteLine("-- Hasta Pronto --");
                            break;

                    //Ejecución del programa principal
                        case 1:
                            Console.Clear();
                            //0. Instrucciones
                            //1. Pide por teclado el nombre, la edad, sexo, peso y altura:
                            Console.WriteLine("-------.:. PRIMERAS INSTANCIAS .:.-------");
                            Console.Write("Inserte el nombre: ");
                            String nombre = Console.ReadLine();

                            Console.Write("Inserte el edad: ");
                            int edad = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Inserte el sexo ('M'/'H'): ");
                            char sexo = Console.ReadLine().ToUpper()[0];

                            Console.Write("Inserte el peso: ");
                            Double peso = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Inserte el altura: ");
                            Double altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                            //2. Crea 3 objetos de la clase anterior
                            //el primer objeto obtendrá las anteriores variables pedidas por teclado (nombre, la edad, sexo, peso y altura)
                            Puesto_Trabajo puesto1 = new Puesto_Trabajo(nombre, edad, sexo, peso, altura);

                            //3. El segundo objeto obtendrá todos los anteriores menos el peso y la altura
                            Puesto_Trabajo puesto2 = new Puesto_Trabajo(peso, altura);

                            //Limpiamos la consola para que se vea más claro
                            pulsarParaSeguir("PULSA 'INTRO' PARA CREAR AL SIGUIENTE");

                            //4. El último por defecto (para este último utiliza los métodos set para darle a los atributos un valor)
                            Console.WriteLine("-------.:. ULTIMA INSTANCIA .:.-------");
                            Puesto_Trabajo puesto3 = new Puesto_Trabajo();
                            Console.Write("Inserte el nombre: ");
                            puesto3.NOMBRE = Console.ReadLine();

                            Console.Write("Inserte la edad: ");
                            puesto3.EDAD = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Inserte el sexo ('M'/'H'): ");
                            char sex = Console.ReadLine()[0];
                            puesto3.SEXO = Persona.comprobarSexo(sex);

                            Console.Write("Inserte el peso: ");
                            puesto3.PESO = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Inserte la altura: ");
                            puesto3.ALTURA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Inserte el puesto de trabajo: ");
                            puesto3.PUESTO = Console.ReadLine();

                            Console.Write("Inserte el nombre de la empresa: ");
                            puesto3.EMPRESA = Console.ReadLine();

                            Console.Write("Inserte el sueldo en bruto: ");
                            puesto3.SUELDO = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Clear(); // Limpiamos consola
                            //Mostramos todos los datos
                            //5.  Para cada objeto, deberá comprobar si esta en su peso ideal, tiene sobrepeso o por debajo de su peso ideal con un mensaje.
                            Console.WriteLine("\n\n************************* DATOS DE LOS EMPLEADOS *************************");
                            Console.WriteLine("************************* PESO IDEAL *************************");
                            Console.Write("\nPrimera Persona: ");
                            comprobarIMC(puesto1.calcularIMC());

                            Console.Write("\nSegunda Persona: ");
                            comprobarIMC(puesto2.calcularIMC());

                            Console.Write("\nTercera Persona: ");
                            comprobarIMC(puesto3.calcularIMC());

                            //6. Indicar para cada objeto si es mayor de edad.
                            Console.WriteLine("\n************************* MAYOR DE EDAD *************************");
                            Console.Write("\nPrimera Persona: ");
                            comprobarEdad(puesto1.esMayor_de_Edad());

                            Console.Write("\nSegunda Persona: ");
                            comprobarEdad(puesto2.esMayor_de_Edad());

                            Console.Write("\nTercera Persona: ");
                            comprobarEdad(puesto3.esMayor_de_Edad());

                            //7. Mostrar la información de cada objeto.
                            Console.WriteLine("\n************************* MOSTRAR INFORMACIÓN *************************");
                            Console.WriteLine("\n[1]Empleado \n" + puesto1.mostrarInformacion());
                            Console.WriteLine("\n[2]Empleado \n" + puesto2.mostrarInformacion());
                            Console.WriteLine("\n[3]Empleado \n" + puesto3.mostrarInformacion());

                            //8. Mostrar la nomina de los 3 objetos creado anteriormente
                            Console.WriteLine("\n************************* MOSTRAR NÓMINA *************************");
                            Console.WriteLine("\n[1]Empleado \n" + puesto1.mostrarNomina());
                            Console.WriteLine("\n[2]Empleado \n" + puesto2.mostrarNomina());
                            Console.WriteLine("\n[3]Empleado \n" + puesto3.mostrarNomina());

                            pulsarParaSeguir("PULSE 'INTRO' PARA VOLVER AL MENU");
                            break;

                        default:
                            Console.WriteLine("¡¡¡¡Escriba una opción válida!!!!");
                            pulsarParaSeguir("PULSE 'INTRO' PARA VOLVER AL MENU");
                            break;
                    }//Fin Switch
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("¡DEBE INSERTAR UN NÚMERO CORRECTO!");
                }
                

            } while (menuActivo);

            Console.ReadLine();
            
        }// Fin MAIN



        //----------------------------
        // MÉTODOS
        //----------------------------
        
        /// <summary>
        /// Método que nos imprime el resultado de si el 'Trabajador' es o no mayor de edad
        /// </summary>
        /// <param name="mayor"></param>
        private static void comprobarEdad(bool mayor)
        {
            if (mayor)
                Console.WriteLine("Es mayor de edad");
            else
                Console.WriteLine("Es menor de edad");
        }

        /// <summary>
        /// Método que nos dice si el 'Trabajador' tiene un Índice de Masa Corporal apto
        /// </summary>
        /// <param name="imc"></param>
        private static void comprobarIMC(int imc)
        {
            if (imc == -1)
                Console.WriteLine("Está por debajo del peso recomendado");
            else if (imc == 0)
                Console.WriteLine("Está en su peso recomendado");
            else if(imc == 1)
                Console.WriteLine("Tiene sobrepeso");
            else
                Console.WriteLine("Variables incorrectas, no se pudo calcular correctamente su IMC");
        }

        /// <summary>
        /// Método auxiliar que nos ayudará a tener más fluidez en el menu principal
        /// </summary>
        /// <param name="msj"></param>
        private static void pulsarParaSeguir(String msj)
        {
            Console.WriteLine("\n\n\n -------------------.:. {0} .:.--------------------", msj);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
