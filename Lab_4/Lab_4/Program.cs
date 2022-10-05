using Lab_4;
using System.Globalization;
using static Lab_4.Constants;


//EX1();
//Ex2();
//Ex3();
Ex4();
void EX1()
{
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());

    try
    {
        Child child = new Child(name, age);
        Console.WriteLine(child);
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine(ae.Message);
    }
}
void Ex2()
{
    try
    {
        string author = Console.ReadLine();
        string titile = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());
        Book book = new Book(author, titile, price);
        GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, titile, price);

        Console.WriteLine(book + Environment.NewLine);
        Console.WriteLine(goldenEditionBook);
    }catch(ArgumentException ae)
    {
        Console.WriteLine(ae.Message);
    }
}
void Ex3()
{
    var studentInfo = Console.ReadLine().Split();
    var workerInfo = Console.ReadLine().Split();

    try
    {
        var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);

        var worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));
        
        Console.WriteLine(student);
        Console.WriteLine(worker);
    }catch(Exception ae)
    {
        Console.WriteLine(ae.Message);
    }
}
void Ex4()
{
    var songs = new List<Song>();
    var songsCount = int.Parse(Console.ReadLine());

    for(int i = 0; i < songsCount; i++)
    {
        var input = Console.ReadLine().ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        try
        {
            var time = input[2].Split(':').ToArray();
            int digit1;
            int digit2;
            if (int.TryParse(time[0], out digit1) && int.TryParse(time[1], out digit2))
            {
                if(digit1 * 60 + digit2 >0 || digit1 * 60 + digit2 < 14 * 60 + 59)
                {
                    songs.Add(new Song(input[0], input[1], digit1, digit2));
                    Console.WriteLine("Song added.");
                }
            }
            else
            {
                throw new InvalidSongLengthException();
            }
        }catch(Exception ise)
        {
            Console.WriteLine(ise.Message);
        }
    }
    var totalDuration = songs.Sum(x => x.Minutes * 60 + x.Seconds);
    var totalHours = totalDuration / 60 / 60;
    var totalMinutes = (totalDuration / 60) - (totalHours * 60);
    long totalSeconds = totalDuration % 60;

    Console.WriteLine($"Songs added: {songs.Count}");
    Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");

   
}