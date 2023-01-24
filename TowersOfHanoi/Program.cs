using TowersOfHanoi;
using System;

int discs = 4;

Game toh = new Game(discs);


if (discs % 2 == 0) {
    while (!(toh.TowerC == discs))
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
    while (!(toh.TowerC == discs))
    {
        try { toh.Move(0, 1); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        try { toh.Move(1, 2); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
        try { toh.Move(0, 2); } catch (Exception ex) { Console.WriteLine(ex); }
        Console.WriteLine(toh.ToString());
    }

}
