// This is challenge work for the "C# Players Guide"
// Level 8 The Defense of Consolas Challenge
//This is challenge assumes an 8X8 Grid
//The challenge requires a console color change and a beep. 

//Set the console color to green
Console.ForegroundColor = ConsoleColor.Green;

//Collect the expected attack coordinates (Row and Column) based on the scenario
Console.WriteLine("---------------Defense Coordination Calculator--------------------");
Console.Write("Enter the Target Row: ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Target Column: ");
int targetColumn = Convert.ToInt32(Console.ReadLine());


//Change the console color
Console.ForegroundColor = ConsoleColor.Red;

//Provide four defense position squares that surround the provided attack coordinates
Console.WriteLine("___________________________________________________________________");
Console.WriteLine("Move the following locations: ");
Console.WriteLine($"First Position: ({targetRow}, {targetColumn - 1})");
Console.WriteLine($"Second Position: ({targetRow}, {targetColumn + 1})");
Console.WriteLine($"Third Position: ({targetRow - 1}, {targetColumn})");
Console.WriteLine($"Fourth Position: ({targetRow + 1}, {targetColumn})");
Console.WriteLine("___________________________________________________________________");

//Add Console Beep sound
Console.Beep(450, 800);


//Restore the console color back to green
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Press any key to end program");
Console.ReadKey();




