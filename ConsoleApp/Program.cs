Console.WriteLine("Hello, World!");

var baile = new Bailes();

baile.Id = 1;
baile.Nombre = "Hip Hop";
baile.Activo = true;
baile.Tipo = new Tipos() { Id = 1, Nombre = "Danza urbana" };
baile.Salon = new Salones() { Id = 1, NumeroSalon = "403" };
baile.Bailarines = new List<Bailarines>();
baile.Bailarines.Add(new Bailarines() { Id = 1, Nombre = "Jose Miguel" });
baile.Bailarines.Add(new Bailarines() { Id = 2, Nombre = "Amanda" });

Console.WriteLine("Id del baile " + baile.Id);
Console.WriteLine("Nombre del baile " + baile.Nombre);
Console.WriteLine("Tipo del baile " + baile.Tipo.Nombre);

foreach (var elemento in baile.Bailarines)
{
    Console.WriteLine("Bailarin " + elemento.Nombre);
}

public class Bailarines
{
    public int Id = 0;
    public String? Nombre = "";

}

public class Salones
{
    public int Id = 0;
    public String? NumeroSalon = "";
    public List<Bailes> Bailes = new List<Bailes>();
}

public class Tipos
{
    public int Id = 0;
    public String? Nombre = "";

    public List<Bailes> Bailes = new List<Bailes>();
}

public class Bailes
{
    public int Id = 0;
    public String? Nombre = "";
    public bool Activo = false;
    public Tipos Tipo = new Tipos();
    public Salones Salon = new Salones();
    public List<Bailarines> Bailarines = new List<Bailarines>();
}
