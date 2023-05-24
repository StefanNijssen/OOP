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

int replay = 0;
int a = 0;
while(replay=0){
    Console.WriteLine("Enter username:");
    string userName = Console.ReadLine();
    while(a<=10){
        battleCry();
        a++;
    }
    Console.WriteLine("Do you want to play again?");
    int replay = Console.ReadLine();
}
Console.WriteLine("Hello world!");