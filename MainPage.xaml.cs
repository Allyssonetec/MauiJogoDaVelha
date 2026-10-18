namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        String vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }


            // Verificando se o X ganhou na linha 1
            if (btn10.Text == "X" &&
                btn11.Text == "X" &&
                btn12.Text == "X")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O X ganhou!!", "OK");
                Zerar();
            }
            // Verificando se o X ganhou na linha 2
            else if (btn20.Text == "X" &&
                     btn21.Text == "X" &&
                     btn22.Text == "X")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O X ganhou!!", "OK");
                Zerar();
            }
            // Verificando se o X ganhou na linha 3
            else if (btn30.Text == "X" &&
                     btn31.Text == "X" &&
                     btn32.Text == "X")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O X ganhou!!", "OK");
                Zerar();
            }
            // Verificando se o O ganhou na linha 1
            else if (btn10.Text == "O" &&
                     btn11.Text == "O" &&
                     btn12.Text == "O")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O Bola ganhou!!", "OK");
                Zerar();
            }
            // Verificando se o O ganhou na linha 2
            else if (btn20.Text == "O" &&
                     btn21.Text == "O" &&
                     btn22.Text == "O")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O Bola ganhou!!", "OK");
                Zerar();
            }
            // Verificando se o O ganhou na linha 3
            else if (btn30.Text == "O" &&
                     btn31.Text == "O" &&
                     btn32.Text == "O")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O Bola ganhou!!", "OK");
                Zerar();
            }
            // Verificando se o X ganhou na Coluna 1
            else if (btn10.Text == "X" &&
                     btn20.Text == "X" &&
                     btn30.Text == "X")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O X ganhou!!", "OK");
                Zerar();
            }
            // Verificando se o X ganhou na Coluna 2
            else if (btn11.Text == "X" &&
                     btn21.Text == "X" &&
                     btn31.Text == "X")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O X ganhou!!", "OK");
                Zerar();
            }
            // Verificando se o X ganhou na Coluna 3
            else if (btn12.Text == "X" &&
                     btn22.Text == "X" &&
                     btn32.Text == "X")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O X ganhou!!", "OK");
                Zerar();
            }
            // Verificando se Bola ganhou na Coluna 1
            else if (btn10.Text == "O" &&
                     btn20.Text == "O" &&
                     btn30.Text == "O")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "A Bola ganhou!!", "OK");
                Zerar();
            }
            // Verificando se  Bola ganhou na Coluna 2
            else if (btn11.Text == "O" &&
                     btn21.Text == "O" &&
                     btn31.Text == "O")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "A Bola ganhou!!", "OK");
                Zerar();
            }
            // Verificando se Bola ganhou na Coluna 3
            else if (btn12.Text == "O" &&
                     btn22.Text == "O" &&
                     btn32.Text == "O")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "A Bola ganhou!!", "OK");
                Zerar();
            }
            // Verificando se X ganhou na Diagona 1
            else if (btn10.Text == "X" &&
                     btn21.Text == "X" &&
                     btn32.Text == "X")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O X ganhou!!", "OK");
                Zerar();
            }
            // Verificando se X  ganhou na Diagona 2
            else if (btn12.Text == "X" &&
                     btn21.Text == "X" &&
                     btn30.Text == "X")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "O X ganhou!!", "OK");
                Zerar();
            }
            // Verificando se Bola ganhou na Diagona 1
            else if (btn10.Text == "O" &&
                     btn21.Text == "O" &&
                     btn32.Text == "O")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "A Bola ganhou!!", "OK");
                Zerar();
            }
            // Verificando se Bola ganhou na Diagona 2
            else if (btn12.Text == "O" &&
                     btn21.Text == "O" &&
                     btn30.Text == "O")
            {
                await DisplayAlertAsync(
                    "Parabéns!", "A Bola ganhou!!", "OK");
                Zerar();
            }
            // Verificando se deu empate
            else if (btn10.Text != "" && btn11.Text != "" && btn12.Text != "" &&
                     btn20.Text != "" && btn21.Text != "" && btn22.Text != "" &&
                      btn30.Text != "" && btn31.Text != "" && btn32.Text != "")
            {
                await DisplayAlertAsync(
                    "Empate!!","","OK");
                Zerar();
            }

        }//Fecha metodo        
        void Zerar()
        { 
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }
    }//fecha classe
}//fecha  Namespace
