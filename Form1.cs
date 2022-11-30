//Jogo da velha feito no Windows Forms do Visual Studio!

//Tutorial do site: http://comocriarosjogos.blogspot.com/2017/07/jogo-da-velha-em-c-com-inteligencia.html

//O projeto foi feito pelo Visual Studio 2019 e passei para o VS Code para postar aqui no git! 

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {

        bool vez, button_disable;
        int x_vitoria, o_vitoria, empate = 0, rodadas = 0, vencedor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Ofencivo()
        {
            if(vez == true)
            {
                for (int i = 1; i <= 17; i++)
                {
                    if (i == 17 && vez == true)
                    {
                        Defencivo();
                    }

                    if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && vez == true || button6.Text == "O" && button9.Text == "O" && button3.Text == "" && vez == true)
                    {
                        button3.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && vez == true || button5.Text == "O" && button8.Text == "O" && button2.Text == "" && vez == true)
                    {
                        button2.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && vez == true || button4.Text == "O" && button7.Text == "O" && button1.Text == "" && vez == true)
                    {
                        button1.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && vez == true || button3.Text == "O" && button9.Text == "O" && button6.Text == "" && vez == true)
                    {
                        button6.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && vez == true || button2.Text == "O" && button8.Text == "O" && button5.Text == ""&& vez == true )
                    {
                        button5.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && vez == true || button1.Text == "O" && button7.Text == "O" && button4.Text == ""&& vez == true )
                    {
                        button4.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && vez == true || button3.Text == "O" && button6.Text == "O" && button9.Text == ""&& vez == true )
                    {
                        button9.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && vez == true || button2.Text == "O" && button5.Text == "O" && button8.Text == ""&& vez == true )
                    {
                        button8.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && vez == true || button1.Text == "O" && button4.Text == "O" && button7.Text == ""&& vez == true )
                    {
                        button7.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button2.Text == "O" && button4.Text == "O" && button8.Text == "" && vez == true)
                    {
                        button8.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button4.Text == "O" && button8.Text == "O" && button2.Text == ""&& vez == true )
                    {
                        button2.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button1.Text == "O" && button5.Text == "O" && button9.Text == ""&& vez == true )
                    {
                        button9.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button3.Text == "O" && button5.Text == "O" && button7.Text == ""&& vez == true )
                    {
                        button7.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button5.Text == "O" && button9.Text == "O" && button1.Text == ""&& vez == true )
                    {
                        button1.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button7.Text == "O" && button5.Text == "O" && button3.Text == ""&& vez == true )
                    {
                        button3.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && vez == true || button3.Text == "O" && button7.Text == "O" && button5.Text == ""&& vez == true )
                    {
                        button5.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }
                }
            }
            
        }
        
        private void Defencivo()
        {
            if (vez == true)
            {
                for (int r = 1; r <= 17; r++)
                {
                    if (r == 17 && vez == true)
                    {
                        Randomico();
                    }

                    if (button1.Text == "X" && button2.Text == "X" && button3.Text == "" && vez == true || button6.Text == "X" && button9.Text == "X" && button3.Text == ""&& vez == true )
                    {
                        button3.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button1.Text == "X" && button3.Text == "X" && button2.Text == "" && vez == true || button5.Text == "X" && button8.Text == "X" && button2.Text == ""&& vez == true )
                    {
                        button2.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button2.Text == "X" && button3.Text == "X" && button1.Text == "" && vez == true || button4.Text == "X" && button7.Text == "X" && button1.Text == ""&& vez == true )
                    {
                        button1.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button4.Text == "X" && button5.Text == "X" && button6.Text == "" && vez == true || button3.Text == "X" && button9.Text == "X" && button6.Text == ""&& vez == true )
                    {
                        button6.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button4.Text == "X" && button6.Text == "X" && button5.Text == "" && vez == true || button2.Text == "X" && button8.Text == "X" && button5.Text == ""&& vez == true )
                    {
                        button5.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button5.Text == "X" && button6.Text == "X" && button4.Text == "" && vez == true || button1.Text == "X" && button7.Text == "X" && button4.Text == ""&& vez == true )
                    {
                        button4.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button7.Text == "X" && button8.Text == "X" && button9.Text == "" && vez == true || button3.Text == "X" && button6.Text == "X" && button9.Text == ""&& vez == true )
                    {
                        button9.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button7.Text == "X" && button9.Text == "X" && button8.Text == "" && vez == true || button2.Text == "X" && button5.Text == "X" && button8.Text == ""&& vez == true )
                    {
                        button8.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button8.Text == "X" && button9.Text == "X" && button7.Text == "" && vez == true || button1.Text == "X" && button4.Text == "X" && button7.Text == ""&& vez == true )
                    {
                        button7.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button2.Text == "X" && button4.Text == "X" && button8.Text == "" && vez == true)
                    {
                        button8.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button4.Text == "X" && button8.Text == "X" && button2.Text == ""&& vez == true )
                    {
                        button2.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button1.Text == "X" && button5.Text == "X" && button9.Text == ""&& vez == true )
                    {
                        button9.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button3.Text == "X" && button5.Text == "X" && button7.Text == ""&& vez == true )
                    {
                        button7.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button5.Text == "X" && button9.Text == "X" && button1.Text == ""&& vez == true )
                    {
                        button1.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button7.Text == "X" && button5.Text == "X" && button3.Text == ""&& vez == true )
                    {
                        button3.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }

                    if (button1.Text == "X" && button9.Text == "X" && button5.Text == "" && vez == true || button3.Text == "X" && button7.Text == "X" && button5.Text == ""&& vez == true )
                    {
                        button5.Text = "O";
                        rodadas++;
                        vez = false;
                        ChecarVencedor();
                    }
                }
            }
                
        }

        private void Randomico()
        {
            bool looping = false;

            if(vez == true)
            {
                looping = true;
            }

            while (looping != false)
            {
                Random random = new Random();
                int randomizar = random.Next(1, 9);

                switch (randomizar)
                {
                    case 1:
                        if(button1.Text == "" && vez == true)
                        {
                            button1.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                    case 2:
                        if (button2.Text == "" && vez == true)
                        {
                            button2.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                    case 3:
                        if (button3.Text == "" && vez == true)
                        {
                            button3.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                    case 4:
                        if (button4.Text == "" && vez == true)
                        {
                            button4.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                    case 5:
                        if (button5.Text == "" && vez == true)
                        {
                            button5.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                    case 6:
                        if (button6.Text == "" && vez == true)
                        {
                            button6.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                    case 7:
                        if (button7.Text == "" && vez == true)
                        {
                            button7.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                    case 8:
                        if (button8.Text == "" && vez == true)
                        {
                            button8.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                    case 9:
                        if (button9.Text == "" && vez == true)
                        {
                            button9.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            ChecarVencedor();
                        }
                        break;
                }
            }
        }

        private void Havencedor()
        {
            if(vencedor == 1)
            {
                x_vitoria++;
                label4.Text = Convert.ToString(x_vitoria);
                MessageBox.Show("Você ganhou!");
                button_disable = true;
            }else if(vencedor == 2)
            {
                o_vitoria++;
                label5.Text = Convert.ToString(o_vitoria);
                MessageBox.Show("O computador ganhou!");
                button_disable = true;
            }
        }

        public void ChecarVencedor()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                vencedor = 1;
                Havencedor();

            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                vencedor = 1;
                Havencedor();

            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                vencedor = 1;
                Havencedor();

            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                vencedor = 1;
                Havencedor();

            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                vencedor = 1;
                Havencedor();

            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                vencedor = 1;
                Havencedor();

            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                vencedor = 1;
                Havencedor();

            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                vencedor = 1;
                Havencedor();

            }

            // Player 2

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {

                vencedor = 2;
                Havencedor();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                vencedor = 2;
                Havencedor();

            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                vencedor = 2;
                Havencedor();

            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                vencedor = 2;
                Havencedor();

            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                vencedor = 2;
                Havencedor();

            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                vencedor = 2;
                Havencedor();

            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                vencedor = 2;
                Havencedor();

            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                vencedor = 2;
                Havencedor();

            }

            if (rodadas == 9 && vencedor == 0)
            {
                MessageBox.Show("Empate");
                empate++;
                label6.Text = Convert.ToString(empate);
                button_disable = true;
            }

            if (vez == true && vencedor == 0 && rodadas != 9)
            {
                Ofencivo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button1.Text == "")
            {
                button1.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button2.Text == "")
            {
                button2.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button3.Text == "")
            {
                button3.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button4.Text == "")
            {
                button4.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button5.Text == "")
            {
                button5.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }

        private void Limpar_Click_1(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            rodadas = 0;
            button_disable = false;
            if (vencedor == 1 || vencedor == 0)
            {
                vez = false;
                vencedor = 0;
            }
            else
            {
                vez = true;
                vencedor = 0;
                ChecarVencedor();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button6.Text == "")
            {
                button6.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button7.Text == "")
            {
                button7.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button8.Text == "")
            {
                button8.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false & button9.Text == "")
            {
                button9.Text = "X";
                rodadas++;
                vez = true;
                ChecarVencedor();
            }
        }


        private void Limpar_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            rodadas = 0;
            button_disable = false;
            if(vencedor == 1 || vencedor == 0)
            {
                vez = false;
                vencedor = 0;
            }else
            {
                vez = true;
                vencedor = 0;
                ChecarVencedor();
            }
        }
    }
}
