// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

PttManager pttManager = new PttManager(new PersonManager());

//Vatandas vatandas = new Vatandas();
Person person1 = new Person();
person1.FirstName = "Mehmet Said";
person1.LastName = "Özsoy";
person1.DateOfBirthYear = 1980;
person1.NationalIdentity = 30935387884;
pttManager.GiveMask(person1);
