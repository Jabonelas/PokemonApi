using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeAPI.Forms
{
    public partial class Forms_TelaCarregamento : DevExpress.XtraEditors.XtraForm
    {
        private ApiPokemon Api = new ApiPokemon();

        public Forms_TelaCarregamento()
        {
            InitializeComponent();

            var tarefa = Task.Run(() =>
           {
               Chamar();
           });

            var esperador = tarefa.GetAwaiter();
            esperador.OnCompleted(() =>
            {
                AbrirTelaInicial();
            });
        }

        private async Task Chamar()
        {
            await Carregando();
        }

        private async Task Carregando()
        {
            var tarefa1 = Task.Run(async () =>
            {
                await Api.Thread1();
            });

            var tarefa2 = Task.Run(async () =>
            {
                await Api.Thread2();
            });

            var tarefa3 = Task.Run(async () =>
            {
                await Api.Thread3();
            });

            var tarefa4 = Task.Run(async () =>
            {
                await Api.Thread4();
            });

            var tarefa5 = Task.Run(async () =>
            {
                await Api.Thread5();
            });

            var tarefa6 = Task.Run(async () =>
            {
                await Api.Thread6();
            });

            var tarefa7 = Task.Run(async () =>
            {
                await Api.Thread7();
            });

            var tarefa8 = Task.Run(async () =>
            {
                await Api.Thread8();
            });

            var tarefa9 = Task.Run(async () =>
            {
                await Api.Thread9();
            });

            var tarefa10 = Task.Run(async () =>
            {
                await Api.Thread10();
            });

            var tarefa11 = Task.Run(async () =>
            {
                await Api.Thread11();
            });
            var tarefa12 = Task.Run(async () =>
            {
                await Api.Thread12();
            });
            var tarefa13 = Task.Run(async () =>
            {
                await Api.Thread13();
            });
            var tarefa14 = Task.Run(async () =>
            {
                await Api.Thread14();
            });
            var tarefa15 = Task.Run(async () =>
            {
                await Api.Thread15();
            });
            var tarefa16 = Task.Run(async () =>
            {
                await Api.Thread16();
            });
            var tarefa17 = Task.Run(async () =>
            {
                await Api.Thread17();
            });
            var tarefa18 = Task.Run(async () =>
            {
                await Api.Thread18();
            });
            var tarefa19 = Task.Run(async () =>
            {
                await Api.Thread19();
            });
            var tarefa20 = Task.Run(async () =>
            {
                await Api.Thread20();
            });

            var tarefa21 = Task.Run(async () =>
            {
                await Api.Thread21();
            }); var tarefa22 = Task.Run(async () =>
            {
                await Api.Thread22();
            }); var tarefa23 = Task.Run(async () =>
            {
                await Api.Thread23();
            }); var tarefa24 = Task.Run(async () =>
            {
                await Api.Thread24();
            }); var tarefa25 = Task.Run(async () =>
            {
                await Api.Thread25();
            });

            Task.WaitAll(tarefa1, tarefa2, tarefa3, tarefa4, tarefa5, tarefa6, tarefa7, tarefa8, tarefa9, tarefa10, tarefa11, tarefa12,
            tarefa13, tarefa14, tarefa15, tarefa16, tarefa17, tarefa18, tarefa19, tarefa20, tarefa21, tarefa22, tarefa23, tarefa24, tarefa25);
        }

        private void AbrirTelaInicial()
        {
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons2);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons3);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons4);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons5);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons6);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons7);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons8);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons9);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons10);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons11);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons12);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons13);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons14);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons15);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons16);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons17);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons18);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons19);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons20);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons21);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons22);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons23);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons24);
            ApiPokemon.listaDadosPokemons1.AddRange(ApiPokemon.listaDadosPokemons25);

            this.Hide();
            Forms_TelaInicial telaInicial = new Forms_TelaInicial();
            telaInicial.ShowDialog();
        }
    }
}