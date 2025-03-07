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
            //Passa por todos os argumentos introduzidos pelo utilizador
            for (int i = 1; i < args.Length; i++)
            {
                //Verifica qual o tipo de gear
                switch (args[i])
                {
                    
                    case "Helmet":
                        //Ativa o Helmet do playergear
                        playerGear |= PlayerGear.Helmet;
                        break;
                    case "Boots":
                        //Ativa o Boots do playergear
                        playerGear |= PlayerGear.Boots;
                        break;
                    case "Shield":
                        //Ativa o Shield do playergear
                        playerGear |= PlayerGear.Shield;
                        break;
                }
            }

        //Retorna a gear do player
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
            //Switch para verificar qual o tipo de Trap é
            switch (trap)
            {
                case TrapType.FallingRocks:
                //Verifica se o player tem Helmet se tiver retorna true se nao retorna false
                    if ((PlayerGear.Helmet & gear) == PlayerGear.Helmet)
                        return true;
                    else
                        return false;
                case TrapType.SpinningBlades:
                //Verifica se o player tem Shield se tiver retorna true se nao retorna false
                    if ((PlayerGear.Shield & gear) == PlayerGear.Shield)
                        return true;
                    else
                        return false;
                case TrapType.PoisonGas:
                    //Verifica se o player tem Helmet e Shield se tiver retorna true se nao retorna false
                    if ((PlayerGear.Helmet & gear) == PlayerGear.Helmet && (PlayerGear.Shield & gear) == PlayerGear.Shield)
                        return true;
                    else
                        return false;

                case TrapType.LavaPit:
                //Verifica se o player tem Boots se tiver retorna true se nao retorna false
                    if ((PlayerGear.Boots & gear) == PlayerGear.Boots)
                        return true;
                    else
                        return false;
                default:
                //Retorna o valor false por default
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
