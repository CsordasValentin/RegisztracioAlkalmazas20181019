using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas20181019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Mentes()
        {
            string tartalom = nameTextBox.Text + ";" + bDateTextBox + ";" + hobbiesListBox;
            saveFileDialog.FileName = "";
            var eredmeny = saveFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string fileNev = saveFileDialog.FileName;
                File.WriteAllText(fileNev, tartalom);
            }
        }

        private void Megnyitas()
        {
            string tartalom = nameTextBox.Text + ";" + bDateTextBox + ";" + hobbiesListBox;

            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                tartalom = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void addNewHobbieButton_Click(object sender, EventArgs e)
        {
            List<string> hobbieList = new List<string>();
            hobbieList.Add(addNewHobbieTextBox.Text);
            hobbiesListBox.DataSource = hobbieList;
        }
    }
}
