namespace TratamentoDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Exceção de divisão por zero
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error! " + e.Message);
            }            
        }   
    }
}
