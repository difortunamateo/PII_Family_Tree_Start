namespace Library;

public class LongestNameVisitor : Visitor<Person>
{
    private string longestName = "";

    public override void Visit(Node<Person> node)
    {
        if (node.Value.Name.Length > longestName.Length)
        {
            longestName = node.Value.Name;
        }
    }

    public string GetLongestName()
    {
        return longestName;
    }
}