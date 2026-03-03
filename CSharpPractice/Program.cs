// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//variables in c#

// int age = 26;
// string name = "Rizwan";
// double height = 5.9;
// bool isDeveloper = true;
// Console.WriteLine(age);
// Console.WriteLine(name);
// Console.WriteLine(height);
// Console.WriteLine(isDeveloper);

// Console.Write("Enter Your Name: ");
// string userName = Console.ReadLine();
// Console.WriteLine(userName);

// Task 1
// Console.Write("Enter Your Name: ");
// string userName = Console.ReadLine();
// Console.Write("enter your age: ");
// int userAge = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Hello " + userName + ", you are " + userAge + " years old. " );

// Task 2

//     int age = 18;
//     if(age < 18){
//         Console.WriteLine("You are under 18");
//     }else
// {
//     Console.WriteLine("your are an adult");
// }
// Console.Write("Enter your age: ");
// int age = int.Parse(Console.ReadLine());
//     if(age < 18){
//         Console.WriteLine("Minor");
//     }else if(age <= 60){    
//         Console.WriteLine("working age");
// }
// else
// {
//     Console.WriteLine("senior citizen");
// }

Console.Write("Your Gender male/female ");
string gender = (Console.ReadLine().ToLower());
if(gender == "male")
{
    Console.WriteLine("Youre gender is male.");
}
else if(gender == "female")
{
    Console.WriteLine("your gender is female");
}
else
{
    Console.WriteLine("invalid input");
}


