using System.Text;

namespace Library;

public abstract class Visitor<T>
{
    public string Content
    {
        get { return this.ContentBuilder.ToString(); }
    }

    protected StringBuilder ContentBuilder { get; } = new StringBuilder();

    public abstract void Visit(Node<T> node);
}