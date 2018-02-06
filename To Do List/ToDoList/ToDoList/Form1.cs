using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        string line = "";
        int index = 0;
        bool dateAsc = true;
        bool nameAsc = true;
        public Form1()
        {
            InitializeComponent();
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("ToDoList.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    line = string.Empty;

                    while ((line = sr.ReadLine()) != null)
                    {
                        // If the line is not empty, add it to the list.
                        if (line != string.Empty)
                        {
                            lstToDo.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                StreamWriter File = new StreamWriter("ToDoList.txt");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstToDo.SelectedItem != null)
            {
                index = lstToDo.SelectedIndex;
                List<string> tempList = new List<string>();
                if (File.Exists("ToDoList.txt"))
                {
                    using (StreamReader reader = new StreamReader("ToDoList.txt"))
                    {
                        line = string.Empty;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // If the line is not empty, add it to the list.
                            if (line != string.Empty)
                            {
                                tempList.Add(line);
                            }
                        }
                    }
                }
                tempList.RemoveAt(index);
                File.WriteAllLines("ToDoList.txt", tempList.ToArray());
                lstToDo.Items.Remove(lstToDo.SelectedItem);
            }
        }

        private void lstToDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtToDoName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtToDoName.Enabled = true;
            txtToDoName.Text = "";
            dtpDate.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtToDoName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtToDoName.Text != "")
            {
                //if (txtToDoName.Text.Length < 50)
                //{
                //    while (txtToDoName.Text.Length<50)
                //    {
                //        txtToDoName.Text += " ";
                //    }
                //}
                line = txtToDoName.Text + ": " + dtpDate.Text;
                if (File.Exists("ToDoList.txt"))
                {
                    using (StreamWriter txt = File.AppendText("ToDoList.txt"))
                    {
                        txt.WriteLine(line);
                        txt.Close();
                    }
                }
                else
                {
                    using (StreamWriter txt = File.CreateText("ToDoList.txt"))
                    {
                        txt.WriteLine(line);
                        txt.Close();
                    }
                }
                lstToDo.Items.Add(line);
                line = "";

            }
            txtToDoName.Enabled = false;
            txtToDoName.Text = "";
            dtpDate.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dtpDate.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtToDoName.Enabled = false;
            txtToDoName.Text = "";
            dtpDate.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dtpDate.Value = DateTime.Now;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                btnSave.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.A)       // Ctrl-A Add
            {
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                btnAdd.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.R)       // Ctrl-R Remove
            {
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                btnRemove.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.N)       // Ctrl-N Sort by Name
            {
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                btnSortName.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D)       // Ctrl-D Sort by Date
            {
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                btnSortDate.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.E)       // Ctrl-E Exit
            {
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                btnExit.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.C)       // Ctrl-C Cancel
            {
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                btnCancel.PerformClick();
            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            if (lstToDo.Items.Count > 0)
            {
                List<string> tempList = new List<string>();
                foreach (string s in lstToDo.Items)
                {
                    tempList.Add(s);
                }
                if (nameAsc == true)
                {
                    var sortedNames = tempList
                    .OrderByDescending(x => x)
                    .ToList();

                    lstToDo.Items.Clear();
                    foreach (string s in sortedNames)
                    {
                        lstToDo.Items.Add(s);
                    }

                    File.WriteAllLines("ToDoList.txt", sortedNames.ToArray());
                    nameAsc = false;
                    btnSortName.Text = "Name ↓";
                }
                else
                {
                    var sortedNames = tempList
                    .OrderBy(x => x)
                    .ToList();

                    lstToDo.Items.Clear();
                    foreach (string s in sortedNames)
                    {
                        lstToDo.Items.Add(s);
                    }

                    File.WriteAllLines("ToDoList.txt", sortedNames.ToArray());
                    nameAsc = true;
                    btnSortName.Text = "Name ↑";
                }

            }
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {
            if (lstToDo.Items.Count > 0)
            {
                List<string> tempList = new List<string>();
                foreach (string s in lstToDo.Items)
                {
                    tempList.Add(s);
                }
                if (dateAsc == true)
                {
                    var sortedMonths = tempList
                   .Select(x => new { month = x, Sort = DateTime.ParseExact(x.Substring(x.LastIndexOf(':') + 2), "dddd, MMMM dd, yyyy", CultureInfo.InvariantCulture) })
                   .OrderByDescending(x => x.Sort)
                   .Select(x => x.month)
                   .ToList();

                    lstToDo.Items.Clear();
                    foreach (string s in sortedMonths)
                    {
                        lstToDo.Items.Add(s);
                    }
                    File.WriteAllLines("ToDoList.txt", sortedMonths.ToArray());
                    dateAsc = false;
                    btnSortDate.Text = "Date ↓";
                }
                else
                {
                    var sortedMonths = tempList
                   .Select(x => new { month = x, Sort = DateTime.ParseExact(x.Substring(x.LastIndexOf(':') + 2), "dddd, MMMM dd, yyyy", CultureInfo.InvariantCulture) })
                   .OrderBy(x => x.Sort)
                   .Select(x => x.month)
                   .ToList();

                    lstToDo.Items.Clear();
                    foreach (string s in sortedMonths)
                    {
                        lstToDo.Items.Add(s);
                    }
                    File.WriteAllLines("ToDoList.txt", sortedMonths.ToArray());
                    dateAsc = true;
                    btnSortDate.Text = "Date ↑";
                }
            }
        }

        private void txtToDoName_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
