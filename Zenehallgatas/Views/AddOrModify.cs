using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenehallgatas.Controller;
using Zenehallgatas.Model;

namespace Zenehallgatas.Views
{
    public partial class AddOrModify : Form
    {
        ZeneController controller = ZeneController.getInstance();

        //hozzaadas vagy modositas
        private bool isAdd;
        private Zene selectedZene;
        public AddOrModify()
        {
            InitializeComponent();

            isAdd = true;
            AddInitialize();
            
        }

        public AddOrModify(Zene zene)
        {
            InitializeComponent();
            
            isAdd = false;
            this.selectedZene = zene;
            ModifyInitialize();
            
        }


        private void ModifyInitialize()
        {
            addOrModifyBTN.Text = "Módosítás";
            titleTB.Enabled = false;
            titleTB.Text = selectedZene.Title;
            performerTB.Enabled = false;
            performerTB.Text = selectedZene.Performer;
            releaseDateNumeric.Enabled = false;
            releaseDateNumeric.Value = selectedZene.ReleaseDate;
            lengthNumeric.Enabled = false;
            lengthNumeric.Value = selectedZene.Length;
            priorityNumeric.Value = selectedZene.Priority;
        }

        private void AddInitialize()
        {
            addOrModifyBTN.Text = "Hozzáadás";
        }

        private void keresesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.searchForm.Show();
            Dispose();
            
        }

        private void AddOrModify_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addOrModifyBTN_Click(object sender, EventArgs e)
        {
            if(isAdd)
            {
                AddZene();
            }
            else
            {
                ModifyZene();
            }
        }

        private void AddZene()
        {
            Console.WriteLine(titleTB.Text);
            Console.WriteLine(performerTB.Text);
            Console.WriteLine(releaseDateNumeric.Text);
            Console.WriteLine(lengthNumeric.Text);
            Console.WriteLine(priorityNumeric.Text);
            if (titleTB.Text.Length != 0 && performerTB.Text.Length != 0)
            {
                //itt mindegy hogy milyen ud-t adok meg, mert majd azt úgy is autoincrement el adjuk hozzá
                bool isSuccessfull = controller.addZene(new Zene(1234, titleTB.Text, performerTB.Text,
                    (int)releaseDateNumeric.Value,
                    (int)lengthNumeric.Value,
                    (int)priorityNumeric.Value));
                if (isSuccessfull)
                {
                    Console.WriteLine("Sikeres hozzáadás");
                    MessageBox.Show("Sikeres hozzáadás","Siker",MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    Console.WriteLine("Hiba az adatbázis hozzáadása során, nagy valószínűséggel van már ilyen néven zene");
                    MessageBox.Show("Hiba az adatbázis hozzáadása során, nagy valószínűséggel van már ilyen néven zene", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Console.WriteLine("A Cím vagy az előadó üres");
        }

        private void ModifyZene()
        {
            Console.WriteLine(titleTB.Text);
            Console.WriteLine(performerTB.Text);
            Console.WriteLine(releaseDateNumeric.Text);
            Console.WriteLine(lengthNumeric.Text);
            Console.WriteLine(priorityNumeric.Text);
        }
    }
}
