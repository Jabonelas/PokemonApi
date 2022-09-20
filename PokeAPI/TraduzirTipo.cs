using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
    public static class TraduzirTipo
    {
        public static string TraduzirTipoPokemon(string _tipoPokemon)
        {
            switch (_tipoPokemon)
            {
                case "water":
                    return " ÁGUA ";

                case "poison":
                    return " VENENO ";

                case "ground":
                    return " TERRA ";

                case "rock":
                    return " PEDRA ";

                case "normal":
                    return " NORMAL ";

                case "grass":
                    return " GRAMA ";

                case "fighting":
                    return " LUTADOR ";

                case "fairy":
                    return " FADA ";

                case "electric":
                    return " ELÉTRICO ";

                case "dark":
                    return " SOMBRIO ";

                case "fire":
                    return " FOGO ";

                case "ghost":
                    return " FANTASMA ";

                case "bug":
                    return " INSETO ";

                case "dragon":
                    return " DRAGÃO ";

                case "flying":
                    return " VOADOR ";

                case "psychic":
                    return " PSÍQUICO ";

                case "ice":
                    return " GELO ";

                case "steel":
                    return " FERRO ";
            }

            return "";
        }
    }
}