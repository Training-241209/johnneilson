namespace ExpenseTracker;

class Program
{


    static void Main(string[] args){
        Greeting();
        DisplayOptions();

        int selectedOption = getUserOption();
        switch(selectedOption){
            case 1:
                Console.WriteLine("User selected add expense");
                break;
            case 2:
                Console.WriteLine("User selected view all expenses");
                break;
            case 3:
                Console.WriteLine("User selected edit an expense");
                break;
            case 4:
                Console.WriteLine("User selected delete an expense");
                break;
            case 5:
                Console.WriteLine("Saving to a file...");
                break;
            case 6:
                Console.WriteLine("Exiting the program...");
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }

    public static void Greeting(){
        Console.WriteLine("Welcome to the Expense Tracker!");
        Thread.Sleep(1500);
        Console.WriteLine("Select one of the following options:\n");
    }

    public static void DisplayOptions(){
        Console.WriteLine("1. Add Expense");
        Console.WriteLine("2. View All Expenses");
        Console.WriteLine("3. Edit Expenses");
        Console.WriteLine("4. Delete Expenses");
        Console.WriteLine("5. Save to a file");
        Console.WriteLine("6. Exit");
    }

    public static int getUserOption(){
        Console.WriteLine("Select an option:\n");
        string? userInput = Console.ReadLine();
        try{
            return Int32.Parse(userInput);
        }
        catch(FormatException e){
            Console.WriteLine("Invalid input! Make sure you typed a number.");
            return getUserOption();
        }
    }
}
