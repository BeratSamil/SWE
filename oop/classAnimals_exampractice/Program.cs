namespace classAnimals_exampractice;

public class Animal
{
    private string name;
    private int cost;
    private string breed;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }
    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }
    public virtual int HowMuch()
    {
        return Cost;
    }
} //end of Animal class

    public class Species : Animal
    {
        public int WalkCost { get; set; }
        public Species(string breed, string name, int cost, int walkcost = 0)
        {
            Breed = breed;
            Name = name;
            Cost = cost;
            WalkCost = walkcost;
        }


        public override int HowMuch()
        {
            if (Breed == "Dog")
            {
                return Cost + WalkCost; // if its a dog, add walk cost
            }
            return Cost; // if not a dog, just return the cost
        }


    }



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Animals!");
        List<Species> animals=new List<Species>();
        animals.Add(new Species("Dog", "Eric", 500, 50));
        animals.Add(new Species("Cat", "Jimmy", 3000));
        animals.Add(new Species("Dog", "Ritchie", 700, 70));


        // --- print table header ---
        Console.WriteLine("---  Animal List ---");
        Console.WriteLine($"{"Name",-10} | {"Species",-5} | {"Cost",-6} | {"All price",-10}");
        Console.WriteLine(new string('-', 60));
        // print each animal info
        foreach (var item in animals)
        {
            // HowMuch() goes here
            // if (Cost+WalkCost), cat is (Cost) 
            Console.WriteLine($"{item.Name,-10} | {item.Breed,-5} | {item.Cost,-8} | {item.HowMuch(),-10}");
        }


        // --- average calc with LINQ ---

        var averages = animals
            .GroupBy(a => a.Breed)
            .Select(g => new
            {
                species = g.Key,
                AverageCostt = g.Average(a => a.HowMuch())
            });

        foreach (var item in averages)
        {
            Console.WriteLine($"For {item.species} average full cost is: {item.AverageCostt}");
        }



        // var avgCost = animals.Average(a => a.HowMuch());
        // Console.WriteLine(new string('-', 60));
        // Console.WriteLine($"Average Price: {avgCost}"); 
    }
}