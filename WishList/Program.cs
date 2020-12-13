using System;
using System.Collections.Generic;
using System.IO;

namespace WishList
{
    class Program
    {
        class Person
        {
            string name;
            string wish;

            public Person(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }
            public string Name {get { return name; } }
            public string Wish { get { return wish; } }
        }
        class WishList
        {
            List <WishList> wishes;

            public WishList()
            {
                List<Person> lists = new List<Person>();
                wishes = lists;
            }
            public void PrintAllWishes()
            {
                System.Collections.IList list = wishes;
                for (int i = 0; i < list.Count; i++)
                {
                    Person wish = (Person)list[i];
                    Console.WriteLine(value: $"{Person.name} wants {Person.wish}");
                }
            }

            internal void AddWishesToList(string personName, string personWish)
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\mammu\samples";
            string fileName = @"WishList.txt";
            string fullFilePath = Path.Combine(filePath, fileName);
            string[] linesFromfile = File.ReadAllLines(fullFilePath);
            WishList myWishes = new WishList();

            foreach (string line in linesFromfile)
            {
                string[] tempArray = line.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);               
                string PersonName = tempArray[1];
                string PersonWish = tempArray[2];
                Console.WriteLine(WishList);
              
                myWishes.AddWishesToList(PersonName,PersonWish);
            }
        }
    }
}
