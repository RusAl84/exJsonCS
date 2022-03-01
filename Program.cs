// See https://aka.ms/new-console-template for more information
using exJsonCS;
using Newtonsoft.Json;

//1
string fileJsonString = File.ReadAllText("1.json");
Person tmpPerson = new Person();
tmpPerson = JsonConvert.DeserializeObject<Person>(fileJsonString);
string sexString = "";
if (tmpPerson.Sex == true)
    sexString = "Male";
else
    sexString = "Female";
Console.WriteLine($"Имя: {tmpPerson.Name} Возраст: {tmpPerson.Age} Пол: {sexString}");


//2
Person bred = new Person();
bred.Name = "Pit";
bred.Age = 49;
string jsonString = JsonConvert.SerializeObject(bred, Formatting.Indented);
File.WriteAllText("bred.json", jsonString);
Console.WriteLine("Файл записан");


//3
string tmpString = File.ReadAllText("bred.json");
Console.WriteLine(tmpString);