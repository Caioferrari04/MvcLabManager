using System.ComponentModel.DataAnnotations;

namespace MvcLabManager.Models;

public class Lab 
{
    public Lab()
    {
        ID = 0;
        Name = "";
        Block = "";
        Number = 0;
    }

    public Lab(int id, string name, string block, int number)
    {
        ID = id;
        Name = name;
        Block = block;
        Number = number;
    }

    public int ID { get; set; }
    [Display(Name = "Nome")]
    public string Name { get; set; }
    [Display(Name = "Bloco")]
    public string Block { get; set; }
    [Display(Name = "Número")]
    public int Number { get; set; }
}