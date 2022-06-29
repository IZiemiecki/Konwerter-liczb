using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ziemiecki_42601_Projekt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iz_cmbPodstawaLiczby.SelectedIndex = 0;
            iz_cmbPodstawaWyjsciowa.SelectedIndex = 1;
        }

        private bool iz_CzyLiczbaZapisanaPoprawnie(string iz_strLiczbaWejsciowa, int iz_iPodstawaSystemu)
        {

            //sprawdzanie jest podzielone na 2 czesci, mianowicie na czesc gdzie poslugujemy sie jeszcze cyframi,
            //oraz na czesc w ktorej trzeba przejsc na tablice znakowe (niestety nie ascii a utf-16 :P)

            //sprowadzenie stringu do wielkich znakow, tak na wszelki wypadek
            iz_strLiczbaWejsciowa = iz_strLiczbaWejsciowa.ToUpper();

            //czesc dla cyfr start
            if (iz_iPodstawaSystemu < 10)
            {
                for (int i = 0; i < iz_strLiczbaWejsciowa.Length; i++)
                {
                    if (int.Parse(iz_strLiczbaWejsciowa[i].ToString()) >= iz_iPodstawaSystemu)
                        return false;
                }
                return true;
            }//koniec czesci dla cyfr
            else
            {//start czesci dla systemow o podstawie wiekszej niz 10
                //wtracenie: w UTF-16 liczba A jest 65 znakiem w tablicy (40 w ascii)

                for (int i = 0; i < iz_strLiczbaWejsciowa.Length; i++)
                {//sprawdzenie czy numer znaku [i] w tablicy UTF-16 jest wiekszy niz 65(a) + x,
                    //gdzie x to "nadmiar" systemu wzgledem systemu dziesiatkowego 
                    //mam nadzieje ze moje rozumowanie jest w miare klarowne :)
                    //generalnie DZIALA poki program dziala w systemie UTF-16
                    if ((int)iz_strLiczbaWejsciowa[i] >= (65 + (iz_iPodstawaSystemu - 10)))
                        return false;
                }
                return true;
            }
        }


        private void iz_btnKonwertuj_Click(object sender, EventArgs e)
        {
            string iz_strLiczbaKonwertowana, iz_strLiczbaSkonwertowana;
            int iz_iPdstKonwertowanej, iz_iPdstWyjsciowa,
                iz_iDlugoscLiczby, iz_L;

            switch (iz_cmbPodstawaLiczby.SelectedIndex)
            {
                case 0: iz_iPdstKonwertowanej = 2; break;
                case 1: iz_iPdstKonwertowanej = 3; break;
                case 2: iz_iPdstKonwertowanej = 5; break;
                case 3: iz_iPdstKonwertowanej = 8; break;
                case 4: iz_iPdstKonwertowanej = 10; break;
                case 5: iz_iPdstKonwertowanej = 16; break;
                case 6: iz_iPdstKonwertowanej = 30; break;
                default: iz_iPdstKonwertowanej = 10; break;
            }

            switch (iz_cmbPodstawaWyjsciowa.SelectedIndex)
            {
                case 0: iz_iPdstWyjsciowa = 2; break;
                case 1: iz_iPdstWyjsciowa = 3; break;
                case 2: iz_iPdstWyjsciowa = 5; break;
                case 3: iz_iPdstWyjsciowa = 8; break;
                case 4: iz_iPdstWyjsciowa = 10; break;
                case 5: iz_iPdstWyjsciowa = 16; break;
                case 6: iz_iPdstWyjsciowa = 30; break;
                default: iz_iPdstWyjsciowa = 10; break;
            }

            if (string.IsNullOrEmpty(iz_txtLiczba.Text))
            {
                errorProvider1.SetError(iz_txtLiczba, "ERROR: podaj liczbę konwertowaną!");
                return;
            }
            else
                errorProvider1.Dispose();

            //podstawienie wytrymowanego stringu
            iz_strLiczbaKonwertowana = iz_txtLiczba.Text.Trim();


            if (iz_CzyLiczbaZapisanaPoprawnie(iz_strLiczbaKonwertowana, iz_iPdstKonwertowanej) == false)
            {   //niepoprawnie zapisana
                errorProvider1.SetError(iz_txtLiczba, "ERROR: Wpisano liczbę niezgodną\nz powdanym systemem liczbowym!");
                return;
            }
            else
            {   //poprawnie - konwersja start
                errorProvider1.Dispose();
                iz_txtLiczba.Enabled = false;
                iz_cmbPodstawaLiczby.Enabled = false;
                iz_cmbPodstawaWyjsciowa.Enabled = false;

                char iz_Cyfra;
                iz_iDlugoscLiczby = iz_strLiczbaKonwertowana.Length;
                iz_L = 0;

                for (int iz_i = 0; iz_i < iz_iDlugoscLiczby; iz_i++)
                {
                    iz_Cyfra = iz_strLiczbaKonwertowana[iz_i];

                    if (iz_iPdstKonwertowanej <= 0)
                        iz_L = iz_iPdstKonwertowanej + (iz_Cyfra - '0');
                    else
                    {
                        if ((iz_Cyfra >= '0') && (iz_Cyfra <= '9'))
                            iz_L = iz_L * iz_iPdstKonwertowanej + (iz_Cyfra - '0');
                        else
                        {
                            iz_Cyfra = char.ToUpper(iz_Cyfra);
                            iz_L = iz_L * iz_iPdstKonwertowanej + ((iz_Cyfra - 'A') + 10);
                        }

                    }
                }

                char[] iz_ctTablicaCyfr = new char[50];
                int iz_iIndex = 0, iz_iWartoscCyfry = 0;

                while (iz_L > 0)
                {

                    if (iz_iPdstWyjsciowa <= 10)
                    {
                        iz_Cyfra = (char)((iz_L % iz_iPdstWyjsciowa) + (int)'0');
                        iz_L /= iz_iPdstWyjsciowa;
                    }
                    else
                    {
                        iz_iWartoscCyfry = iz_L % iz_iPdstWyjsciowa;
                        iz_L /= iz_iPdstWyjsciowa;

                        if (iz_iWartoscCyfry < 10)
                            iz_Cyfra = (char)(iz_iWartoscCyfry + (int)'0');
                        else
                            iz_Cyfra = (char)((iz_iWartoscCyfry - 10) + 'A');

                    }

                    iz_ctTablicaCyfr[iz_iIndex] = iz_Cyfra;
                    iz_iIndex++;
                }

                iz_strLiczbaSkonwertowana = "";

                for (int iz_i = iz_iIndex - 1; iz_i >= 0; iz_i--)
                    iz_strLiczbaSkonwertowana += iz_ctTablicaCyfr[iz_i];

                iz_txtWynik.Text = iz_strLiczbaSkonwertowana.ToString();


            }
        }

        private void iz_btnResetuj_Click(object sender, EventArgs e)
        {
            iz_txtLiczba.Enabled = true;
            iz_cmbPodstawaLiczby.Enabled = true;
            iz_cmbPodstawaWyjsciowa.Enabled = true;
            iz_txtWynik.Text = null;
            iz_txtLiczba.Text = null;
            iz_cmbPodstawaLiczby.SelectedIndex = 0;
            iz_cmbPodstawaWyjsciowa.SelectedIndex = 1;
        }

        private void iz_btnWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs iz_e)
        {
            DialogResult iz_Pytanie = MessageBox.Show("Czy na pewno chcesz wyjść z programu?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (iz_Pytanie == DialogResult.Yes)
                iz_e.Cancel = false;
            else
                if (iz_Pytanie == DialogResult.No)
                    iz_e.Cancel = true;
                else
                    iz_e.Cancel = true;
        }
    }
}
