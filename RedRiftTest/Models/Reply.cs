namespace RedRiftTest.Models;

public class Reply
{
    public Guid Id { get; set; }
    public uint Order { get; set; }
    public string? Text { get; set; }
    public Hero? Hero { get; set; }
}
