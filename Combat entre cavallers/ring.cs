namespace Combat_entre_cavallers;

public class Ring
{
    public void RealizarTurno(Boxeador atacante, Boxeador defensor)
    {
        int zonaGolpe = atacante.Golpear();
        int zonaProtegida = defensor.Protegerse();

        string zonaGolpeada = Boxeador.Zonas[zonaGolpe];
        string zonaProtegidaNombre = Boxeador.Zonas[zonaProtegida];

        Console.WriteLine($"{atacante.Nombre} golpea a {zonaGolpeada}");

        if (zonaGolpe == zonaProtegida)
        {
            Console.WriteLine($"{defensor.Nombre} se ha protegido");
        }
        else
        {
            defensor.Vida--;
            if (defensor.Vida > 1)
            {
                Console.WriteLine($"A {defensor.Nombre} le quedan {defensor.Vida} vidas");
            }
            else
            {
                Console.WriteLine($"A {defensor.Nombre} le quedan {defensor.Vida} vida");    
            }
            
        }
    }
}