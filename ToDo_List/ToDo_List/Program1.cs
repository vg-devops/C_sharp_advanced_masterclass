namespace ToDo_List;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!\n");
        int year = 2009;
        int month = 11;
        int day = 12;
        String date = year + "/" + month + "/" + day;
        Console.WriteLine(date);
        Console.WriteLine("Substraction:"+(year-month));

        string userChoidce = Console.ReadLine();
        userChoidce = "|asdasd";
        string xString;
        xString = "Testo";
        
        string sFull = xString + "asasdasd" + "sdfsdf23";
        xString = "Abrans";
        Console.WriteLine(userChoidce+xString);

        Console.ReadKey();
    }
}