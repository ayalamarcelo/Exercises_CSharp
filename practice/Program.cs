using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Program;
class Program
{
    /*static void Ejercicio1()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int index = -1;

        Console.WriteLine("Ingrese un número");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.WriteLine($"La posición del numero {number} es {index}");
        }
        else
        {
            Console.WriteLine($"No se ha encontrado el valor dentro del array");
        }
    }*/

    /*static void Ejercicio2()
    {
        // Buscar una cadena en un arreglo de cadenas, la cadena banana
        string[] cadenas = { "manzana", "naranja", "platano", "banana", "uva", "pera" };
        Console.WriteLine("Ingrese la cadena a buscar: ");
        string cadena = Console.ReadLine();
        int index = -1;

        for(int i = 0; i < cadenas.Length; i++){
            if(cadenas[i] == cadena){
                index = i;
                break;
            }
        }

        if(index != -1) {
            Console.WriteLine($"{cadena} está en la posición {index}");
        } else {
            Console.WriteLine("No encontrado");
        }
         
    }*/

    /*public static void Ejercicio3(){
        
        int[] arrayNumeros = { 8, 6, 1, 9, 4 };
        int numero = 6;
        int indice = -1;

        for(int i = 0; i < arrayNumeros.Length; i++){
            if(arrayNumeros[i] == numero){
                indice = i;
                break;
            }
        }

        if(indice != -1){
            Console.WriteLine($"El número {numero} existe en el array en la posición {indice}");
        } else {
            Console.WriteLine("El número {numero} no existe en el array");
        }
    }*/

    /*public static void Ejercicio4(){
        // Búsqueda de arreglos con valores duplicados
        int[] arregloDuplicado = { 4, 2, 7, 4, 9, 4 };
        Console.WriteLine("Ingrese un valor a buscar: ");
        int numeroDuplicado = Convert.ToInt32(Console.ReadLine());
        int indice = -1;

        for(int i = 0; i < arregloDuplicado.Length; i++){
            if(arregloDuplicado[i] == numeroDuplicado){
                indice = i;
                break;
            }
        }

        if(indice != -1){
            Console.WriteLine($"El numero {numeroDuplicado} está en la posición {indice}");
        } else {
            Console.WriteLine($"El número {numeroDuplicado} no fue encontrado");
        }

    }*/

    /*public static void Ejercicio5(){
        // Encontrar el valor mínimo
        int[] arrayValorMinimo = { 12, 5, 19, 3, 9 };
        int valorMinimo = arrayValorMinimo[0];
        int indice = -1;

        for(int i = 0; i < arrayValorMinimo.Length; i++){
            if(arrayValorMinimo[i] < valorMinimo){
                valorMinimo = arrayValorMinimo[i];
                indice = i;
            }
        }

        if(indice != -1){
            Console.WriteLine($"El valor mínimo es {valorMinimo} y se encuentra en la posición {indice}");
        } else {
            Console.WriteLine("El valor es incorrecto");
        }
    }*/

    /*public static void Ejercicio6(){
        // Hallar el valor Maximo de un array

        int[] arrayValorMaximo = { 23, 44, 65, 120, 32, 1000 };
        int valorMaximo = arrayValorMaximo[0];
        int indice = -1;

        for(int i = 0; i < arrayValorMaximo.Length; i++){
            if(arrayValorMaximo[i] > valorMaximo){
                valorMaximo = arrayValorMaximo[i];
                indice = i;
            }
        }

        if(indice != -1){
            Console.WriteLine($"El valor maximo del array es {valorMaximo} en la posición {indice}");
        }
    }*/

    /*public static void BusquedaBinaria()
    {
        int[] arrayOrdenado = { 1, 2, 3, 4, 5, 6 };
        int menorValorArray = 0;
        int mayorValorArray = arrayOrdenado.Length - 1;
        int indice = -1;
        int valor = 4;

        while (menorValorArray <= mayorValorArray)
        {
            int puntoMedio = menorValorArray + (mayorValorArray - menorValorArray) / 2;

            if (arrayOrdenado[puntoMedio] == valor)
            {
                indice = puntoMedio;
                break;
            }

            if (arrayOrdenado[puntoMedio] < valor)
            {
                menorValorArray = puntoMedio + 1;
            }
            else
            {
                mayorValorArray = puntoMedio - 1;
            }
        }


        if (indice != -1)
        {
            Console.WriteLine($"El valor {valor} se encuentra en la posición {indice}.");
        }
        else
        {
            Console.WriteLine($"El valor {valor} no fue encontrado.");
        }
    }*/

    /*public static void Ejercicio7(){
        int[] arrayDeEnteros = { 20, 35, 40, 57, 60, 90 };
        Console.WriteLine("Ingrese un valor a buscar dentro del array");
        int valor = Convert.ToInt32(Console.ReadLine());
        int low = 0;
        int high = arrayDeEnteros.Length -1;
        int index = -1;

        while(low <= high){
            int mid = low + (high - low) / 2;

            if(arrayDeEnteros[mid] == valor){
                index = mid;
                break;
            }
            if(arrayDeEnteros[mid] < valor) {
                low = mid + 1;
            } else {
                high = mid -1;
            }
        }

        if(index != -1){
            Console.WriteLine($"El valor {valor} está en el índice {index}");
        } else {
            Console.WriteLine("El valor no se encuentra dentro del array");
        }
    }*/

    /*public static void Ejercicio8()
    {
        string[] cadenas = { "Alexis", "Carlos", "Daniela", "Erica" };
        Console.WriteLine("Ingrese el nombre a buscar");
        string nombreABuscar = Console.ReadLine();

        int bajo = 0;
        int alto = cadenas.Length - 1;
        int index = -1;

        while (bajo <= alto)
        {
            int medio = bajo + (alto - bajo) / 2;

            if (cadenas[medio] == nombreABuscar)
            {
                index = medio;
                break;
            }

            if (nombreABuscar.CompareTo(cadenas[medio]) < 0)
            {
                alto = medio - 1;
            }

            if (nombreABuscar.CompareTo(cadenas[medio]) > 0)
            {
                bajo = medio + 1;
            }
        }

        if(index != -1){
            Console.WriteLine($"El nombre {nombreABuscar} está en la posición {index} del array");
        } else {
            Console.WriteLine("No existe ese valor de cadena en el array");
        }
    }*/

    /*public static int[] Ejercicio9(int[] array){
        int aux;
        int j;
        for(int i = 0; i < array.Length; i++){
            aux = array[i];
            j = i - 1;
            while(j >= 0 && array[j] > aux){
                array[j + 1]  = array[j];
                j--;
            }
            array[j + 1] = aux;
        }
        return array;
    }

    public static void MostrarEjercicio(){
        int[] array = { 34, 2, 1, 5, 1 };
        
        int[] arregloOrdenado = Ejercicio9(array);
        
        Console.WriteLine(string.Join(",", arregloOrdenado));
    }*/

    public static void Main(string[] args)
    {
        
    }
}