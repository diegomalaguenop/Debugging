// Challenge 1
bool amProgrammer = true; //se eliminan las comillas de true
int Age = 27; // Se cambia a 27 ya que es un entero
List<string> Names = new List<string>();
Names.Add("Monica"); // Se agrega "Monica" a la lista de Names
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "O"); //se cambia el numero 0 a la letra O ya que es un string
MyDictionary.Add("Hi there", "O"); //se cambia el numero 0 a la letra O ya que es un string
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName"; // se cambia las comillas simples por doble comillas

// Utilizando las variables
Console.WriteLine("Soy programador: " + amProgrammer);
Console.WriteLine("Mi edad es: " + Age);
Console.WriteLine("Mi nombre es: " + MyName);

Console.WriteLine("1---------");


// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count -1; i >= 0; i--) // se agrega el -1 a Numbers.Count
{
    Console.WriteLine(Numbers[i]);
}

Console.WriteLine("2 ---------");


// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i); // se elimina MoreNumbers y se deja solo i 
}

Console.WriteLine("3---------");


// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
List<int> ModifiedNumbers = new List<int>(); // crear nueva lista para valores modificados
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
       ModifiedNumbers.Add(0); // si el numero es divisible por 3, agegamos 0 a la lista de valores modificados
    }
    else {
        ModifiedNumbers.Add(num);
    } 
}

  // Imprimir el valor final de ModifiedNumbers
        Console.WriteLine("Valor final de ModifiedNumbers:");
        foreach (int num in ModifiedNumbers)
        {
            Console.WriteLine(num + " ");
        }


Console.WriteLine("4---------");


string MyString = "superduberawesome";
int y = 7;
if (y >= 0 && y < MyString.Length)
{
    MyString = MyString.Remove(y, 1).Insert(y, "p");
}
else
{
    Console.WriteLine("Error: La posición especificada está fuera de los límites de la cadena.");

}
Console.WriteLine(MyString);

Console.WriteLine("5---------");


// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(13); //se cambia a 13 para incluir el 12
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
else
{
    Console.WriteLine("El número que se generó es: " + randomNum);
}
