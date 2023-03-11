// See https://aka.ms/new-console-template for more information

Console.WriteLine("a. Sumatoria");
Console.WriteLine("b. tablas de multiplicar");

char opcion = Convert.ToChar(Console.ReadLine());

switch (opcion)
{
    case 'a':
        Console.WriteLine("Ingrese un número; ");
        int n = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;

        do
        {
            resultado = resultado + n;
            n--;
        } while (n > 0);

        Console.WriteLine("Sumatoria" + resultado);
        break;
    case 'b':
        for (int i =1; i < 11; i++)
        {
            Console.WriteLine(i + ": ");
            for (int j = 1; j < 11; i++)
            {
                Console.WriteLine(i * j + "\t");
            }
            Console.Write("\n");
        }
        break;
}
