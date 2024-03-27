using tp3;

class Program
{
    static void Main(string[] args)
    {

        Catégorie cat1 = new Catégorie("chef", "1");
        Catégorie cat2 = new Catégorie("lieutenant", "2");
        Catégorie cat3 = new Catégorie("jsp", "3");

        Service s1 = new Service("international");
        Service s2 = new Service("national");
        

        Commerciale c1 = new Commerciale("Ht", "zebi", 1990,cat1, s1);
        Commerciale c2 = new Commerciale("Verstappen", "Max", 1987,cat2, s2);
        Commerciale c3 = new Commerciale("Monkey D", "Luffy", 1997, cat3, s1);
        Commerciale c4 = new Commerciale("Robin", "Nico", 2000, cat3, s2);
        Commerciale c5 = new Commerciale("Roronoa", "Zoro", 1999, cat3, s1);


        Console.WriteLine("voici les informations du commerciale : \n" + s1);
        Console.WriteLine("voici les informations du commerciale : \n" + s2);

        c1.Compare(c2);

    }
}