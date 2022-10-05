using Lab_3;
using System;

//Ex1();
//Ex3();
//Ex4();
Ex5();

void Ex1()
{
    var lines = int.Parse(Console.ReadLine());
    var boxes = new List<Box>();
    for (int i = 0; i < lines; i++)
    {
        try
        {
            var cmdArgs = Console.ReadLine().Split();
            // Console.WriteLine(cmdArgs[3]);
            var box = new Box(double.Parse(cmdArgs[0]),
                                    double.Parse(cmdArgs[1]),
                                    double.Parse(cmdArgs[2]));
            boxes.Add(box);
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    boxes.ForEach(p => Console.WriteLine(p.ToString()));
}

void Ex3()
{
    var lines = int.Parse(Console.ReadLine());
    for(int i = 0; i < lines; i++)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        try
        {
            Chicken chicken = new Chicken(name, age);
            Console.WriteLine(
                "Chicken {0} (age {1}) can produce {2} eggs per day.",
                chicken.Name,
                chicken.Age,
                chicken.ProductPerDay);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
  
}
void Ex4()
{
    var people = new List<Person>();
    var products = new List<Product>();

    var allPeople = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    var allProducts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

    try
    {
        foreach (var pair in allPeople)
        {
            var personInfo = pair.Split('=');
            var person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
            people.Add(person);
        }

        foreach (var pair in allProducts)
        {
            var productInfo = pair.Split('=');
            var product = new Product(productInfo[0], decimal.Parse(productInfo[1]));
            products.Add(product);
        }

        string purchase;
        while ((purchase = Console.ReadLine()) != "END")
        {
            var purchaseInfo = purchase.Split(' ');
            var buyerName = purchaseInfo[0];
            var productName = purchaseInfo[1];

            var buyer = people.FirstOrDefault(b => b.Name == buyerName);
            var productToBuy = products.FirstOrDefault(bp => bp.Name == productName);

            try
            {
                buyer.BuyProduct(productToBuy);
                Console.WriteLine($"{buyerName} bought {productName}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        foreach (var person in people)
        {
            var boughtProducts = person.GetProducts();
            var result = boughtProducts.Any()
                ? string.Join(", ", boughtProducts.Select(pr => pr.Name).ToList())
                : "Nothing bought";
            Console.WriteLine($"{person.Name} - {result}");
        }
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }

}
void Ex5()
{
    string pizzaName = Console.ReadLine().Split()[1];

    string[] doughData = Console.ReadLine().Split();
    string flourType = doughData[1];
    string bakingTechniques = doughData[2];
    int weight = int.Parse(doughData[3]);

    try
    {
        Dough dough = new Dough(flourType, bakingTechniques, weight);
        Pizza pizza = new Pizza(pizzaName, dough);

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "END")
            {
                break;
            }

            string[] partsTopping = line.Split();

            string toppingName = partsTopping[1];
            int toppingWeight = int.Parse(partsTopping[2]);

            Topping topping = new Topping(toppingName, toppingWeight);

            pizza.AddTopping(topping);

        }

        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}