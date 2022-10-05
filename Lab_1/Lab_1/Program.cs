// See https://aka.ms/new-console-template for more information
using Lab_1;
using System.Reflection;
//Ex1();
//Ex2();
//Ex3();
//Ex4();
//Ex5();
//Ex6();
Ex7();
void Ex1()
{ 
    Type personType = typeof(Person);
    FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
    Console.WriteLine(fields.Length);
}

void Ex2()
{
    Type personType = typeof(Person);
    ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
    ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
    ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
    bool swapped = false;
    if (nameAgeCtor == null)
    {
        nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
        swapped = true;
    }

    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());

    Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
    Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
    Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

    Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
    Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
    Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);

}
void Ex3()
{

    MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
    MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
    if (oldestMemberMethod == null || addMemberMethod == null)
    {
        throw new Exception();
    }
    Family myFamily = new Family();
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++)
    {
        string info = Console.ReadLine();
        string[] infoArray = info.Split();
        Person myPerson = new Person(infoArray[0], int.Parse(infoArray[1]));
        myFamily.AddMember(myPerson);
    }
    Person oldestPerson = myFamily.GetOldestMember();
    Console.WriteLine("_______________________________");
    Console.WriteLine("{0} {1}", oldestPerson.name, oldestPerson.age);

}
void Ex4()
{
    List<Person> myList = new List<Person>();
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++)
    {
        string info = Console.ReadLine();
        string[] infoArray = info.Split();
        if (int.Parse(infoArray[1]) > 30)
        {
            Person myPerson = new Person(infoArray[0], int.Parse(infoArray[1]));
            myList.Add(myPerson);
        }
    }
    myList.Sort();
    Console.WriteLine("__________________________________________");
    foreach (Person myPerson in myList)
    {
        Console.WriteLine("{0} {1}", myPerson.name, myPerson.age);
    }
}
void Ex5()
{
    string date1 = Console.ReadLine();
    string date2 = Console.ReadLine();
    int result = DateModifier.DifferenceDate(date1, date2);
    Console.WriteLine(result);
}
void Ex6()
{
    List<Employee> myList = new List<Employee>();
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++)
    {
        string info = Console.ReadLine();
        string[] infoArray = info.Split();
        Employee employee;
        if (infoArray.Length == 4)
            employee = new Employee(infoArray[0], double.Parse(infoArray[1]), infoArray[2], infoArray[3]);
        else if (infoArray.Length == 6)
            employee = new Employee(infoArray[0], double.Parse(infoArray[1]), infoArray[2], infoArray[3], infoArray[4], int.Parse(infoArray[5]));
        else if (infoArray[4].Contains("@"))
            employee = new Employee(infoArray[0], double.Parse(infoArray[1]), infoArray[2], infoArray[3], infoArray[4]);
        else employee = new Employee(infoArray[0], double.Parse(infoArray[1]), infoArray[2], infoArray[3], int.Parse(infoArray[4]));
        myList.Add(employee);
    }
    var best = myList.GroupBy(g => g.department)
        .Select(g => new
        {
            Average = g.Average(e => e.salary),
            Department = g.Key
        }).OrderByDescending(d => d.Average).First();
    Console.WriteLine("__________________________________________");
    Console.WriteLine("Highest Average Salary:" + best.Department);
    myList = myList.FindAll(g => g.department == best.Department).OrderByDescending(g => g.salary).ToList();
    foreach (Employee employee in myList)
    {
        if (employee.department == best.Department)
            Console.WriteLine(employee);
    }
}
void Ex7()
{
    var orderCar = new Dictionary<string, Car>();

    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string[] input = Console.ReadLine()
            .Split();

        string model = input[0];
        double fuelAmount = double.Parse(input[1]);
        double fuelConsumptionFor1km = double.Parse(input[2]);

        orderCar[model] = new Car { FuelAmount = fuelAmount, FuelConsumptionFor1km = fuelConsumptionFor1km };
    } 

    string inputPrim = null;
    while ((inputPrim = Console.ReadLine()) != "End")
    {
        string[] input = inputPrim
             .Split();

        string currentModel = input[1];
        int currentDistanse = int.Parse(input[2]);

        foreach (var kvp in orderCar)
        {
            if (kvp.Key == currentModel)
            {
                kvp.Value.TryTraveledThisDistance(currentDistanse);
            }
        } 
    }
    Console.WriteLine("_____________________________________________");

    foreach (var kvp in orderCar)
    {
        Console.WriteLine("{0} {1:0.00} {2}", kvp.Key, kvp.Value.FuelAmount, kvp.Value.TraveledKilometers);
    }
}