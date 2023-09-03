namespace HelloWorld;

public struct PersonInfo
{
    public string name;
    public string job;
}
public class Person
{
    public string name { get; set; } = string.Empty;
    public string job { get; set; } = string.Empty;

    public PersonInfo showName()
    {
        return new PersonInfo
        {
            name = this.name,
            job = this.job
        };
    }
}