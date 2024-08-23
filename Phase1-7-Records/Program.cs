Sword basic = new Sword(Material.Iron, Gemstone.None, 50, 15);
Sword premium = basic with { MType = Material.Steel, GType = Gemstone.Sapphire };
Sword classic = basic with { MType = Material.Binarium, GType = Gemstone.Bitstone, Length = 75, CWidth = 25 };

Console.WriteLine(basic);
Console.WriteLine(premium);
Console.WriteLine(classic);

Console.ReadLine();

public record Sword(Material MType, Gemstone GType, double Length, double CWidth);

public enum Material { Wood, Bronze, Iron, Steel, Binarium }
public enum Gemstone { Emerald, Amber, Sapphire, Diamond, Bitstone, None }