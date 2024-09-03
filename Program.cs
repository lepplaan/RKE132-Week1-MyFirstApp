// Rakendus küsib kasutajal sisestada tema nime
// Rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter you name:"); //Output

// string - sõne
string userName = Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!"); //Output
// string interpolation

Console.WriteLine($"Hello, {userName}!"); //Output
