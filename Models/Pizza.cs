namespace ContosoPizza.Models;

public abstract class MenuItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Price { get; set; }
    public abstract string GetMenuDescription();
}

public class Pizza: MenuItem
{
    public Pizza(int id, string name, string price, bool isGlutenFree) {
        Id = id;
        Name = name;
        Price = price;
        IsGlutenFree = isGlutenFree;
    }
    public bool IsGlutenFree { get; set; }
    public override string GetMenuDescription()
    {
        var menuDescription = $"{Price} - {Name} Pizza";
        if (IsGlutenFree) {
            menuDescription += " (GF)";
        }
        return menuDescription;
    }
}