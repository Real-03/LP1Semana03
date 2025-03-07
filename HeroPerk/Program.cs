using System;

namespace HeroPerk
{
    public class Program
    {
        [Flags]
        enum Perks
        {
            None = 0,
            WarpShift = 1 << 0,  // w
            Stealth = 1 << 1,    // s
            AutoHeal = 1 << 2,   // a
            DoubleJump = 1 << 3  // d
        }

        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("!Unknown perk!");
                return;
            }

            string input = args[0];
            Perks perks = Perks.None;

            int wCount = 0, aCount = 0, sCount = 0, dCount = 0;

            // Contar quantas vezes cada perk aparece
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w': wCount++; break;
                    case 'a': aCount++; break;
                    case 's': sCount++; break;
                    case 'd': dCount++; break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }

            // Ativar perks se aparecerem um número ímpar de vezes
            if (wCount % 2 != 0) perks |= Perks.WarpShift;
            if (aCount % 2 != 0) perks |= Perks.AutoHeal;
            if (sCount % 2 != 0) perks |= Perks.Stealth;
            if (dCount % 2 != 0) perks |= Perks.DoubleJump;

            // Exibir perks
            if (perks == Perks.None)
            {
                Console.WriteLine("!No perks at all!");
            }
            else
            {
                Console.WriteLine(perks);
            }

            // Mensagens especiais
            if ((perks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }

            if ((perks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}
