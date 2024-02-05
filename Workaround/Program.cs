//Variables();
using Business.Concrete;
using Entities.Concrete;

Citizen citizen1 = new Citizen();
SayHi(name: "Engin");
SayHi(name: "Burak");
SayHi();

int result = Sum(7, 6);


string student1 = "Engin";
string student2 = "Ali";
string student3 = "Burak";

Console.WriteLine(student1);
Console.WriteLine(student2);
Console.WriteLine(student3);

string[] students = new string[3];
students[0] = student1;
students[1] = student2;
students[2] = student3;
students = new string[4];
students[3] = "İlker";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"{i + 1}. Öğrenci -> " + students[i]);
}

string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Van";
Console.WriteLine(cities2[0]);

Person person1 = new Person();
person1.FirstName = "Burak";
person1.LastName = "Sakin";
person1.DateOfBirthYear = 1995;
person1.NationalIdentity = 123654;

Person person2 = new Person();
person2.FirstName = "Engin";

foreach (var city in cities1)
{
    Console.WriteLine(city);
}

Console.WriteLine("--------");

List<string> newCities1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
newCities1.Add("Adana");
foreach (var newCity in newCities1)
{
    Console.WriteLine(newCity);
}
Console.WriteLine("--------");

MyList<string> newCities2 = new MyList<string> { "Düzce","Kars","Erzurum"};
newCities2.Add("Amasya");
foreach (var ownCity in newCities2)
{
    Console.WriteLine(ownCity);
}

Console.WriteLine("--------");

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

static void SayHi(string name = "NaN")
{
    Console.WriteLine("Merhaba " + name);
}

static int Sum(int number1 = 0, int number2 = 0)
{
    int result = number1 + number2;
    Console.WriteLine("Sonuc -> " + result);
    return result;
}

static void Variables()
{
    string message = "Merhaba";
    double price = 1000;
    int number = 100;
    bool isAuth = false;

    Console.WriteLine(price * 1.2);

    string firstName = "burak";
    string lastName = "burak";
    int birthYear = 1995;
    long tcId = 12345678990;

}

public class Citizen
{
    //public string firstName = "burak";
    //public string lastName = "burak";
    //public int birthYear = 1995;
    //public long tcId = 12345678990;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public long TcId { get; set; }

}
