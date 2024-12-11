namespace Combat_entre_cavallers;

public class Boxeador
{
    static Random random = new Random();
    private int golpe = random.Next(1, 4);
    private int noProtejo = random.Next(1, 4);
    List<int> golpeBoxeador = new();

    public string Nombre { get; set; }
    
    public int Vida { get; set; }

    public string nombreBoxeador;
    public int vidaBoxeador;
    public static List<string> Zonas = new List<string>() { "Cabeza", "BrazoIzquierdo", "BrazoDerecho", "Abdomen" };
    //private string ZonaProtegida;
    public Boxeador(string nombreBoxeador, int vidaBoxeador)
    {
        Nombre = nombreBoxeador;
        Vida = vidaBoxeador;
    }

    public int Golpear()
    {
        return random.Next(0, Zonas.Count);
    }

    public int Protegerse()
    {
        return random.Next(0, Zonas.Count);
    }

    public bool KO()
    {
        bool estoyKo = false;
        if (Vida == 0){}
        
        Console.WriteLine("Estoy KO");
        return estoyKo = false;
    }
}