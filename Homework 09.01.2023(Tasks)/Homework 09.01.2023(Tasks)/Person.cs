using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._01._2023_Tasks_
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }



        public List<Person> GetAllPersons()
        {

            List<Person> person = new List<Person>();



            Person person1 = new Person()
            {
                Name = "Konul",
                Surname = "Ibrahimova",
                Address = "Nefciler",
                Salary = 2000
            };

            Person person2 = new Person()
            {
                Name = "Eycahan",
                Surname = "Colcemenli",
                Address = "Bilinmir",
                Salary = 100
            };

            Person person3 = new Person()
            {
                Name = "Ferid",
                Surname = "Masinyeyen",
                Address = "Nesimi",
                Salary = 1500
            };

            Person person4 = new Person()
            {
                Name = "Cahangest",
                Surname = "Veteranli",
                Address = "Raboci",
                Salary = 2500
            };

            Person person5 = new Person()
            {
                Name = "Cavid",
                Surname = "Ismayilzade",
                Address = "Qurutepe",
                Salary = 10
            };

            person.Add(person1);
            person.Add(person2);
            person.Add(person3);
            person.Add(person4);
            person.Add(person5);

            return person;
        }


        public List<Person> GetPersonsSalary(Predicate<Person> func, List<Person> people)
        {
            var person1 = GetAllPersons();
            List<Person> person2 = new();
            foreach (var item in person1)
            {
                if (func(item))
                {
                    person2.Add(item);
                }

            }
            return person2;
        }

        
        public void FiltredBySalary()
        {
            var person1 = GetAllPersons();
            var result = GetPersonsSalary(m => m.Salary > 1000, person1);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address);

            }
        }
    }
}
