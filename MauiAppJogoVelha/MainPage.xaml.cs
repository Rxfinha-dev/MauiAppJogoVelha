﻿namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";

        public MainPage()
        { 
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if (vez=="O" ) 
            {
                disparador.Text = "O";
                vez = "x";
            }else
            {
                disparador.Text="X";
                vez = "O"; 
            }//Fecha Estrutura de Decisão

            

            
            //Lógica de ganhador O
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")//Colunas com vencedor O 
                {
                DisplayAlert("Você Ganhou","Parabéns","Fechar");
                limpar();
                 }
            else if(btn20.Text=="O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            //linhas com vencedor O
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            //diagonais com vencedor O
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }//Fecha lógica de ganhador O

            //Inicio Lógica de ganhador X
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")//Colunas com vencedor X
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();

            }
            else if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            else if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            //linhas com vencedor X
            else if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            else if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            else if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            //diagonais com vencedor X
            else if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }
            else if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Você Ganhou", "Parabéns", "Fechar");
                limpar();
            }//Fecha lógica de ganhador X
            //lógica de resultado velha
            else if(btn10.IsEnabled == false && btn11.IsEnabled == false &&btn12.IsEnabled == false &&
            btn20.IsEnabled == false &&
            btn21.IsEnabled == false &&
            btn22.IsEnabled == false &&
            btn30.IsEnabled == false &&
            btn31.IsEnabled == false &&
            btn32.IsEnabled == false)
            {
                DisplayAlert("Deu Velha", "Que Pena!", "Fechar");
                limpar();
            }




        }
        private void limpar() {
            btn10.Text = "";
            btn10.IsEnabled = true;
            btn11.Text = "";
            btn11.IsEnabled = true;
            btn12.Text = "";
            btn12.IsEnabled = true;
            btn20.Text = "";
            btn20.IsEnabled = true;
            btn21.Text = "";
            btn21.IsEnabled = true; 
            btn22.Text = "";
            btn22.IsEnabled = true;
            btn30.Text = "";
            btn30.IsEnabled = true;
            btn31.Text = "";
            btn31.IsEnabled = true;
            btn32.Text = "";
            btn32.IsEnabled = true;

        }
    }//fecha a class MainPage

}//fecha o namespace
