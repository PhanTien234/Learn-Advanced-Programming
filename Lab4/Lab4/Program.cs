using Lab4;
//lab1();
//lab2();
//lab3();
//lab_4();
Lab_5();
void lab1()
{
    Dog dog = new Dog();
    dog.Eat();
    dog.Bark();
}

void lab2()
{
    Puppy puppy = new Puppy();
    puppy.Eat();
    puppy.Bark();
    puppy.Weep();
}

void Lab3()
{
    Dog dog = new Dog();
    dog.Eat();
    dog.Bark();
    Cat cat = new Cat();
    cat.Eat();
    cat.Meow();
}

void lab_4()
{
    RandomList myList = new RandomList();
    myList.Add("My name ");
    myList.Add("Hello");
    myList.Add("Goodbye");
    myList.Add("Welcome");
    myList.Add("Do you know me? ");
    Console.WriteLine($"Remove the element {myList.RemoveRAndomElement()}");
    myList.ForEach(my => Console.WriteLine(my));
}
void Lab_5()
{
    StackOfString myStack = new StackOfString();
    myStack.Push("Hello");
    myStack.Push("Goodbye");
    List<string> myList = new List<String>();
    myList.Add("My Name");
    myList.Add("Hello");
    myList.Add("Goodbye");
    myList.Add("Welcome");
    myList.Add("Do you know me?");
    myStack.AddRange(myList);
    while (!myStack.IsEmpty())
    {
        Console.WriteLine(myStack.Pop());
    }
}