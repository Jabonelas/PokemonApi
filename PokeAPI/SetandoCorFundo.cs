using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
    public static class SetandoCorFundo
    {
        public static Color setandoCorFundo(string _tipoPokemon)
        {
            switch (_tipoPokemon)
            {
                case "water":
                    return Color.FromArgb(0, 79, 202);

                case "poison":
                    return Color.FromArgb(225, 83, 127);

                case "ground":
                    return Color.FromArgb(240, 164, 33);

                case "rock":
                    return Color.FromArgb(169, 151, 122);

                case "normal":
                    return Color.FromArgb(115, 123, 131);

                case "grass":
                    return Color.FromArgb(0, 204, 21);

                case "fighting":
                    return Color.FromArgb(193, 72, 0);

                case "fairy":
                    return Color.FromArgb(225, 65, 167);

                case "electric":
                    return Color.FromArgb(255, 236, 14);

                case "dark":
                    return Color.FromArgb(41, 63, 95);

                case "fire":
                    return Color.FromArgb(240, 68, 52);

                case "ghost":
                    return Color.FromArgb(86, 0, 0);

                case "bug":
                    return Color.FromArgb(68, 191, 107);

                case "dragon":
                    return Color.FromArgb(231, 197, 70);

                case "flying":
                    return Color.FromArgb(34, 220, 233);

                case "psychic":
                    return Color.FromArgb(112, 0, 190);

                case "ice":
                    return Color.FromArgb(119, 237, 255);

                case "steel":
                    return Color.FromArgb(113, 130, 137);
            }

            return Color.Transparent;
        }
    }
}