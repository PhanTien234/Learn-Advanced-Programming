

using Exercise6;
Ex5();
//Ex4();
//Ex3();
//Ex2();
//Ex1();
//void Ex1()
//{
//    string name = Console.ReadLine();
//    int age = int.Parse(Console.ReadLine());
//    IPerson person = new Citizen(name, age);
//    Console.WriteLine(person.Name);
//    Console.WriteLine(person.Age); 

//}
void Ex2()
{
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    string id = Console.ReadLine();
    string birthdate = Console.ReadLine();
    IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
    IBirthable birthable = new Citizen(name, age, id, birthdate);
    Console.WriteLine(identifiable.Id);
    Console.WriteLine(birthable.Birthdate);

}
void Ex3()
{
    string driverName = Console.ReadLine();

    var ferrari = new Ferrari(driverName);

    Console.WriteLine(ferrari);
}
void Ex4()
{
    var smartphone = new Smartphone();

    var numbers = Console.ReadLine().Split();
    var urls = Console.ReadLine().Split();

    try
    {
        numbers.ToList().ForEach(x => Console.WriteLine(smartphone.Call(x)));
        urls.ToList().ForEach(x => Console.WriteLine(smartphone.Browse(x)));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
void Ex5(){
        var borderControl = new BoderControl();

        var input = Console.ReadLine();

        while (input != "End")
        {
            try
            {
                var inputArgs = input.Split();
                var memberType = inputArgs[0];

                switch (memberType.ToLower())
                {
                    case "robot":
                        var model = inputArgs[1];
                        var robotId = inputArgs[2];
                        borderControl.AddRobot(model, robotId);
                        break;
                    case "citizen":
                        var citizenName = inputArgs[1];
                        var age = int.Parse(inputArgs[2]);
                        var citizenId = inputArgs[3];
                        var citizenBirthdate = inputArgs[4];
                        borderControl.AddCitizen(citizenName, age, citizenId, citizenBirthdate);
                        break;
                    case "pet":
                        var petName = inputArgs[1];
                        var petBirthdate = inputArgs[2];
                        borderControl.AddPet(petName, petBirthdate);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            input = Console.ReadLine();

        var matchBirthYear = Console.ReadLine();
        Console.WriteLine(borderControl.GetBirthdatesByYear(matchBirthYear));
    }

   static void ExecuteFoodShortage()
    {
        var borderControl = new BoderControl();

        var personsNum = int.Parse(Console.ReadLine());

        for (int i = 0; i < personsNum; i++)
        {
            var input = Console.ReadLine();

            try
            {
                var inputArgs = input.Split();

                switch (inputArgs.Length)
                {
                    case 4:
                        var citizenName = inputArgs[0];
                        var age = int.Parse(inputArgs[1]);
                        var citizenId = inputArgs[2];
                        var citizenBirthdate = inputArgs[3];
                        borderControl.AddCitizen(citizenName, age, citizenId, citizenBirthdate);
                        break;
                    case 3:
                        var rebelName = inputArgs[0];
                        var rebelAge = int.Parse(inputArgs[1]);
                        var rebelGroup = inputArgs[2];
                        borderControl.AddRebel(rebelName, rebelAge, rebelGroup);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        var currentPersonName = Console.ReadLine();

        while (currentPersonName != "End")
        {
            borderControl.BuyFrom(currentPersonName);

            currentPersonName = Console.ReadLine();
        }

        Console.WriteLine(borderControl.GetTotalFoodPurchased());
    }
}