namespace calculadoratectlaxiaco
{
    public class Operaciones
    {
        public static double sumar(double uno, double dos)
        {
            return uno + dos;
        }

        public static double multiplicar(double uno, double dos)
        {
            return uno * dos;
        }

        public static double restar(double uno, double dos)
        {
            return uno - dos;
        }

        public static double dividir(double uno, double dos)
        {
            if (dos == 0)
            {
                Console.WriteLine("Error: División entre cero.");
                return 0;
            }
            return uno / dos;
        }

        public static double raizCuadrada(double numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                return 0;
            }
            return Math.Sqrt(numero);
        }

        public static double potencia(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente);
        }

        public static double porcentaje(double total, double porcentaje)
        {
            return (total * porcentaje) / 100;
        }

        public static double fraccion(double numero)
        {
            if (numero == 0)
            {
                Console.WriteLine("Error: No se puede calcular la fracción de cero.");
                return 0;
            }
            return 1 / numero;
        }
    }
}
