using TowersOfHanoi;
using System;

int discs = 45;

Game toh = new Game(discs);


if (discs % 2 == 0) {
    while (!(toh.Towers[2].Count() == discs))
    {
        try { toh.Move(0, 1); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        try { toh.Move(0, 2); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        try { toh.Move(1, 2); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
    }
}
else
{
    try { toh.Move(0, 2); } catch (Exception ex) { Console.WriteLine(ex); }
    Console.WriteLine(toh.ToString());
    while (!(toh.Towers[0].Count() == 0 & toh.Towers[2].Count() == discs))
    {
        try { toh.Move(0, 1); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        try { toh.Move(1, 2); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        try { toh.Move(0, 2); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
    }

}
