using MyFirstC_Program;

var menu = new Menu();
var date = DateTime.Now;

var games = new List<string>();


string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type in your name");
    var name = Console.ReadLine();
    return name;
}






