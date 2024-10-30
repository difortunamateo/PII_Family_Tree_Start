namespace Library;

public class OldestChildVisitor : Visitor<Person>
{
    private int maxAge = 0;

    public override void Visit(Node<Person> node)
    {
        // Si el nodo es hoja (sin hijos) y su edad es mayor a la edad máxima encontrada
        if (node.Children.Count == 0 && node.Value.Age > maxAge)
        {
            maxAge = node.Value.Age;
        }
    }

    public int GetOldestChildAge()
    {
        return maxAge;
    }
}