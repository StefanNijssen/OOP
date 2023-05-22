class Pokemon{
    public string name;
    public string strength;
    public string weakness;

    public Pokemon(String name, String strength, String Weakness) {
        this.name = name;
        this.strength = strength;
        this.Weakness = Weakness;
        }

    public void battleCry() {
        Console.WriteLine("name" + "!!!");
        }
}
public class Program
{
    public static void Main(string[] args)
    {
        Pokemon anotherOne = new Pokemon("Charmander", "fire", "Water");
        anotherOne.battleCry();
    }
}

