using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                btn1.BackColor = Color.Yellow;
                btnHarf.Text = btn1.Text;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara ilimiz?";
                btn2.BackColor = Color.Yellow;
                btnHarf.Text = btn2.Text;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                btn3.BackColor = Color.Yellow;
                btnHarf.Text = btn3.Text;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                btn4.BackColor = Color.Yellow;
                btnHarf.Text = btn4.Text;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesiniz zıt anlamlısı?";
                btn5.BackColor = Color.Yellow;
                btnHarf.Text = btn5.Text;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                btn6.BackColor = Color.Yellow;
                btnHarf.Text = btn6.Text;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                btn7.BackColor = Color.Yellow;
                btnHarf.Text = btn7.Text;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                btn8.BackColor = Color.Yellow;
                btnHarf.Text = btn8.Text;
            }
            
            if (soruno == 9)
            {
                richTextBox1.Text = "Gölüyle ünlü ilimiz?";
                btn9.BackColor = Color.Yellow;
                btnHarf.Text = btn9.Text;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi?";
                btn10.BackColor = Color.Yellow;
                btnHarf.Text = btn10.Text;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                btn11.BackColor = Color.Yellow;
                btnHarf.Text = btn11.Text;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatya'nın meşhur meyvesi?";
                btn12.BackColor = Color.Yellow;
                btnHarf.Text = btn12.Text;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                btn13.BackColor = Color.Yellow;
                btnHarf.Text = btn13.Text;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı?";
                btn14.BackColor = Color.Yellow;
                btnHarf.Text = btn14.Text;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                btn15.BackColor = Color.Yellow;
                btnHarf.Text = btn15.Text;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                btn16.BackColor = Color.Yellow;
                btnHarf.Text = btn16.Text;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç, havuz gibi sebzelerle yapılan yemek?";
                btn17.BackColor = Color.Yellow;
                btnHarf.Text = btn17.Text;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                btn18.BackColor = Color.Yellow;
                btnHarf.Text = btn18.Text;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                btn19.BackColor = Color.Yellow;
                btnHarf.Text = btn19.Text;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiye'nin mega starı?";
                btn20.BackColor = Color.Yellow;
                btnHarf.Text = btn20.Text;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                btn21.BackColor = Color.Yellow;
                btnHarf.Text = btn21.Text;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                btn22.BackColor = Color.Yellow;
                btnHarf.Text = btn22.Text;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                btn23.BackColor = Color.Yellow;
                btnHarf.Text = btn23.Text;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege Bölgesinin en çok ağacı bulunan ve yağıda yapılan kahvaltı besini?";
                btn24.BackColor = Color.Yellow;
                btnHarf.Text = btn24.Text;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text=="akdeniz")
                        {
                            btn1.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            
                        }
                        else
                        {
                            btn1.BackColor= Color.Red;
                            yanlis++;
                            lblYanlis.Text=yanlis.ToString();
                        }
                       
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            btn2.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn2.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                       
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            btn3.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn3.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            btn4.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn4.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            btn5.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn5.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            btn6.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn6.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            btn7.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn7.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Halı")
                        {
                            btn8.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn8.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Halı")
                        {
                            btn9.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn9.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "Halı")
                        {
                            btn10.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn10.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Halı")
                        {
                            btn11.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn11.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Halı")
                        {
                            btn12.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn12.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Halı")
                        {
                            btn13.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn13.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Halı")
                        {
                            btn14.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn14.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Halı")
                        {
                            btn15.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn15.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Halı")
                        {
                            btn16.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn16.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Halı")
                        {
                            btn17.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn17.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Halı")
                        {
                            btn18.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn18.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Halı")
                        {
                            btn19.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn19.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Halı")
                        {
                            btn20.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn20.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Halı")
                        {
                            btn21.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn21.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Halı")
                        {
                            btn22.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn22.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "Halı")
                        {
                            btn23.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn23.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "Halı")
                        {
                            btn24.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btn24.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;



                    default:
                        btnHarf.BackColor = Color.Red;
                        btnHarf.Text = "Son";
                        break;
                }
            }
        }
    }
}
