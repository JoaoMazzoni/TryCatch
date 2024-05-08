internal class Program
{
    private static void Main(string[] args)
    {
        int valor = 0;
        Console.WriteLine("Informe um valor inteiro: ");
        try
        {
            valor = int.Parse(Console.ReadLine());
        }
        catch(Exception e) 
        {
            Console.WriteLine("Informe um número no formato de algarismo numérico (1, 2, 3..):  ");
            Console.WriteLine("Mensagem retornada a exceção: " + e.ToString());
            Console.WriteLine("\n\nDados da exceção: " + e.Source.GetType);
        }
        finally //Finally é executado independente se deu erro ou não (comando opcional)
        {
            Console.WriteLine("\nExecução encerrada!");
        }

        Console.WriteLine($"O valor obtido foi: {valor}");
    }
}