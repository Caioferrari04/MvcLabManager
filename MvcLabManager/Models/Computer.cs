namespace MvcLabManager.Models;

public class Computer 
{
    public Computer() 
    {
        Id = 0;
        Ram = "";
        Processor = "";
    }

    public Computer(int id, string ram, string processor)
    {
        Id = id;
        Ram = ram;
        Processor = processor;
    }   

    public int Id { get; set; }
    public string Ram { get; set; }
    public string Processor { get; set; }
}