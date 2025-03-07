using System;

namespace TrapAnalyzer
{

    public class Program
    {
        [Flags]
        public enum PlayerGear
        {
            None = 0,
            Helmet = 1,
            Shield = 2,
            Boots = 4,
        }
        public enum TrapType
        {
            FallingRocks,
            SpinningBlades,
            PoisonGas,
            LavaPit
        }
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            PlayerGear playerGear = PlayerGear.None;

            for (int i = 1; i < args.Length; i++)
            {

                switch (args[i])
                {
                    case "Helmet":
                        playerGear |= PlayerGear.Helmet;
                        break;
                    case "Boots":
                        playerGear |= PlayerGear.Boots;
                        break;
                    case "Shield":
                        playerGear |= PlayerGear.Shield;
                        break;
                }
            }


            return playerGear;

        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {

            switch (trap)
            {
                case TrapType.FallingRocks:
                    if ((PlayerGear.Helmet & gear) == PlayerGear.Helmet)
                        return true;
                    else
                        return false;
                case TrapType.SpinningBlades:
                    if ((PlayerGear.Shield & gear) == PlayerGear.Shield)
                        return true;
                    else
                        return false;
                case TrapType.PoisonGas:
                    if ((PlayerGear.Helmet & gear) == PlayerGear.Helmet && (PlayerGear.Shield & gear) == PlayerGear.Shield)
                        return true;
                    else
                        return false;

                case TrapType.LavaPit:
                    if ((PlayerGear.Boots & gear) == PlayerGear.Boots)
                        return true;
                    else
                        return false;
                default:
                    return false;
            }

        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {
            if (survives)
                Console.WriteLine("Player survives " + trap);
            else
                Console.WriteLine("Player dies due to " + trap);

        }
    }
}
