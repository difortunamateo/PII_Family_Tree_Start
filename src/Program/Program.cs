using Library;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Juan", 25);
            Person p2 = new Person("Pedro", 30);
            Person p3 = new Person("Maria", 35);
            Person p4 = new Person("Ana", 40);
            Person p5 = new Person("Luis", 45);
            Person p6 = new Person("Carlos", 50);
            Person p7 = new Person("Jose", 55);

            // Crear el árbol de `Node<Person>`
            Node<Person> rootPerson = new Node<Person>(p1);
            Node<Person> child1 = new Node<Person>(p2);
            Node<Person> child2 = new Node<Person>(p3);
            Node<Person> grandchild1 = new Node<Person>(p4);
            Node<Person> grandchild2 = new Node<Person>(p5);
            Node<Person> grandchild3 = new Node<Person>(p6);
            Node<Person> grandchild4 = new Node<Person>(p7);

            rootPerson.AddChildren(child1);
            rootPerson.AddChildren(child2);
            child1.AddChildren(grandchild1);
            child1.AddChildren(grandchild2);
            child2.AddChildren(grandchild3);
            child2.AddChildren(grandchild4);

            AgeNumVisitor ageSumVisitor = new AgeNumVisitor();
            rootPerson.Accept(ageSumVisitor);
            int totalAge = ageSumVisitor.GetTotalAge();
            Console.WriteLine($"La suma total de las edades es: {totalAge}");

            // 1. Determinar la edad del hijo más grande
            OldestChildVisitor oldestChildVisitor = new OldestChildVisitor();
            rootPerson.Accept(oldestChildVisitor);
            int oldestChildAge = oldestChildVisitor.GetOldestChildAge();
            Console.WriteLine($"La edad del hijo más grande es: {oldestChildAge}");

            // 2. Determinar el nombre más largo
            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            rootPerson.Accept(longestNameVisitor);
            string longestName = longestNameVisitor.GetLongestName();
            Console.WriteLine($"El nombre más largo es: {longestName}");
        }
    }
}