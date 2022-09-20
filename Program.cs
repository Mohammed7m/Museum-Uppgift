while (true)
{
    Console.Clear();

    Console.WriteLine("Hej och välkommen till Tobacco And Salt Museum!");

    Console.WriteLine("[1]. Ingång till Museum!");
    Console.WriteLine("[2]. Avsluta");

    int input = Int32.Parse(Console.ReadLine());


    if (input == 1)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Ni står nu i entréhallen, var önskar ni gå?");
            Console.WriteLine("[1]. Utställningshall 1");
            Console.WriteLine("[2]. Utställningshall 2");
            Console.WriteLine("[3]. Café/Presentaffär");
            Console.WriteLine("[4]. Avsluta");

            int Meny = Int32.Parse(Console.ReadLine());

            if (Meny == 1)
            {
                SaltWater();
            }

            else if (Meny == 2)
            {
                ShowHimalaya();
            }

            else if (Meny == 3)
            {
                Cofe();

            }

            else if (Meny == 4)
            {
                Environment.Exit(1);
            }

        }
    }
    else if (input == 2)
    {
        Console.WriteLine("Programmet avslutas");
        Environment.Exit(0);
    }

}



static void SaltWater()
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("*Tittar på att saltvatten avdunstar");
        Console.WriteLine(" - In till cafe, tryck [Y]\n");
        Valfritangent();
        string input1 = Console.ReadLine().ToLower();

        if (input1 == "y")
        {
            Console.Clear();

            Console.WriteLine("Välkommen till cafe");

            Console.WriteLine(" - In till Presentaffär tryck [P]\n");
            Valfritangent();

            string input2 = Console.ReadLine().ToLower();
            if (input2 == "p")
            {
                Console.Clear();

                Console.WriteLine("Passa på att köpa en pricents!\n");
                Valfritangent();

                Console.ReadLine();
            }
            
        }
        else
        {
            break;
        }

    }

}


static void ShowHimalaya()
{
    Console.Clear();

    Console.WriteLine("*Tittar på bilder av Himalaya\n");
    Valfritangent();
    
    Console.ReadLine();
}


static void Cofe()
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("Välkommen till cafe");
        Console.WriteLine(" - In till (Presentaffär) tryck [p] \n - In till (Utställningshall 1) tryck [u] \n");
        Valfritangent();

        string input3 = Console.ReadLine().ToLower();

        if (input3 == "u")
        {
            Console.Clear();

            Console.WriteLine("*Tittar på att saltvatten avdunstar\n");
            Valfritangent();
            Console.ReadLine();
        }
        else if (input3 == "p")
        {
            Console.Clear();

            Console.WriteLine("Passa på att köpa en pricents!\n");
            Valfritangent();
            Console.ReadLine();
        }
        else
        {
            break;
        }
    }
}

static void Valfritangent()
{
    Console.WriteLine("Tryck valfri tangent för tillbaka");
}