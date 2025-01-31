// Author: Adam Verissimo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.
namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Budget Management Tool!\n");
            int income;
            int choice;
            int expense = 0;
            string expenseName = "";
            string nameRemove; 
            Console.Write("Enter your monthly income: ");
            income = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter the expense name: ");
                        expenseName = Console.ReadLine();
                        Console.Write("Enter the expense amount: ");
                        expense = int.Parse(Console.ReadLine());
                        Console.WriteLine("Expense added successfully!");
                        break;
                    case 2:
                        Console.WriteLine($"- {expenseName}: {expense}");
                        Console.WriteLine($"Total Expenses: {expense}");
                        Console.WriteLine($"Remaining Budget: {income - expense}");
                        break;
                    case 3:
                        Console.Write("Enter the name of the expense to remove: ");
                        nameRemove = Console.ReadLine();
                        Console.WriteLine("Expense removed successfully!");
                        break;
                }

                if (choice == 4) break;
            }
        }
    }
}