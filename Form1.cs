﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArrayList_ile_uygulamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList sehirler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
            Listele();
        }

        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.Insert(indexNo,textBox1.Text);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler[indexNo] = listBox1.Text;
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indexNo = 0;
            indexNo = listBox1.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(listBox1.Text))
            {
                label2.Text = "aranan değer bulunamadı";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
