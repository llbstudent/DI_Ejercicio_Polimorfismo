# DI_Ejercicio_Polimorfismo
Ejercicio con el practicaremos el polimorfismo
__________
AUTHOR LAURA LUCENA BUENDIA

PROFESSOR ALVARO LÓPEZ JURADO
__________
CLASE PERSONA

Haz una clase llamada Persona que siga las siguientes condiciones:
__________
•  Sus atributos son: 

  -nombre
  
  -edad
  
  -DNI
  
  -sexo (H hombre, M mujer)
  
  -peso
  
  -altura. 
  
  No queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el más adecuado, también su tipo. 
  Si quieres añadir algún atributo puedes hacerlo.
  
  Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). 
Sexo sera hombre por defecto, usa una constante para ello.

____________
CONSTRUCTORES
____________
Se implantaran varios constructores:

• 	Un constructor por defecto.

• 	Un constructor con el nombre, edad y sexo, el resto por defecto.

• 	Un constructor con todos los atributos como parámetro.

____________
MÉTODOS

Los métodos que se implementaran son:
____________

•  calcularIMC(): calculara si la persona esta en su peso ideal (peso en kg/(altura^2  en m)), 
si esta fórmula devuelve un valor menor que 20, la función devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), 
significa que esta por debajo de su peso ideal la función devuelve un 0  y si devuelve un valor mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. 

•  esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.

•  comprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Si no es correcto, sera H. No sera visible al exterior.

•  mostrarInformacion(): devuelve toda la información del objeto.

•  generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de este su número su letra correspondiente. Este método sera invocado cuando se construya el objeto. Puedes dividir el método para que te sea más fácil. No será visible al exterior.

•  Métodos set de cada parámetro, excepto de DNI.

__________________
CLASE PUESTO_DE_TRABAJO
__________________
Crear otra clase que sea puesto de trabajo, hija de la clase persona, donde añadiremos los siguientes atributos:

- Puesto de trabajo

- Empresa

- Sueldo


____________
MÉTODOS
____________

-calculoIRPF (su sueldo menos el 15% de IRPF)

-calculo nomina (Si es mujer se le añade un 5% de igualdad de genero)

-mostrarNomina ( Debe de aparece Sueldo bruto, descuentos, incetivo, sueldo Neto)
____________
contructor con parametros de los tres atributos
____________


MÉTODO PRINCIPAL
________________________
Ahora, el main hará lo siguiente:

•  Pide por teclado el nombre, la edad, sexo, peso y altura.

• Crea 3 objetos de la clase anterior, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza los métodos set para darle a los atributos un valor.

• Para cada objeto, deberá comprobar si esta en su peso ideal, tiene sobrepeso o por debajo de su peso ideal con un mensaje.

• Indicar para cada objeto si es mayor de edad.

• Por último, mostrar la información de cada objeto.

