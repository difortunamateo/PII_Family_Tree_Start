namespace Library;

public class AgeNumVisitor : Visitor<Person>
{
    private int totalAge = 0;

    public override void Visit(Node<Person> person)
    {
        // Suma la edad del integrante actual al total
        if (person != null && person.Value != null)
        {
            totalAge += person.Value.Age;
        }
    }

    // Devuelve la suma total de las edades
    public int GetTotalAge()
    {
        return totalAge;
    }
}