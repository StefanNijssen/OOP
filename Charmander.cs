class Pokemon{
    public Pokemon(String name, String strength, String Weakness) {
        this.name = name;
        this.strength = strength;
        this.Weakness = Weakness;
        }

    public void battleCry() {
        Console.WriteLine("name" + "!!!");
        }
}

Pokemon anotherOne= new Pokemon("Charmander", "fire", "Water");
