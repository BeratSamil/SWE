namespace examFigure;


class Figure
{
    private int dimension;

    public int Dimension
    {
        get { return dimension; }
        set { dimension = value; }
    }

    public Figure(int dimension)
    {
        this.dimension = dimension;
    }

    public virtual double Area()
    {
        return 0;
    }
    
} //end of Figure class



class Rectangle : Figure //inherits from Figure
{
    private double width;
    private double height;

    public double Width
    {
        get { return width; }
        set { width = value; }
    }
    public double Height
    {
        get {return height;}
        set {height = value;}
    }
    
    public Rectangle(double width,double height) : base(2) //calls base class constructor from the base class
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Rectangle> rectangles = new List<Rectangle>();
        rectangles.Add(new Rectangle(3,5));
        rectangles.Add(new Rectangle(6,6));
        rectangles.Add(new Rectangle(5,7));
        rectangles.Add(new Rectangle(8,12));
        rectangles.Add(new Rectangle(9,13));

        Console.WriteLine("Rectengles and their properties:");
        Console.WriteLine("");
        
        int ctr = 1;
        foreach (var rectangle in rectangles)
        {
            Console.WriteLine($"Rectangle {ctr}:");
            Console.WriteLine($"  Width: {rectangle.Width}");
            Console.WriteLine($"  Length: {rectangle.Height}");
            Console.WriteLine($"  Area: {rectangle.Area()}");
            Console.WriteLine($"  Dimension: {rectangle.Dimension}");
            Console.WriteLine();
            ctr++;
        }


        double averageArea = rectangles.Average(r => r.Area());
        Console.WriteLine($"Average area of all rectangles: {averageArea}");


    



        
        
    }
}
