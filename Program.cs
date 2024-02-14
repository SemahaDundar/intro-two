// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");


string message1 = "Krediler";
int term = 12;
double amount = 1000.7;

bool isAuthenticated = true;

//variables =>camelCase yazılır

Console.WriteLine(message1);

//condition

if(isAuthenticated == true)
{
    Console.Write("Hoşgeldiniz..");

}
else
{
    Console.WriteLine("Sisteme Giriş Yapınız");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6", };

//string[] loans2 = new string[6];
//loans2[0] = "Kredi1";

//start condition   increment = artırma

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[1]);
}


CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " /" + courses2[i].Price);
}


Console.WriteLine("Kod Bitti");


IndividualCustomer customer1 = new IndividualCustomer();

customer1.Id = 1;
customer1.NationalIdentity = "87654329087";
customer1.FirstName= "Aydın";
customer1.LastName = "Zeytin";
customer1.CustomerNumber = "874532";



IndividualCustomer customer2 = new IndividualCustomer();

customer2.Id = 2;
customer2.NationalIdentity = "76854320981";
customer2.FirstName = "Feride";
customer2.LastName = "Gevrek";
customer2.CustomerNumber = "659432";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "467583";
customer3.TaxNumber = "87654390213";



CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Syz";
customer4.CustomerNumber = "980123";
customer4.TaxNumber = "87096789546";

// value types ==>int, boll, doble

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 40;
Console.WriteLine(number1);

// Referans type => arrays, class, interface..

string[] cities1 = { "Sakarya", "Muğla", "Balıkesir" };
string[] cities2 = { "Mardin", "Hatay", "Antalya" };

cities2 = cities1;
cities1[0] = "Sinop";


Console.WriteLine(cities2[0]);



BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism = çok biçimlilik
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}



