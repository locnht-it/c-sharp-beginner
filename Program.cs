using System.Text;

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