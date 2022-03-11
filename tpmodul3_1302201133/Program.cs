using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kelurahan = new KodePos(Kelurahan.Kebonwaru);
            Console.WriteLine($"Nama Kelurahan\t\t: {kelurahan.kelurahan}");
            Console.WriteLine($"Kode Pos Kelurahan\t: {kelurahan.getKodePos()}");

            var doorMachine = new DoorMachine();
            doorMachine.printStatus();
            doorMachine.setState(State.Terbuka);
            doorMachine.printStatus();
        }
    }
}