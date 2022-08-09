// See https://aka.ms/new-console-template for more information
using CoalesceExample;

Console.WriteLine("Hello, World!");


var problematicPerson = new Person();

var person = new Person() { Friends = new(), Name = "Jimbo" };

// because person has fields initialized, I can say:
person.Friends.Add(new Person() { Name = "Alice"});

// because problematicPerson has not initialized their friends,
// if I try to do this we will get a null reference exception

problematicPerson.Friends.Add(person); //<- will break your code as it is null

// but we can initialize it with:

problematicPerson.Friends ??= new List<Person>();

// this will check if friends is null, if it is, then we will initialize it as a new List.
// if it is not null, then we will simply leave it as it is

// now we can try adding the person again
problematicPerson.Friends.Add(person);


// this line will not write anything because name is null
Console.WriteLine(problematicPerson.Name);

// this line will write "No Name" because we return that instead of .Name, since Name is null
Console.WriteLine(problematicPerson.Name ?? "No Name");

// readline to stop before next break
Console.ReadLine();

var employer = new Employer();

// This line will also break because we are trying to de-reference the PlaceOfEmployment which is null.
Console.WriteLine(employer.PlaceOfEmployment.Name);

// This line will not break, because we add the question mark we will return null instead of trying
// to dereference the Company (PlaceOfEmployment) - but because we are returning null we will not write anything.
Console.WriteLine(employer.PlaceOfEmployment?.Name);

Console.WriteLine(employer.PlaceOfEmployment?.Name ?? "TrueCoders");
