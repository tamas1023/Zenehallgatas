﻿using System;
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
        bool visibility = false;
        public Search()
        {
            InitializeComponent();

            //getAllZene();
        }

        private void getAllZene()
        {
            allZene = controller.getAllZeneList();
            Console.WriteLine(allZene);
            dataGridView1.Columns.Clear();


            dataGridView1.AllowUserToOrderColumns = true;

            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("title", "Cím");
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
            //Clickelés elvilekben ez mindig lefut
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row1 = dataGridView1.Rows[e.RowIndex];

                Console.WriteLine(row1.Cells.ToString());

                //A rowindex 0 tól intul, ezért kell ide + 1
                Zene selectedZene = allZene.Find((zene)=>zene.Id == e.RowIndex + 1);

                if (selectedZene != null)
                {
                    Console.WriteLine("A kiválasztott: "+selectedZene.ToString());
                }
                //mert 1 től megy az index az sqlite ban
                Form addormodify = new AddOrModify(selectedZene.Id);
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

            List<Zene> newFilteredZene= allZene.FindAll(z =>z.Title == searchTBOX.Text || z.Performer == searchTBOX.Text);


        }

        private void Search_Load(object sender, EventArgs e)
        {
            getAllZene();
            
        }

        private void Search_VisibleChanged(object sender, EventArgs e)
        {
            if (visibility)
            {
                visibility = false;
            }
            else
            {
                visibility = true;
                getAllZene();
                
            }
        }
    }
}
