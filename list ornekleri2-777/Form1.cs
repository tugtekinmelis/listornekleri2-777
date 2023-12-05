using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace list_ornekleri2_777
{
    public partial class Form1 : Form
    {
        List<string> kisiler = new List<string>();
        int indexSira = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiler.Add("İlayda");
            kisiler.Add("Yasemin");
            kisiler.Add("İrem");
            kisiler.Add("Beyza");
            kisiler.Add("Melek");
            kisiler.Add("Melisa");

            listBox1.DataSource = kisiler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisiler.Add(textBox1.Text);
            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(textBox1.Text);
            if (durum)
            {
                MessageBox.Show(" Aradığınız kişi mevcut ");
            }
            else
            {
                MessageBox.Show(" Aradığınız kişi mevcut değil ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(textBox1.Text);
            if (sira> -1)
            {
                MessageBox.Show(textBox1.Text + " " + sira + " sırasındadır.");
            }
            else
            {
                MessageBox.Show(textBox1.Text + " sıralamada yok. ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(textBox1.Text);
            if (sira > -1)
            {
               kisiler.RemoveAt(sira); //RemoveAt -> belirtilen index sırasındaki değeri siler.
            }

            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(textBox1.Text);
            if (durum)
            {
                kisiler.Remove(textBox1.Text); // kişi adı ile silme 
            }

            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedValue.ToString();
            indexSira = listBox1.SelectedIndex;
            // Listbox içindeki sırasını veriyor.
            // Aynı sıralama list (kisiler) içinde geçerli
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(indexSira.ToString());
            kisiler[indexSira] = textBox1.Text;

            listBox1.DataSource = kisiler.ToList(); // ListBox güncelle
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kisiler.Sort();

            listBox1.DataSource = kisiler.ToList(); // ListBox güncelle
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            kisiler.Reverse(); // çevirme (ters çevirme)

            listBox1.DataSource = kisiler.ToList(); // ListBox güncelle
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Length == 5)
                {
                    sayac++;
                }
            }
            MessageBox.Show(" 5 Karakterli " + sayac + " tane öğrenci mevcut ");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i][0] == 'M')
                {
        
                    sayac++;
                }
            }
            MessageBox.Show(" M Karakterli " + sayac + " tane öğrenci mevcut ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kisiler.Clear();
            listBox1.DataSource =kisiler.ToList(); 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                string kisi = kisiler[i];
                if (kisi[kisi.Length-1] == 'a')
                {

                    sayac++;
                }
            }
            MessageBox.Show("Son harfi a Karakterli " + sayac + " tane öğrenci mevcut ");
        }
    }
}
