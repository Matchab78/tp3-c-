using tp3;

class Program
{
    static void Main(string[] args)
    {

        Catégorie cat1 = new Catégorie("chef", "D'accord");
        Commerciale c1 = new Commerciale("Habert", "Manon", 1990,cat1);

        Service s1 = new Service("international", [], 10);
        Service s2 = new Service("national", [], 5);

        Catégorie cat2 = new Catégorie("lieutenant", "Merci");
        Commerciale c2 = new Commerciale("Verstappen", "Max", 1987,cat2);

        Commerciale c3 = new Commerciale("Monkey D", "Luffy", 1997,cat2 );

        Console.WriteLine("voici les informations du commerciale : \n" + c1);
        Console.WriteLine("voici les informations du commerciale : \n" + c2);
        Console.WriteLine("voici les informations du commerciale : \n" + c3);

        c1.Compare(c2);

    }
}