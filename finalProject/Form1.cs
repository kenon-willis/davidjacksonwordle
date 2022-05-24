using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace finalProject
{
    public partial class Form1 : Form
    {
            

        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        bool gameover = false;
        int numberOfGuesses = 6;
        string answer = "";
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> Words = new List<string>();
            //String Word = listBox1.SelectedItem.ToString();
            int index = rand.Next(0, listBox1.Items.Count);
            answer = listBox1.Items[index].ToString();
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = true;
            textBox19.Enabled = true;
            textBox20.Enabled = true;
            textBox21.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox25.Enabled = true;
            textBox26.Enabled = true;
            textBox27.Enabled = true;
            textBox28.Enabled = true;
            textBox29.Enabled = true;
            textBox30.Enabled = true;

            button1.Visible = false;
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            textBox5.Text = ("");
            textBox6.Text = ("");
            textBox7.Text = ("");
            textBox8.Text = ("");
            textBox9.Text = ("");
            textBox10.Text = ("");
            textBox11.Text = ("");
            textBox12.Text = ("");
            textBox13.Text = ("");
            textBox14.Text = ("");
            textBox15.Text = ("");
            textBox16.Text = ("");
            textBox17.Text = ("");
            textBox18.Text = ("");
            textBox19.Text = ("");
            textBox20.Text = ("");
            textBox21.Text = ("");
            textBox22.Text = ("");
            textBox23.Text = ("");
            textBox24.Text = ("");
            textBox25.Text = ("");
            textBox26.Text = ("");
            textBox27.Text = ("");
            textBox28.Text = ("");
            textBox29.Text = ("");
            textBox30.Text = ("");
            numberOfGuesses = 6;

            label3.Text = answer.ToString();
        }

        private void check(TextBox text)
        {
            if(text.Text != answer)
            {

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((numberOfGuesses == 6 && textBox1.Text != ("") && textBox2.Text != ("") && textBox3.Text != ("") && textBox4.Text != ("") && textBox5.Text != ("")) || (numberOfGuesses == 5 && textBox6.Text != ("") && textBox7.Text != ("") && textBox8.Text != ("") && textBox9.Text != ("") && textBox10.Text != ("")) || (numberOfGuesses == 4 && textBox11.Text != ("") && textBox12.Text != ("") && textBox13.Text != ("") && textBox14.Text != ("") && textBox15.Text != ("")) || (numberOfGuesses == 3 && textBox16.Text != ("") && textBox17.Text != ("") && textBox18.Text != ("") && textBox19.Text != ("") && textBox20.Text != ("")) || (numberOfGuesses == 2 && textBox21.Text != ("") && textBox22.Text != ("") && textBox23.Text != ("") && textBox24.Text != ("") && textBox25.Text != ("")) || (numberOfGuesses == 1 && textBox26.Text != ("") && textBox27.Text != ("") && textBox28.Text != ("") && textBox29.Text != ("") && textBox30.Text != ("")))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (textBox26.Text + textBox27.Text + textBox28.Text + textBox29.Text + textBox30.Text == answer && numberOfGuesses == 1)
                    {
                        MessageBox.Show("Cutting it close!");
                        button1.Visible = true;
                        makeAllGreen(textBox26, textBox27, textBox28, textBox29, textBox30);

                    }
                    else if (textBox26.Text + textBox27.Text + textBox28.Text + textBox29.Text + textBox30.Text != answer && numberOfGuesses == 1)
                    {
                        numberOfGuesses--;
                        checkForGreen(textBox26, textBox27, textBox28, textBox29, textBox30);
                        checkForYellow(textBox26, textBox27, textBox28, textBox29, textBox30);
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;
                        MessageBox.Show("You Lost");
                        MessageBox.Show("The answer was " + answer);
                        button1.Visible = true;
                    }

                    if (textBox21.Text + textBox22.Text + textBox23.Text + textBox24.Text + textBox25.Text == answer && numberOfGuesses == 2)
                    {
                        MessageBox.Show("Fifth Try!");
                        button1.Visible = true;
                        makeAllGreen(textBox21, textBox22, textBox23, textBox24, textBox25);
                    }
                    else if (textBox21.Text + textBox22.Text + textBox23.Text + textBox24.Text + textBox25.Text != answer && numberOfGuesses == 2)
                    {
                        numberOfGuesses--;
                        checkForGreen(textBox21, textBox22, textBox23, textBox24, textBox25);
                        checkForYellow(textBox21, textBox22, textBox23, textBox24, textBox25);
                        textBox26.Visible = true;
                        textBox27.Visible = true;
                        textBox28.Visible = true;
                        textBox29.Visible = true;
                        textBox30.Visible = true;
                        textBox21.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;
                        textBox25.Enabled = false;
                    }

                    if (textBox16.Text + textBox17.Text + textBox18.Text + textBox19.Text + textBox20.Text == answer && numberOfGuesses == 3)
                    {
                        MessageBox.Show("Fourth Try!");
                        button1.Visible = true;
                        makeAllGreen(textBox16, textBox17, textBox18, textBox19, textBox20);
                    }
                    else if (textBox16.Text + textBox17.Text + textBox18.Text + textBox19.Text + textBox20.Text != answer && numberOfGuesses == 3)
                    {
                        numberOfGuesses--;
                        checkForGreen(textBox16, textBox17, textBox18, textBox19, textBox20);
                        checkForYellow(textBox16, textBox17, textBox18, textBox19, textBox20);
                        textBox21.Visible = true;
                        textBox22.Visible = true;
                        textBox23.Visible = true;
                        textBox24.Visible = true;
                        textBox25.Visible = true;
                        textBox16.Enabled = false;
                        textBox17.Enabled = false;
                        textBox18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                    }

                    if (textBox11.Text + textBox12.Text + textBox13.Text + textBox14.Text + textBox15.Text == answer && numberOfGuesses == 4)
                    {
                        MessageBox.Show("Third Time's the Charm");
                        button1.Visible = true;
                        makeAllGreen(textBox11, textBox12, textBox13, textBox14, textBox15);
                    }
                    else if (textBox11.Text + textBox12.Text + textBox13.Text + textBox14.Text + textBox15.Text != answer && numberOfGuesses == 4)
                    {
                        numberOfGuesses--;
                        checkForGreen(textBox11, textBox12, textBox13, textBox14, textBox15);
                        checkForYellow(textBox11, textBox12, textBox13, textBox14, textBox15);
                        textBox16.Visible = true;
                        textBox17.Visible = true;
                        textBox18.Visible = true;
                        textBox19.Visible = true;
                        textBox20.Visible = true;
                        textBox11.Enabled = false;
                        textBox12.Enabled = false;
                        textBox13.Enabled = false;
                        textBox14.Enabled = false;
                        textBox15.Enabled = false;

                    }

                    if (textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text == answer && numberOfGuesses == 5)
                    {
                        MessageBox.Show("Second Try!");
                        button1.Visible = true;
                        makeAllGreen(textBox6, textBox7, textBox8, textBox9, textBox10);
                    }
                    else if (textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text != answer && numberOfGuesses == 5)
                    {
                        numberOfGuesses--;
                        checkForGreen(textBox6, textBox7, textBox8, textBox9, textBox10);
                        checkForYellow(textBox6, textBox7, textBox8, textBox9, textBox10);
                        textBox11.Visible = true;
                        textBox12.Visible = true;
                        textBox13.Visible = true;
                        textBox14.Visible = true;
                        textBox15.Visible = true;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        textBox9.Enabled = false;
                        textBox10.Enabled = false;

                    }

                    if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text == answer && numberOfGuesses == 6)
                    {
                        MessageBox.Show("First Try!");
                        button1.Visible = true;
                        makeAllGreen(textBox1, textBox2, textBox3, textBox4, textBox5);
                    }
                    else if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text != answer && numberOfGuesses == 6)
                    {
                        numberOfGuesses--;
                        checkForGreen(textBox1, textBox2, textBox3, textBox4, textBox5);
                        checkForYellow(textBox1, textBox2, textBox3, textBox4, textBox5);
                        textBox6.Visible = true;
                        textBox7.Visible = true;
                        textBox8.Visible = true;
                        textBox9.Visible = true;
                        textBox10.Visible = true;
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                    }
                }


            }
        }
    private void checkForGreen(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5)
        {
            
            if (t1.Text == answer.Substring(0, 1))
            {
                t1.BackColor = Color.Green;
            }
           
            if (t2.Text == answer.Substring(1, 1))
            {
                t2.BackColor = Color.Green;
            }
            
            if (t3.Text == answer.Substring(2, 1))
            {
                t3.BackColor = Color.Green;
            }
            
            if (t4.Text == answer.Substring(3, 1))
            {
                t4.BackColor = Color.Green;
            }
            
            if (t5.Text == answer.Substring(4))
            {
                t5.BackColor = Color.Green;
            }

        }

    private void checkForYellow(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5)
        {
            if (t1.Text == answer.Substring(1, 1) || t1.Text == answer.Substring(2, 1) || t1.Text == answer.Substring(3, 1) || t1.Text == answer.Substring(4))
            {
                t1.BackColor = Color.Yellow;
            }

            if (t2.Text == answer.Substring(0, 1) || t2.Text == answer.Substring(2, 1) || t2.Text == answer.Substring(3, 1) || t2.Text == answer.Substring(4))
            {
                t2.BackColor = Color.Yellow;
            }

            if (t3.Text == answer.Substring(1, 1) || t3.Text == answer.Substring(1, 1) || t3.Text == answer.Substring(3, 1) || t3.Text == answer.Substring(4))
            {
                t3.BackColor = Color.Yellow;
            }

            if (t4.Text == answer.Substring(1, 1) || t4.Text == answer.Substring(2, 1) || t4.Text == answer.Substring(0, 1) || t4.Text == answer.Substring(4))
            {
                t4.BackColor = Color.Yellow;
            }

            if (t5.Text == answer.Substring(1, 1) || t5.Text == answer.Substring(2, 1) || t5.Text == answer.Substring(3, 1) || t5.Text == answer.Substring(0, 1))
            {
                t5.BackColor = Color.Yellow;
            }
        }
    private void makeAllGreen(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5)
        {
            t1.BackColor = Color.Green;
            t2.BackColor = Color.Green;
            t3.BackColor = Color.Green;
            t4.BackColor = Color.Green;
            t5.BackColor = Color.Green;
        }
    }

    
}
