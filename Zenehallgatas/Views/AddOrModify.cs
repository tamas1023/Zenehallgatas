using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenehallgatas.Views
{
    public partial class AddOrModify : Form
    {
        //hozzaadas vagy modositas
        private string szoveg;
        public AddOrModify(string szoveg)
        {
            InitializeComponent();
            
            this.szoveg = szoveg;

            if (szoveg == "hozzaadas")
            {
                AddInitialize();
            }
            else
            {
                ModifyInitialize();
            }
        }

        private void ModifyInitialize()
        {
            addOrModifyBTN.Text = "Módosítás";
            titleTB.Enabled = false;
            performerTB.Enabled = false;
            releaseDateNumeric.Enabled = false;
            lengthNumeric.Enabled = false;

        }

        private void AddInitialize()
        {
            addOrModifyBTN.Text = "Hozzáadás";
        }

        private void keresesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.searchForm.Show();
            Hide();
            
        }

        private void AddOrModify_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
