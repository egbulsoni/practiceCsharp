// See https://aka.ms/new-console-template for more information
using practiceCode;

int myNumber = -150;
int absoluteValue = Math.Abs(myNumber);
int maxValue = Math.Max(myNumber, 55);

int[] myArray = new int[5];
myArray[0] = 8;
myArray[1] = 6;


Console.WriteLine(myArray[0]);
Console.ReadKey();

int myValue = 0;
int myOtherValue = 0;
int forLoopVal = 0;

while (myValue < 10)
{
    myValue++;
    myOtherValue -= 5;
}

for (int i = 0; i < 5; i++)
{
    forLoopVal += 10;
}

Console.WriteLine(myValue);
Console.WriteLine(myOtherValue);
Console.WriteLine(forLoopVal);
Console.ReadKey();

Person myPerson = new Person("Joe", 80);
myPerson.name = "Joe";

Console.WriteLine(myPerson.name);
Console.ReadKey();
myPerson.Eat(10);

Console.WriteLine(myPerson.weight);
Console.ReadKey();

Console.WriteLine(myPerson.FirstInitial());
Console.ReadKey();

Person mySecondPerson = new Person("Nancy", 50);
Console.WriteLine(mySecondPerson.name);
Console.WriteLine(mySecondPerson.weight);

Person myDefaultPerson = new Person();
Console.WriteLine(myDefaultPerson.name);
Console.WriteLine(myDefaultPerson.weight);

Console.WriteLine(Person.species);

Person myStoopidPerson = new Person("Jeff");
Console.WriteLine(myStoopidPerson.name);
Console.WriteLine(myStoopidPerson.weight);
Console.WriteLine(Person.personCount);