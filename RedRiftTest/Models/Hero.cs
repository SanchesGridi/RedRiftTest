namespace RedRiftTest.Models;

public class Hero
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Color { get; set; }
    public List<Reply>? Replies { get; set; }
}
