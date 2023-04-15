// See https://aka.ms/new-console-template for more information
using Labb1_Generics.Controllers;
using Labb1_Generics.Models;
Main();
static void Main()
{
    Console.WriteLine("Hello, World!");

    BoxCollection boxes = new BoxCollection()
    {
     new Box(1, 3, 4),
     new Box(8, 2, 9),
     new Box(1, 2, 3),
     new Box(1, 2, 4),
     new Box(1, 5, 6),
    };
    PrintCollection(boxes);
    Console.WriteLine("-----------Trying to add box 3 again-----------");
    boxes.Add(new Box(1, 2, 3));
    Console.WriteLine("-----------Removing box 3-----------");
    boxes.Remove(new Box(1, 2, 3));
    PrintCollection(boxes);
    Console.WriteLine("-----------Testing contains-----------");
    var findBox = new Box(1, 2, 3);
    Console.WriteLine($"The box with dimensions: Height: {findBox.height}, Lenght: {findBox.length}, " +
            $"Width: {findBox.width} " + "{0}", boxes.Contains(findBox) ? "exists" : "Does not exist");
    Console.WriteLine("-----------Displaying all boxes-----------");
    PrintCollection(boxes);
}
static void PrintCollection(BoxCollection boxCollection)
{
    foreach (var box in boxCollection)
    {
        Console.WriteLine($"The box dimensions are: Height: {box.height}, Lenght: {box.length}, " +
            $"Width: {box.width}, Hash: {box.GetHashCode()}");
    }
}