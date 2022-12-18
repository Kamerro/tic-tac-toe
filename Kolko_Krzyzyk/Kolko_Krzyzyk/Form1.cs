using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolko_Krzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kto_ma_ruch.Text = "O";
        }
        //jeżeli wartosc jest true, to ruch kółka
        //else ruch krzyżyka
        bool czyj_ruch = true;
        private void WstawZnak(object przycisk)
        {
            string napis = "";
            //Ustawiamy referencję na przycisk
            Button wcisnietyPrzycisk = (Button)przycisk;
            //na podstawie kogo jest ruch
            if (czyj_ruch == true)
            {
                wcisnietyPrzycisk.Text = "O";
                kto_ma_ruch.Text = "X";
            }
            else
            {
                wcisnietyPrzycisk.Text = "X";
                kto_ma_ruch.Text = "O";
            }
            wcisnietyPrzycisk.Enabled = false;
            bool czy_ktos_wygral = SprawdzCzyKtosWygral();

            if (czy_ktos_wygral == true)
            {
                if (czyj_ruch)
                {
                    napis = "Wygrało kółko";
                }
                else
                {
                    napis = "Wygrał krzyżyk";
                }

                DialogResult odp = MessageBox.Show(napis + ". Czy chcesz rozpocząć ponownie?", "Koniec", MessageBoxButtons.YesNo);
                if (odp == DialogResult.Yes)
                {
                    ResetPlanszy();
                }
                else
                    Koniec();


            }
            else
            {
                //sprawdzamy czy ktoś wygrał
                czyj_ruch = !czyj_ruch;
            }
        }
        private void ResetPlanszy()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            czyj_ruch = true;
            kto_ma_ruch.Text = "O";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void Koniec()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private bool SprawdzCzyKtosWygral()
        {
            // sprawdzanie wierszy
            //sprawdzamy warunek dla pierwszego wiersza
            if(button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                //zwracamy prawdę jeżeli pierwszy wiersz ma 3 kółka lub 3 krzyżyki
                return true;
            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                //zwracamy prawdę jeżeli pierwszy wiersz ma 3 kółka lub 3 krzyżyki
                return true;
            }

            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                //zwracamy prawdę jeżeli pierwszy wiersz ma 3 kółka lub 3 krzyżyki
                return true;
            }

            // sprawdzanie kolumn

            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                //zwracamy prawdę jeżeli pierwszy wiersz ma 3 kółka lub 3 krzyżyki
                return true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                //zwracamy prawdę jeżeli pierwszy wiersz ma 3 kółka lub 3 krzyżyki
                return true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                //zwracamy prawdę jeżeli pierwszy wiersz ma 3 kółka lub 3 krzyżyki
                return true;
            }

            //Przekątne
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                //zwracamy prawdę jeżeli pierwszy wiersz ma 3 kółka lub 3 krzyżyki
                return true;
            }

            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                //zwracamy prawdę jeżeli pierwszy wiersz ma 3 kółka lub 3 krzyżyki
                return true;
            }

            return false;
            // sprawdzanie skosów
        }

        //sendery
        private void button1_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
    }
}
