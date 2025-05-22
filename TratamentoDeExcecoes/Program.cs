using TratamentoDeExcecoes.Entities;

namespace TratamentoDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Reservation: ");

            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

              

        }
    }
}