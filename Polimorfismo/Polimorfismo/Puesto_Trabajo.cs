using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    /// <summary>
    /// Clase que heredará de 'Persona'
    /// </summary>
    class Puesto_Trabajo : Persona
    {
        //Atributos
        private String puesto;
        private String empresa;
        private Double sueldo;



        //Constructores
        public Puesto_Trabajo(): base(){}

        public Puesto_Trabajo(Double peso, Double altura) : base(peso, altura) { }

        public Puesto_Trabajo(string nombre, int edad, char sexo, double peso, double altura) : base(nombre, edad, sexo, peso, altura){}

        public Puesto_Trabajo(string nombre, int edad, string dni, char sexo, double peso, double altura, 
            String puesto, String empresa, Double sueldo) : base(nombre, edad, sexo, peso, altura) {
            this.puesto = puesto;
            this.empresa = empresa;
            this.sueldo = sueldo;
        }

        //Modificadores de Acceso
        public string PUESTO { get => puesto; set => puesto = value; }
        public string EMPRESA { get => empresa; set => empresa = value; }
        public double SUELDO { get => sueldo; set => sueldo = value; }


        //---------------
        //  MÉTODOS
        //---------------

        /// <summary>
        /// Calculamos su sueldo menos el 15% de IRPF
        /// </summary>
        /// <returns></returns>
        public Double calculoIRPF()
        {
            return this.sueldo - ((this.sueldo * 15) / 100);
        }


        /// <summary>
        /// Si es mujer se le añade un 5% de igualdad de genero
        /// </summary>
        /// <returns></returns>
        public Double calculoNomina()
        {
            if (this.SEXO == 'm' || this.SEXO == 'M')
                return this.sueldo + ((this.sueldo * 5) / 100);
            else
                return 0.00;
        }


        /// <summary>
        /// Método que nos mostrará el: Sueldo bruto, descuentos, incetivo, sueldo Neto
        /// </summary>
        public String mostrarNomina()
        {
            String data = "";
            data += "Empleado " + this.NOMBRE;
            data += "\nSueldo Bruto: " + this.sueldo;
            data += "\nDescuentos: 15% IRPF";
            data += "\nIncentivo: " + calculoNomina();
            data += "\nSueldo Neto: " + calculoIRPF();

            return data;
        }
    }
}
