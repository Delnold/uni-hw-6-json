// See https://aka.ms/new-console-template for more information
/*
var cities = new List<string>(10);
cities.Add ("New-York") ;
cities.Add ("London");
cities.Add ("Chicago");
cities.Add (null);
cities.Add ("Chicago");
cities.Add ("Neyagawa");
cities.ForEach (city => Console . WriteLine (city)) ;
Console.ReadKey();
*/

/*
var river =  new River(1, "Dnipro");
river.AddFish("Dorado") ;
river.AddFish("Salmon") ;
river.AddFish("Dorado") ;
Console.ReadKey();

class River
{
    public River(int id, string name)
    {
        Id = id;
        Name = name;
        Fish = new HashSet<string>();
    }
    public HashSet<string> Fish { get; private set; }
    public int Id { get; private set; }
    public string Name { get; private set; }
    public decimal Length { get; set; }

    public void AddFish(string fishName)
    {
        Console.WriteLine(
            Fish.Add(fishName)
                ? $"Add fish {fishName}"
                : $"Can't add fish {fishName} ");
    }
}
*/
/*
var cities = new List<string>(3);
cities.Add("New York");
cities.Add("London");
cities.Add("Chicago");
cities.Add("Chicago");
cities.Add ("Neyagawa");
var hashCities = new HashSet<string>(cities);
Console. WriteLine (hashCities.Count);
Console.ReadKey ();
*/

/*
var dnipro = new River(1, "Dnipro");
dnipro.AddFish("Dorado");
Console. WriteLine(dnipro.Id);
Console.ReadKey();

class River
{
    private List<string> _fish;

    public River(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public decimal Length { get; set; }

    public void AddFish(string fishName)
    {
        _fish.Add(fishName);
    }
}
*/
/*
var dictionary = new Dictionary<int, River>();
var dnipro = new River(1, "Dnipro");
dictionary [dnipro.Id] = dnipro;
Console.WriteLine (dictionary[2]);
Console.ReadKey();
*/

/*
var dictionary = new Dictionary<int, River>();
var dnipro = new River(1,"Dnipro");
dictionary[dnipro.Id] = dnipro;
Console.WriteLine (dictionary [1]);
Console.ReadKey();
*/
/*
var dictionary = new Dictionary<int, River>();
var dnipro = new River(1, "Dnipro");
dictionary.Add(dnipro.Id, dnipro);
dictionary [dnipro. Id] = dnipro;
Console.WriteLine(dictionary.Count);
Console.ReadKey ();
*/
/*
var dictionary = new Dictionary<int, River>();
var dnipro = new River(1, "Dnipro ");
dictionary [dnipro. Id] = dnipro;
dictionary. Add (dnipro.Id, dnipro);
Console.WriteLine(dictionary.Count) ;
Console.ReadKey ();
*/
/*
var river = new River(1, "Dnipro");
river.AddFish(" Dorado") ;
river.AddFish("Salmon") ;
river.AddFish(" Dorado") ;
river.WriteCountByFish( "Dorado") ;
river.WriteCountByFish("Salmon");
river.WriteCountByFish(" Snapper");
Console.ReadKey();
*/
/*
class River
{
    public River(int id, string name)
    {
        Id = id;
        Name = name;
        Fish = new HashSet<string>();
        _fishCount = new Dictionary<string, int>();
    }
    public HashSet<string> Fish { get; private set; }
    public int Id { get; private set; }
    public string Name {get; private set ; }
    public decimal Length { get; set; }
    private Dictionary<string, int> _fishCount;

    public void AddFish(string fileName)
    {
        if (Fish.Add(fileName))
        {
            _fishCount[fileName] = 1;
            return;
        }

        _fishCount[fileName] = _fishCount[fileName] + 1;
    }

    public void WriteCountByFish(string fishName)
    {
        var fishCount = _fishCount.TryGetValue(fishName, out int count) ? count : 0;
        Console.WriteLine($"{fishName} = {fishCount}");
    }
}
*/