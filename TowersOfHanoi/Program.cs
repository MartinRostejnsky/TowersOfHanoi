using TowersOfHanoi;
using System;

int discs = 6;

Game toh = new Game(discs);

if (discs == 1)
{
    try { toh.Move(0, 2); } catch (Exception ex) { Console.WriteLine(ex); }
    Console.WriteLine(toh.ToString());
}else if (discs % 2 == 0) {
    while (!(toh.Towers[2].Count() == discs))
    {
        try { toh.Move(0, 1); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        try { toh.Move(0, 2); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        try { toh.Move(1, 2); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        Console.ReadLine();
    }
}
else
{
    while (!(toh.Towers[0].Count() == 0 & toh.Towers[2].Count() == discs))
    {

    }

}
