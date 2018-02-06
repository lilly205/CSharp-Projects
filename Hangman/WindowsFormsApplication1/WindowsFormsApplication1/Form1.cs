using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int stage = 1;
        static Random rnd = new Random();
        int randomNum;
        int counter = 0;
        int amountCorrect = 0;
        List<string> guessWords = new List<string>();

        public Form1()
        {
            InitializeComponent();
            guessWords.Add("Aardvark");
            guessWords.Add("Big Cup of Milk");
            guessWords.Add("Santa Clause");
            guessWords.Add("Hello World");
            guessWords.Add("Young");
            guessWords.Add("Keyboard");
            guessWords.Add("Cat");
            guessWords.Add("Lappel du Vide");
            guessWords.Add("Brainstorm");
            guessWords.Add("Heroes and Heroines");
            guessWords.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            randomNum = rnd.Next(guessWords.Count);
            label1.Text = guessWords[randomNum];
            label1.Visible = false;
            label2.Text = "";
            label4.Visible = false;
            foreach (Char character in label1.Text)
            {
                if (character == ' ')
                {
                    label2.Text += " ";
                }
                else
                {
                    label2.Text += "_";
                    counter++;
                }

            }
            label3.Text = "Amount of Letters: " + counter;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            counter = 0;
            if (textBox1.Text != "")
            {
                if (textBox1.Text == " ")
                {
                    textBox1.Text = "";
                    return;
                }
                bool repeatedChar = false;
                foreach (ListViewItem item in listView1.Items)
                {
                    if (String.Equals(textBox1.Text, item.SubItems[0].Text, StringComparison.OrdinalIgnoreCase))
                    {
                        repeatedChar = true;
                        break;
                    }
                }
                if (repeatedChar == false)
                {
                    ListViewItem lvi = new ListViewItem(textBox1.Text.ToLower());
                    lvi.SubItems.Add(" ");
                    foreach (char character in label1.Text)
                    {
                        if (String.Equals(textBox1.Text, Char.ToString(character), StringComparison.OrdinalIgnoreCase))
                        {
                            lvi.SubItems[1].Text ="YES";
                            label2.Text = label2.Text.Remove(counter, 1).Insert(counter, textBox1.Text.ToLower());
                            amountCorrect++;
                        }
                        counter++;
                    }

                    if (lvi.SubItems[1].Text==" ")
                    {
                        lvi.SubItems[1].Text = "NO";
                        updatePictureBox(pictureBox1);
                    }

                    listView1.Items.Add(lvi);
                    textBox1.Text = "";
                    
                    if (amountCorrect == Convert.ToInt32(label3.Text.Substring(label3.Text.IndexOf(':')+2, label3.Text.Length-19)))
                    {
                        label4.Text = "You Won!";
                        label4.Visible = true;
                        textBox1.Enabled = false;
                        btnSubmit.Enabled = false;
                    }
                }
                else
                {
                    textBox1.Text = "";
                }

                //String.Equals(string1, string2, StringComparison.OrdinalIgnoreCase);

            }
        }

        private void updatePictureBox(PictureBox pictureBox1)
        {
            stage++;
            if (stage >= 7)
            {
                stage = 7;
                label4.Text = "You Lost!";
                label4.Visible = true;
                textBox1.Enabled = false;
                btnSubmit.Enabled = false;
                label1.Text = "Correct Word: " + label1.Text;
                label1.Visible = true;
            }
                string srcImage = "HangmanP" + stage;
                pictureBox1.Image = ((Image)Properties.Resources.ResourceManager.GetObject(srcImage));
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                listView1.Items.Clear();
            }
            label4.Visible = false;
            amountCorrect = 0;
            label1.Visible = false;
            textBox1.Enabled = true;
            btnSubmit.Enabled = true;
            counter = 0;
            label2.Text = "";
            stage = 1;
            pictureBox1.Image = Properties.Resources.HangmanP1;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
            textBox1.Text = "";
            randomNum = rnd.Next(guessWords.Count);
            label1.Text = guessWords[randomNum];
            foreach (Char character in label1.Text)
            {
                if (character == ' ')
                {
                    label2.Text += " ";
                }
                else
                {
                    label2.Text += "_";
                    counter++;
                }

            }
            label3.Text = "Amount of Letters: " + counter;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
