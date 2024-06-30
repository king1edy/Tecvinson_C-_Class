// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using Core.Entities;
using GenericsClass2;

Console.WriteLine("Hello, World!");
// Methods gives you the ability to reuse a code snippet

var userRepo = new Repository<User>();
var addressRepo = new Repository<Address>();

User user = new User()
{
    Id = 1,
    Name = "Godswill David C#",
    Email = "godswill.david@tecvinsonacademy.com",
    Password = "FakePassword01",
    PhoneNumber = "fakePhoneNumber",
};
Address address = new Address()
{
    Id = 1,
    StreetName = "No1 FakeStreet lake",
    PostalCode = "000334",
    City = "Ikeja",
    State = "Lagos"
};

userRepo.Add(user);
addressRepo.Add(address);
var userObj = userRepo.Get(0);

var userSerialized = await userRepo.SerializeClass(user);

Console.WriteLine(userObj);
Console.WriteLine(userSerialized);
Console.WriteLine(await addressRepo.SerializeClass(address));

//addressRepo.Get(address);
//addressRepo.SerializeClass(address);

double CalculateSum(double x, double y)
{
    return x + y;
}