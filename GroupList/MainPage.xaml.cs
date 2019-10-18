using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GroupList
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Cria uma lista de telefones e adiciona 3 itens de teste para simular o retorno da API
            var listTel = new List<Telefone>();
            var tel1 = new Telefone() { ID = 1, Nome = "Marcel", TelNumero = "+55 (11) 98456-7767" };
            var tel2 = new Telefone() { ID = 2, Nome = "Fernanda", TelNumero = "+55 (11) 98555-1827" };
            var tel3 = new Telefone() { ID = 3, Nome = "Amaro", TelNumero = "+55 (11) 98530-2020" };
            listTel.Add(tel1);
            listTel.Add(tel2);
            listTel.Add(tel3);

            //Cria uma lista de e-mails e adiciona 3 itens de teste para simular o retorno da API de e-mail
            var listEmail = new List<Email>();
            var Email1 = new Email() { ID = 1, Nome = "Rodolfo", EmailCli = "rodolfo@hotmail.com" };
            var Email2 = new Email() { ID = 2, Nome = "Mariana", EmailCli = "mariana@gmail.com" };
            var Email3 = new Email() { ID = 3, Nome = "Rui", EmailCli = "rui@microsoft.com" };
            listEmail.Add(Email1);
            listEmail.Add(Email2);
            listEmail.Add(Email3);

            //Cria 2 sublistas com base na classe GruposLista para adicionar os valores a cada grupo
            var grupoListaTel = new GruposLista("Telefones");
            //adiciona os telefones que vieram da API para a 1a. lista
            foreach (var tel in listTel)
            {
                grupoListaTel.Add(tel);
            }
            var grupoListaEmail = new GruposLista("E-mails");
            //adiciona os e-mails a lista que será utilizada para este grupo.
            foreach (var email in listEmail)
            {
                grupoListaEmail.Add(email);
            }

            //cria a lista que será utilizada como ItemSource
            var Itens = new List<GruposLista>();

            Itens.Add(grupoListaTel);
            Itens.Add(grupoListaEmail);

            //Joga os ítens para a ListView
            lstView.ItemsSource = Itens;




        }
    }

    public class GruposLista : List<object>
    {
        public GruposLista(string tipo)
        {
            Tipo = tipo;
        }
        public string Tipo { get; set; }
    }
}
