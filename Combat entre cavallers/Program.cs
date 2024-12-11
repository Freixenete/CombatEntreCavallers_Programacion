namespace Combat_entre_cavallers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nombre del contrincante 1:");
        string nombre1 = Console.ReadLine();
        Console.WriteLine("Cuanta vida tiene el competidor 1:");
        int vida1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Nombre del contrincante 2:");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("Cuanta vida tiene el competidor 2:");
        int vida2 = int.Parse(Console.ReadLine());

        
        Boxeador boxeador1 = new Boxeador(nombre1, vida1);
        Boxeador boxeador2 = new Boxeador(nombre2, vida2);

        
        Ring ring = new Ring();

        while (boxeador1.Vida > 0 && boxeador2.Vida > 0)
        {
            ring.RealizarTurno(boxeador1, boxeador2);
            ring.RealizarTurno(boxeador2, boxeador1);
        }

        if (boxeador1.Vida > 0)
        {
            Console.WriteLine($"{boxeador1.Nombre} gana el combate!");
        }
        else
        {
            Console.WriteLine($"{boxeador2.Nombre} gana el combate!");
        }
    }
}