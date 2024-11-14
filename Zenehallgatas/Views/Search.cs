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
        List<Zene> allZene;
        public Search()
        {
            InitializeComponent();
            
            allZene = controller.getAllZeneList();
            Console.WriteLine(allZene);
            dataGridView1.Columns.Clear();

            
            dataGridView1.AllowUserToOrderColumns = true;

            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add ("title", "Cím");
            dataGridView1.Columns.Add("performer", "Előadó");
            dataGridView1.Columns.Add("releaseDate", "Kiadás éve");
            dataGridView1.Columns.Add("length", "Hossz");
            dataGridView1.Columns.Add("priority", "Prioritás");

            foreach (Zene zene in allZene)
            {
                dataGridView1.Rows.Add(zene.toGridView());
            }

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            //a prioritás szerinti rendezést majd meg kell oldani
        }

        private void ujHozzaadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Form addormodify = new AddOrModify();
            addormodify.Show();
            Hide();
        }



        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine("Teszt a row clickre, ez a leg első sima részre kapcsoláskor");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Clickelés elvilekben ez mindig lefut");
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row1 = dataGridView1.Rows[e.RowIndex];

                Console.WriteLine("Elviekben egy row ra kapcsoltam");

                //Console.Write(row1.Cells[0].Value.ToString());
                //Console.Write(" " + row1.Cells[1].Value.ToString());
                //Console.Write(" " + row1.Cells[2].Value.ToString());
                //Console.Write(" " + row1.Cells[3].Value.ToString());
                //Console.Write(" " + row1.Cells[4].Value.ToString());

                Console.WriteLine("RowIndex: " + e.RowIndex);

                Console.WriteLine("");

                Console.WriteLine(row1.Cells.ToString());

                Zene selectedZene = allZene.Find((zene)=>zene.Id == e.RowIndex);

                if (selectedZene != null)
                {
                    Console.WriteLine("A kiválasztott: "+selectedZene.ToString());
                }

                Form addormodify = new AddOrModify(selectedZene);
                addormodify.Show();
                
                Hide();

                
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            Console.WriteLine(searchTBOX.Text);
            List<Zene> fileredZene = allZene.FindAll((item) =>
            {
                Console.WriteLine(item.ToString());
                return item.Equals(searchTBOX.Text);
            });
            Console.WriteLine(allZene.Count);
            Console.WriteLine(fileredZene.Count);

        }
    }
}
