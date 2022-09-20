using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Svg;
using DevExpress.Utils.Extensions;
using Newtonsoft.Json;
using PokeAPI.Forms;

namespace PokeAPI
{
    internal class ApiPokemon
    {
        public static List<DadosPokemon> listaDadosPokemons1 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons2 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons3 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons4 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons5 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons6 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons7 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons8 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons9 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons10 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons11 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons12 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons13 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons14 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons15 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons16 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons17 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons18 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons19 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons20 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons21 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons22 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons23 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons24 = new List<DadosPokemon>();
        public static List<DadosPokemon> listaDadosPokemons25 = new List<DadosPokemon>();

        public static List<string> nomesPokemon = new List<string>();

        private Pokemon nomePokemon = new Pokemon();

        private Pokemon listaPokemon = new Pokemon();

        public async Task Thread1()
        {
            try
            {
                for (int _indice = 1; _indice <= 35; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons1.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread2()
        {
            try
            {
                for (int _indice = 36; _indice <= 70; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons2.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread3()
        {
            try
            {
                for (int _indice = 71; _indice <= 106; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons3.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread4()
        {
            try
            {
                for (int _indice = 107; _indice <= 141; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons4.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread5()
        {
            try
            {
                for (int _indice = 142; _indice <= 176; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons5.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread6()
        {
            try
            {
                for (int _indice = 177; _indice <= 212; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons6.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread7()
        {
            try
            {
                for (int _indice = 213; _indice <= 247; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons7.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread8()
        {
            try
            {
                for (int _indice = 248; _indice <= 282; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons8.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread9()
        {
            try
            {
                for (int _indice = 283; _indice <= 318; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons9.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread10()
        {
            try
            {
                for (int _indice = 319; _indice <= 353; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons10.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread11()
        {
            try
            {
                for (int _indice = 354; _indice <= 388; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons11.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread12()
        {
            try
            {
                for (int _indice = 389; _indice <= 423; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons12.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread13()
        {
            try
            {
                for (int _indice = 424; _indice <= 458; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons13.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread14()
        {
            try
            {
                for (int _indice = 459; _indice <= 493; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons14.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread15()
        {
            try
            {
                for (int _indice = 494; _indice <= 528; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons15.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread16()
        {
            try
            {
                for (int _indice = 529; _indice <= 563; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons16.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread17()
        {
            try
            {
                for (int _indice = 564; _indice <= 598; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons17.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread18()
        {
            try
            {
                for (int _indice = 599; _indice <= 633; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons18.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread19()
        {
            try
            {
                for (int _indice = 634; _indice <= 668; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);
                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons19.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                        pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                        valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread20()
        {
            try
            {
                for (int _indice = 669; _indice <= 703; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons20.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                    pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                    valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread21()
        {
            try
            {
                for (int _indice = 704; _indice <= 738; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons21.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                    pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                    valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread22()
        {
            try
            {
                for (int _indice = 739; _indice <= 773; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons22.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                    pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                    valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread23()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int _indice = 774; _indice <= 810; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons23.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                    pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                    valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread24()
        {
            try
            {
                for (int _indice = 811; _indice <= 855; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons24.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                    pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                    valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task Thread25()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int _indice = 856; _indice <= 898; _indice++)
                {
                    HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/") };
                    var response = cliente.GetAsync($"{_indice}");
                    var content = response.Result.Content.ReadAsStringAsync();

                    Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(content.Result);

                    string categoria = string.Empty;

                    foreach (var item in pokemon.Abilities)
                    {
                        categoria = item.ability.name;

                        break;
                    }

                    string[] tipoPokemon = new string[3];
                    int indiceTipo = 0;

                    pokemon.Types.ForEach(item =>
                    {
                        tipoPokemon[indiceTipo] = item.Type.name;

                        indiceTipo++;
                    });

                    int indiceHabilidade = 0;

                    int[] valoresHabilidade = new int[6];

                    pokemon.Stats.ForEach(item =>
                    {
                        valoresHabilidade[indiceHabilidade] = item.base_stat;

                        indiceHabilidade++;
                    });

                    listaDadosPokemons25.Add(new DadosPokemon(_indice, tipoPokemon[0], tipoPokemon[1], pokemon.Sprites.front_default, pokemon.Name,
                    pokemon.Height, pokemon.Weight, categoria, valoresHabilidade[0], valoresHabilidade[1], valoresHabilidade[2],
                    valoresHabilidade[3], valoresHabilidade[4], valoresHabilidade[5]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private string linkEvolucao = string.Empty;

        public async Task BuscarLinkEvolucao(int _indice)
        {
            try
            {
                HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon-species/") };
                var response = cliente.GetAsync($"{_indice}");
                var content = response.Result.Content.ReadAsStringAsync();

                Root pokemon = JsonConvert.DeserializeObject<Root>(content.Result);

                linkEvolucao = pokemon.evolution_chain.url;

                BuscarImagemEvolucao();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public async Task BuscarImagemEvolucao()
        {
            try
            {
                HttpClient cliente = new HttpClient { BaseAddress = new Uri($"{linkEvolucao}") };
                var response = cliente.GetAsync(String.Empty);
                var content = response.Result.Content.ReadAsStringAsync();

                Root pokemon = JsonConvert.DeserializeObject<Root>(content.Result);

                nomesPokemon.Clear();

                nomesPokemon.Add(pokemon.chain.species.name);

                PegarEspecies(pokemon.chain.evolves_to);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void PegarEspecies(List<EvolvesTo> _evolucaoLoopAtual)
        {
            foreach (var item in _evolucaoLoopAtual)
            {
                nomesPokemon.Add(item.species.name);

                if (item.evolves_to.Count > 0)
                {
                    PegarEspecies(_evolucaoLoopAtual[0].evolves_to);
                }
                else
                {
                    break;
                }
            }
        }
    }

    public class Pokemon
    {
        public Ability[] Abilities { get; set; }
        public long Height { get; set; }
        public string Name { get; set; }
        public Sprites Sprites { get; set; }
        public Stat[] Stats { get; set; }
        public TypeElement[] Types { get; set; }
        public long Weight { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
    }

    public class Sprites
    {
        public string front_default { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
    }

    public class EvolutionChain
    {
        public string url { get; set; }
    }

    public class TypeElement
    {
        public Species Type { get; set; }
    }

    public class Ability
    {
        public Ability2 ability { get; set; }
    }

    public class Ability2
    {
        public string name { get; set; }
    }

    public class Chain
    {
        public List<EvolvesTo> evolves_to { get; set; }
        public Species species { get; set; }
    }

    public class EvolvesTo
    {
        public List<EvolvesTo> evolves_to { get; set; }
        public Species species { get; set; }
    }

    public class Root
    {
        public Chain chain { get; set; }
        public EvolutionChain evolution_chain { get; set; }
    }
}