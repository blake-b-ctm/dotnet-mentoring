namespace ContosoPizza.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
    public string GetMenuDescription()
    {
        var menuDescription = $"$7.99 - {Name} Pizza";
        if (IsGlutenFree) {
            menuDescription += " (GF)";
        }
        return menuDescription;
    }
}