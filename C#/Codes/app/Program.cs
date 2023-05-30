// Vaiables and data types
int age = 25;
string name = "Amal";
bool student = true;

// Control statements
if (age >= 18){
    Console.WriteLine("You are eligible to vote");
}
else{
    Console.WriteLine("You are not eligible to vote");
}

for (int i = 0; i <= 5; i++){
    Console.WriteLine(i);
}

Console.WriteLine("Enter the Option: ");
string input = Console.ReadLine();
int choice = Convert.ToInt32(input);

switch (choice)
{
    case 1:
        Console.WriteLine("Option 1 selected.");
        break;
    case 2:
        Console.WriteLine("Option 2 selected.");
        break;
    default:
        Console.WriteLine("Invalid option.");
        break;
}

// Funcions and Methods
int result = Add(3, 5);
Console.WriteLine(result);

int Add(int a, int b){
    return a + b;
}