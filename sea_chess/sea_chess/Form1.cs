﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace sea_chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        bool[] arr1 = new bool[10];
        int komp_opit;
        int purvi;
        int igrach;
        string comp, player;
        private void btnStart_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                arr1[i] = false;
            }
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
            btnStart.Enabled = false;
            labelbrd.Text = "";
   
            igrach = r.Next(0, 2);
            purvi = r.Next(0, 2);

            if (purvi == 0 && igrach == 0)
            {
                lblResult.Text = "Вие сте с О и сте първи!";
                player = "O";
                comp = "X";
            }
            else if (purvi == 0 && igrach == 1)
            {
                lblResult.Text = "Вие сте с Х, но компютърът е първи";
                player = "X";
                comp = "O";

                komp_opit = r.Next(1, 10);

                if (komp_opit == 1)
                {
                    button1.Text = comp;
                    button1.ForeColor = Color.Red;
                    button1.Enabled = false;
                }
                else if (komp_opit == 2)
                {
                    button2.Text = comp;
                    button2.ForeColor = Color.Red;
                    button2.Enabled = false;                 
                }
                else if (komp_opit == 3)
                {
                    button3.Text = comp;
                    button3.ForeColor = Color.Red;
                    button3.Enabled = false;                   
                }
                else if (komp_opit == 4)
                {
                    button4.Text = comp;
                    button4.ForeColor = Color.Red;
                    button4.Enabled = false;                   
                }
                else if (komp_opit == 5)
                {
                    button5.Text = comp;
                    button5.ForeColor = Color.Red;
                    button5.Enabled = false;                  
                }
                else if (komp_opit == 6)
                {
                    button6.Text = comp;
                    button6.ForeColor = Color.Red;
                    button6.Enabled = false;
                }
                else if (komp_opit == 7)
                {
                    button7.Text = comp;
                    button7.ForeColor = Color.Red;
                    button7.Enabled = false;                   
                }
                else if (komp_opit == 8)
                {
                    button8.Text = comp;
                    button8.ForeColor = Color.Red;
                    button8.Enabled = false;                    
                }
                else if (komp_opit == 9)
                {
                    button9.Text = comp;
                    button9.ForeColor = Color.Red;
                    button9.Enabled = false;                   
                }
                arr1[komp_opit] = true;
            }
            else if (purvi == 1 && igrach == 0)
            {
                lblResult.Text = "Вие сте с O, но компютърът е първи";
                player = "O";
                comp = "X";

                komp_opit = r.Next(1, 10);
                arr1[komp_opit] = true; 

                if (komp_opit == 1)
                {
                    button1.Text = comp;
                    button1.ForeColor = Color.Red;
                    button1.Enabled = false;                 
                }
                else if (komp_opit == 2)
                {
                    button2.Text = comp;
                    button2.ForeColor = Color.Red;
                    button2.Enabled = false;                  
                }
                else if (komp_opit == 3)
                {
                    button3.Text = comp;
                    button3.ForeColor = Color.Red;
                    button3.Enabled = false;                  
                }
                else if (komp_opit == 4)
                {
                    button4.Text = comp;
                    button4.ForeColor = Color.Red;
                    button4.Enabled = false;                 
                }
                else if (komp_opit == 5)
                {
                    button5.Text = comp;
                    button5.ForeColor = Color.Red;
                    button5.Enabled = false;                
                }
                else if (komp_opit == 6)
                {
                    button6.Text = comp;
                    button6.ForeColor = Color.Red;
                    button6.Enabled = false;                   
                }
                else if (komp_opit == 7)
                {
                    button7.Text = comp;
                    button7.ForeColor = Color.Red;
                    button7.Enabled = false;                  
                }
                else if (komp_opit == 8)
                {
                    button8.Text = comp;
                    button8.ForeColor = Color.Red;
                    button8.Enabled = false;                 
                }
                else if (komp_opit == 9)
                {
                    button9.Text = comp;
                    button9.ForeColor = Color.Red;
                    button9.Enabled = false;                    
                }
            }
            else if (purvi == 1 && igrach == 1)
            {
                lblResult.Text = "Вие сте с X и сте първи!";
                player = "X";
                comp = "O";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Text = player;
            if (bt.Name == "button1")
            {
                arr1[1] = true;
            }
            if (bt.Name == "button2")
            {
                arr1[2] = true;
            }
            if (bt.Name == "button3")
            {
                arr1[3] = true;
            }
            if (bt.Name == "button4")
            {
                arr1[4] = true;
            }
            if (bt.Name == "button5")
            {
                arr1[5] = true;
            }
            if (bt.Name == "button6")
            {
                arr1[6] = true;
            }
            if (bt.Name == "button7")
            {
                arr1[7] = true;
            }
            if (bt.Name == "button8")
            {
                arr1[8] = true;
            }
            if (bt.Name == "button9")
            {
                arr1[9] = true;
            }
            bt.Enabled = false;
            bt.ForeColor = Color.Green;
            bt.Text = player;
            //proverka
            if ((button1.Text == player && button2.Text == player && button3.Text == player) ||
                (button4.Text == player && button5.Text == player && button6.Text == player) ||
                (button7.Text == player && button8.Text == player && button9.Text == player) ||
                (button1.Text == player && button4.Text == player && button7.Text == player) ||
                (button2.Text == player && button5.Text == player && button8.Text == player) ||
                (button3.Text == player && button6.Text == player && button9.Text == player) ||
                (button1.Text == player && button5.Text == player && button9.Text == player) ||
                (button3.Text == player && button5.Text == player && button7.Text == player))
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
                btnStart.Enabled = true;
                lblResult.Text = "";
                MessageBox.Show( "Поздравления, Вие спечелихте!");
                return;
            }
            else
            {
                Thread.Sleep(500);
                //komputar
                komp_opit = r.Next(1, 10);
                while (arr1[komp_opit] == true)
                {
                    komp_opit = r.Next(1, 10);
                }
                arr1[komp_opit] = true;
                if (komp_opit == 1)
                {
                    button1.Text = comp;
                    button1.ForeColor = Color.Red;
                    button1.Enabled = false;

                }
                else if (komp_opit == 2)
                {
                    button2.Text = comp;
                    button2.ForeColor = Color.Red;
                    button2.Enabled = false;
                }
                else if (komp_opit == 3)
                {
                    button3.Text = comp;
                    button3.ForeColor = Color.Red;
                    button3.Enabled = false;
                }
                else if (komp_opit == 4)
                {
                    button4.Text = comp;
                    button4.ForeColor = Color.Red;
                    button4.Enabled = false;
                }
                else if (komp_opit == 5)
                {
                    button5.Text = comp;
                    button5.ForeColor = Color.Red;
                    button5.Enabled = false;
                }
                else if (komp_opit == 6)
                {
                    button6.Text = comp;
                    button6.ForeColor = Color.Red;
                    button6.Enabled = false;
                }
                else if (komp_opit == 7)
                {
                    button7.Text = comp;
                    button7.ForeColor = Color.Red;
                    button7.Enabled = false;
                }
                else if (komp_opit == 8)
                {
                    button8.Text = comp;
                    button8.ForeColor = Color.Red;
                    button8.Enabled = false;
                }
                else if (komp_opit == 9)
                {
                    button9.Text = comp;
                    button9.ForeColor = Color.Red;
                    button9.Enabled = false;
                }

                if ((button1.Text == comp && button2.Text == comp && button3.Text == comp) ||
                    (button4.Text == comp && button5.Text == comp && button6.Text == comp) ||
                    (button7.Text == comp && button8.Text == comp && button9.Text == comp) ||
                    (button1.Text == comp && button4.Text == comp && button7.Text == comp) ||
                    (button2.Text == comp && button5.Text == comp && button8.Text == comp) ||
                    (button3.Text == comp && button6.Text == comp && button9.Text == comp) ||
                    (button1.Text == comp && button5.Text == comp && button9.Text == comp) ||
                    (button3.Text == comp && button5.Text == comp && button7.Text == comp))
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
                    btnStart.Enabled = true;
                    lblResult.Text = "";
                    MessageBox.Show("За съжаление, Вие загубихте! Опитайте пак!");
                    return;
                }
            }
        }
    }
}
