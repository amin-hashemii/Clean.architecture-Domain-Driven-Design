// See https://aka.ms/new-console-template for more information

using clean_arch_Domain.Shared;
using clean_arch_Domain.User;
using clean_arch_Domain.User.ValueObject;

var money = Money.fromToman(12000);
var money2 = Money.fromToman(12000);
var money3 = money + money2;
Console.WriteLine(money3.ToString());
Console.WriteLine(money==money2);



var user = new User("amin", "hashemi", new PhoneBook(new PhoneNumber("09196836439"), new PhoneNumber("09196836439")));
var user2 = new User("amin", "hashemi", new PhoneBook(new PhoneNumber("09196836432"), new PhoneNumber("09196836432")));

Console.WriteLine(user==user2);