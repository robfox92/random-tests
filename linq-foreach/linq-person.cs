using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public int _Height;
    public DateTime _DOB;
    public string _Name;

    public Person(int Height, DateTime DOB, string Name)
    {
        _DOB = DOB;
        _Height = Height;
        _Name = Name;
    }

    public override string ToString()
    {
        return $"Name: {this._Name}; Height: {this._Height}; Date of Birth: {this._DOB}";
    }

}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();
        people.Add(new Person(180, new DateTime(1992,7,6),  "Red"));
        people.Add(new Person(163, new DateTime(1993,7,15), "Magenta"));
        people.Add(new Person(180, new DateTime(1992,4,20), "Green"));
        people.Add(new Person(195, new DateTime(1993,2,10), "Pink"));

        List<Person> tall = (List<Person>)people.Where(p => p._Height >= 180);

    }
}