
Console.Write("Enter an integer: ");
var answer = Console.ReadLine();
var theNbr = Convert.ToInt32(answer);

while (theNbr != 0) {
    if (theNbr % 2 == 0) {
        Console.WriteLine($"The number {theNbr} is even");
    } else { 
        Console.WriteLine($"The number {theNbr} is odd");
}

    Console.Write("Enter an integer: ");
    answer = Console.ReadLine();
    theNbr = Convert.ToInt32(answer);
}