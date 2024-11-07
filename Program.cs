using System.Net.NetworkInformation;
using System.Text;
using CSharpBeginner;

Console.WriteLine("Hello, World!");

// #2. Variables, Types, and Var
string name = "Ngo Huynh Tan Loc";
Console.WriteLine("My name is " + name);

int age = 21;
Console.WriteLine("My age is " + age);

var country = "Viet Nam";
Console.WriteLine("My country is " + country);

// #3. Data Types
string university = "FPT University";

long elonMuskNetWorth = 1000000000000000;

var charchar = 'c';

// #4. Strings In-Depth
Console.WriteLine("#############");
Console.WriteLine("#4. Strings In-Depth");
// Create Read Update Delete
// CRUD

// CREATE
string petDog = "Shiba";

// Concatenation
petDog = "Akita " + petDog;

// Template Literal
Console.WriteLine($"I am buying {petDog}. You cannot stop me!!!");

Console.WriteLine(petDog);

// READ
// Console.WriteLine()

// UPDATE
string newPetDog = petDog.Replace("Akita", "Husky");
Console.WriteLine(newPetDog);

// DELETE
// String Builder
StringBuilder newDog = new StringBuilder();
newDog.Append("Border Collie");
Console.WriteLine(newDog);
newDog.Remove(0, 7);
Console.WriteLine(newDog);

// #5. Arrays
Console.WriteLine("#############");
Console.WriteLine("#5. Arrays");

// Create
string[] favoriteCats = ["fancy cat", "brown cat", "radioactive cat", "wolf cat"];

// Read
//Console.WriteLine(favoriteCats); // wrong, favoriteCats is a pointer
// foreach(var cat in favoriteCats)
// {
//     Console.WriteLine(cat);
// }

// Update
//favoriteCats[0] = "Fancy Cat";
// LINQ - "update array linq"

var newFavoriteCats = favoriteCats.Where((e) => e.StartsWith("b"));

foreach(var cat in newFavoriteCats)
{
    Console.WriteLine(cat);
}

// #6. For & ForEach
Console.WriteLine("#############");
Console.WriteLine("#6. For & ForEach");

// Counter
for(var i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

string[] favoriteFruits = ["Banana", "Apple", "Watermelon"];

for (var i = 0; i < favoriteFruits.Length; i++)
{
    Console.WriteLine(favoriteFruits[i]);
}

foreach(var fruit in favoriteFruits)
{
    Console.WriteLine(fruit);
}

favoriteFruits.ToList().ForEach((i) => {
    Console.WriteLine("ForEach: " + i);
});

Array.ForEach(favoriteFruits, e => Console.WriteLine("Array.ForEach: " + e));

// #7. If/Else Statements
Console.WriteLine("#############");
Console.WriteLine("#7. If/Else Statements");

if(false)
{
    Console.WriteLine("This code will ALWAYS run");
}

var aquariumStoreInventory = "puffer fish";

if((aquariumStoreInventory == "puffer fish") || (aquariumStoreInventory == "clown fish"))
{
    Console.WriteLine("I will buy puffer fish or clown fish!");
}
else
{
    Console.WriteLine("I will not buy anything!");
}

// <>
var fishTankPrice = 999;

if(fishTankPrice <= 1000)
{
    Console.WriteLine("Buy tank");
}
else
{
    Console.WriteLine("Don't buy");
}

string aquariumFish = "puffer fish";

if (aquariumFish is string)
{
    Console.WriteLine("Aquarium fish is a string");
}

// #8. Enum
Console.WriteLine("#############");
Console.WriteLine("#8. Enum");

// Console.WriteLine(Warning.CodeYellow);
// Console.WriteLine((int)Warning.CodeYellow);

// var status = Warning.CodeYellow;
// if(status == Warning.CodeYellow)
// {
//     Console.WriteLine("CODE YELLOW");
// }

// enum Warning
// {
//     CodeRed, // 0
//     CodeBlue, // 1
//     CodeYellow // 2
// }

// #9. Switch Statement & Expression
Console.WriteLine("#############");
Console.WriteLine("#9. Switch Statement & Expression");

var preHistoricFish = "Cockerelitte";

switch(preHistoricFish)
{
    case "Heliobatis":
        Console.WriteLine("Heliobatis");
        break;
    case "Cockerelitte":
        Console.WriteLine("Cockerelitte");
        break;
    default:
        Console.WriteLine("Nothing matches!");
        break;
}

var result = preHistoricFish switch
{
    "Heliobatis" => "Heliobatis",
    "Cockerelitte" => "Cockerelitte",
    _ => "No match!"
};

Console.WriteLine("This is a " + result);

// #10. While
Console.WriteLine("#############");
Console.WriteLine("#10. While");

// Pinger

Ping p1 = new Ping();
PingReply PR = p1.Send("8.8.8.8");

// while(PR.Status.ToString() == "Success")
// {
//     Console.WriteLine(PR.Status.ToString() + "!");
//     PR = p1.Send("8.8.8.8");
//     Console.WriteLine("Waiting ten seconds for next request");
//     Thread.Sleep(10000);
// }

// #11. Class
Console.WriteLine("#############");
Console.WriteLine("#11. Class");

// CRUD

Rat wolfRat = new Rat();
Rat fancyRat = new Rat();

wolfRat.Name = "Wolf Rat";
wolfRat.Number = 1000;
wolfRat.IsRadioactive = false;

fancyRat.Name = "Fancy Rat";
fancyRat.Number = 500;
fancyRat.IsRadioactive = false;

// Read
Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

// Update
wolfRat.Name = "WOLF RAT";
fancyRat.Name = "FANCY RAT";

Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

// Delete
wolfRat.Name = "";
fancyRat.Name = "";

Console.WriteLine("Check wolfRat Name after delete: " + wolfRat.Name);
Console.WriteLine("Check fancyRat Name after delete: " + fancyRat.Name);

// #12. Methods
Console.WriteLine("#############");
Console.WriteLine("#12. Methods");

RealEstate elmStreet = new()
{
    Address = "Elm Street",
    SquareFootage = 1300,
    Price = 300000
};

Console.WriteLine(elmStreet.CalculatePricePerSquareFoot());

// #13. Tuple
Console.WriteLine("#############");
Console.WriteLine("#13. Tuple");

(string, int, string) values = ("t", 2, "p");

Console.WriteLine(values.Item1);
Console.WriteLine(values.Item2);
Console.WriteLine(values.Item3);

var valuesWithName = (First: "t", Second: 2, Third: "p");

Console.WriteLine(valuesWithName.First);
Console.WriteLine(valuesWithName.Second);
Console.WriteLine(valuesWithName.Third);

(int a, string b, bool c) ReturnTheseValues()
{
    return (9, "u", true);
}

(int a, string b, bool c) = ReturnTheseValues();
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

// #14. Null Reference Exception/Error
Console.WriteLine("#############");
Console.WriteLine("#14. Null Reference Exception/Error");

int? value = null;

string? value2 = null;

if(value2 is not null)
{
    Console.WriteLine(value2.Length);
}

Console.WriteLine(value2 ?? "No value!"); // ?? null-coalescing

Console.WriteLine(value2 is not null ? "Has value!" : "No value");

// #15. Constructor
Console.WriteLine("#############");
Console.WriteLine("#15. Constructor");

Dog oKiKi = new("O Ki Ki");
oKiKi.Name = "Fish";
Console.WriteLine(oKiKi.Name);