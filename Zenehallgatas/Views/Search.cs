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
using Zenehallgatas.Views;

namespace Zenehallgatas
{
    public partial class Search : Form
    {

        ZeneController controller = ZeneController.getInstance();
        public Search()
        {
            InitializeComponent();
            List<Zene> allZene = controller.getAllZeneList();
            Console.WriteLine(allZene);
            //new Zene(1, "Cím", "Valki", 2024, 1);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = allZene;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Cím";
            dataGridView1.Columns[2].HeaderText = "Előadó";
            dataGridView1.Columns[3].HeaderText = "Kiadás éve";
            dataGridView1.Columns[4].Visible = false ;
        }

        private void ujHozzaadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Form addormodify = new AddOrModify("hozzaadas");
            addormodify.Show();
            Hide();
        }

        private void modositasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addormodify = new AddOrModify("modositas");
            addormodify.Show();
            Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine("Teszt a row clickre, ez a leg első sima részre kapcsoláskor");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Clickelés elvilekben ez mindig lefut");
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row1 = dataGridView1.Rows[e.RowIndex];

                Console.WriteLine("Elviekben egy row ra kapcsoltam");

                Console.Write(row1.Cells[0].Value.ToString());
                Console.Write(" "+ row1.Cells[1].Value.ToString());
                Console.Write(" "+ row1.Cells[2].Value.ToString());
                Console.Write(" "+ row1.Cells[3].Value.ToString());
                Console.Write(" "+ row1.Cells[4].Value.ToString());


                // Your code here
            }
        }
    }
}
