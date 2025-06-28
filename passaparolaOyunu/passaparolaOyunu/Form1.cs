using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaparolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (soruNo)
            {
                case 1:
                    richTextBox1.Text = "İlk insanların yaşadığı çağın adı?";
                    button1.BackColor = Color.Yellow;
                    textBox1.Text = "Antik";
                    break;

                case 2:
                    richTextBox1.Text = "Almanya'nın başkenti?";
                    button2.BackColor = Color.Yellow;
                    textBox1.Text = "Berlin";
                    break;

                case 3:
                    richTextBox1.Text = "Türkiye'nin en kalabalık üçüncü harfiyle başlayan şehri?";
                    button3.BackColor = Color.Yellow;
                    textBox1.Text = "Ceyhan";
                    break;

                case 4:
                    richTextBox1.Text = "İki sayının birbirine oranı nedir?";
                    button4.BackColor = Color.Yellow;
                    textBox1.Text = "Denklem";
                    break;

                case 5:
                    richTextBox1.Text = "Dünya'nın uydusu hangi hareketi yapar?";
                    button5.BackColor = Color.Yellow;
                    textBox1.Text = "Eksen";
                    break;

                case 6:
                    richTextBox1.Text = "Sıcaklık ölçü birimi?";
                    button6.BackColor = Color.Yellow;
                    textBox1.Text = "Fahrenheit";
                    break;

                case 7:
                    richTextBox1.Text = "Dünya’nın en büyük okyanusu?";
                    button7.BackColor = Color.Yellow;
                    textBox1.Text = "Güney Pasifik";
                    break;

                case 8:
                    richTextBox1.Text = "Işığı kıran optik araç?";
                    button8.BackColor = Color.Yellow;
                    textBox1.Text = "Hologram";
                    break;

                case 9:
                    richTextBox1.Text = "Türkiye'nin önemli nehirlerinden biri?";
                    button9.BackColor = Color.Yellow;
                    textBox1.Text = "Irmak";
                    break;

                case 10:
                    richTextBox1.Text = "Dünyada en çok konuşulan dil?";
                    button10.BackColor = Color.Yellow;
                    textBox1.Text = "İngilizce";
                    break;

                case 11:
                    richTextBox1.Text = "Batman'in ezeli düşmanı?";
                    button11.BackColor = Color.Yellow;
                    textBox1.Text = "Joker";
                    break;

                case 12:
                    richTextBox1.Text = "Yılın en soğuk mevsimi?";
                    button12.BackColor = Color.Yellow;
                    textBox1.Text = "Kış";
                    break;

                case 13:
                    richTextBox1.Text = "Sıvı miktarı ölçüm birimi?";
                    button13.BackColor = Color.Yellow;
                    textBox1.Text = "Litre";
                    break;

                case 14:
                    richTextBox1.Text = "Kızıl gezegen olarak bilinen gezegen?";
                    button14.BackColor = Color.Yellow;
                    textBox1.Text = "Mars";
                    break;

                case 15:
                    richTextBox1.Text = "Matematikte bilinmeyen genellikle hangi harf olur?";
                    button15.BackColor = Color.Yellow;
                    textBox1.Text = "N";
                    break;

                case 16:
                    richTextBox1.Text = "Dünya’nın şekli nasıldır?";
                    button16.BackColor = Color.Yellow;
                    textBox1.Text = "Oval";
                    break;

                case 17:
                    richTextBox1.Text = "Türkiye’nin para birimi nedir?";
                    button17.BackColor = Color.Yellow;
                    textBox1.Text = "Para";
                    break;

                case 18:
                    richTextBox1.Text = "Gökyüzündeki sinyalleri tespit eden sistem?";
                    button18.BackColor = Color.Yellow;
                    textBox1.Text = "Radar";
                    break;

                case 19:
                    richTextBox1.Text = "Su buharının yoğunlaşmasıyla oluşan doğa olayı?";
                    button19.BackColor = Color.Yellow;
                    textBox1.Text = "Sis";
                    break;

                case 20:
                    richTextBox1.Text = "Türkiye’nin Karadeniz bölgesindeki büyük şehirlerinden biri?";
                    button20.BackColor = Color.Yellow;
                    textBox1.Text = "Trabzon";
                    break;

                case 21:
                    richTextBox1.Text = "Havada yolculuk yapan araç?";
                    button21.BackColor = Color.Yellow;
                    textBox1.Text = "Uçak";
                    break;

                case 22:
                    richTextBox1.Text = "İnsan vücuduna zarar verebilen mikroskobik canlı?";
                    button22.BackColor = Color.Yellow;
                    textBox1.Text = "Virüs";
                    break;

                case 23:
                    richTextBox1.Text = "Sütle yapılan geleneksel Türk yiyeceği?";
                    button23.BackColor = Color.Yellow;
                    textBox1.Text = "Yoğurt";
                    break;

                case 24:
                    richTextBox1.Text = "Siyah beyaz çizgili Afrika hayvanı?";
                    button24.BackColor = Color.Yellow;
                    textBox1.Text = "Zebra";
                    break;

                default:
                    richTextBox1.Text = "Geçersiz soru numarası!";
                    break;
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "İlk insanların yaşadığı çağın adı?";
                button1.BackColor = Color.Yellow;
                // Cevap: Antik
            }
            else if (soruNo == 2)
            {
                richTextBox1.Text = "Almanya'nın başkenti?";
                button2.BackColor = Color.Yellow;
                // Cevap: Berlin
            }
            else if (soruNo == 3)
            {
                richTextBox1.Text = "Türkiye'nin en kalabalık üçüncü harfiyle başlayan şehri?";
                button3.BackColor = Color.Yellow;
                // Cevap: Ceyhan (veya Cizre)
            }
            else if (soruNo == 4)
            {
                richTextBox1.Text = "İki sayının birbirine oranı nedir?";
                button4.BackColor = Color.Yellow;
                // Cevap: Denklem
            }
            else if (soruNo == 5)
            {
                richTextBox1.Text = "Dünya'nın uydusu hangi hareketi yapar?";
                button5.BackColor = Color.Yellow;
                // Cevap: Eksen
            }
            else if (soruNo == 6)
            {
                richTextBox1.Text = "Sıcaklık ölçü birimi?";
                button6.BackColor = Color.Yellow;
                // Cevap: Fahrenheit
            }
            else if (soruNo == 7)
            {
                richTextBox1.Text = "Dünya’nın en büyük okyanusu?";
                button7.BackColor = Color.Yellow;
                // Cevap: Güney Pasifik
            }
            else if (soruNo == 8)
            {
                richTextBox1.Text = "Işığı kıran optik araç?";
                button8.BackColor = Color.Yellow;
                // Cevap: Hologram
            }
            else if (soruNo == 9)
            {
                richTextBox1.Text = "Türkiye'nin önemli nehirlerinden biri?";
                button9.BackColor = Color.Yellow;
                // Cevap: Irmak
            }
            else if (soruNo == 10)
            {
                richTextBox1.Text = "Dünyada en çok konuşulan dil?";
                button10.BackColor = Color.Yellow;
                // Cevap: İngilizce
            }
            else if (soruNo == 11)
            {
                richTextBox1.Text = "Batman'in ezeli düşmanı?";
                button11.BackColor = Color.Yellow;
                // Cevap: Joker
            }
            else if (soruNo == 12)
            {
                richTextBox1.Text = "Yılın en soğuk mevsimi?";
                button12.BackColor = Color.Yellow;
                // Cevap: Kış
            }
            else if (soruNo == 13)
            {
                richTextBox1.Text = "Sıvı miktarı ölçüm birimi?";
                button13.BackColor = Color.Yellow;
                // Cevap: Litre
            }
            else if (soruNo == 14)
            {
                richTextBox1.Text = "Kızıl gezegen olarak bilinen gezegen?";
                button14.BackColor = Color.Yellow;
                // Cevap: Mars
            }
            else if (soruNo == 15)
            {
                richTextBox1.Text = "Matematikte bilinmeyen genellikle hangi harf olur?";
                button15.BackColor = Color.Yellow;
                // Cevap: N
            }
            else if (soruNo == 16)
            {
                richTextBox1.Text = "Dünya’nın şekli nasıldır?";
                button16.BackColor = Color.Yellow;
                // Cevap: Oval
            }
            else if (soruNo == 17)
            {
                richTextBox1.Text = "Türkiye’nin para birimi nedir?";
                button17.BackColor = Color.Yellow;
                // Cevap: Para
            }
            else if (soruNo == 18)
            {
                richTextBox1.Text = "Gökyüzündeki sinyalleri tespit eden sistem?";
                button18.BackColor = Color.Yellow;
                // Cevap: Radar
            }
            else if (soruNo == 19)
            {
                richTextBox1.Text = "Su buharının yoğunlaşmasıyla oluşan doğa olayı?";
                button19.BackColor = Color.Yellow;
                // Cevap: Sis
            }
            else if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiye’nin Karadeniz bölgesindeki büyük şehirlerinden biri?";
                button20.BackColor = Color.Yellow;
                // Cevap: Trabzon
            }
            else if (soruNo == 21)
            {
                richTextBox1.Text = "Havada yolculuk yapan araç?";
                button21.BackColor = Color.Yellow;
                // Cevap: Uçak
            }
            else if (soruNo == 22)
            {
                richTextBox1.Text = "İnsan vücuduna zarar verebilen mikroskobik canlı?";
                button22.BackColor = Color.Yellow;
                // Cevap: Virüs
            }
            else if (soruNo == 23)
            {
                richTextBox1.Text = "Sütle yapılan geleneksel Türk yiyeceği?";
                button23.BackColor = Color.Yellow;
                // Cevap: Yoğurt
            }
            else if (soruNo == 24)
            {
                richTextBox1.Text = "Siyah beyaz çizgili Afrika hayvanı?";
                button24.BackColor = Color.Yellow;
                // Cevap: Zebra
            }

        }
    }
}
