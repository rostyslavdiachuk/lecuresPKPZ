namespace lecture2025;

public record struct group(string name)
{
    
}

public class Group
{
    private string name;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Group(string name)
    {
        this.name = name;
    }
}