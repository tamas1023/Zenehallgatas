namespace Zenehallgatas
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujHozzaadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modositasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresesToolStripMenuItem,
            this.ujHozzaadasToolStripMenuItem,
            this.modositasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresesToolStripMenuItem
            // 
            this.keresesToolStripMenuItem.Name = "keresesToolStripMenuItem";
            this.keresesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.keresesToolStripMenuItem.Text = "kereses";
            // 
            // ujHozzaadasToolStripMenuItem
            // 
            this.ujHozzaadasToolStripMenuItem.Name = "ujHozzaadasToolStripMenuItem";
            this.ujHozzaadasToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.ujHozzaadasToolStripMenuItem.Text = "uj hozzaadas";
            this.ujHozzaadasToolStripMenuItem.Click += new System.EventHandler(this.ujHozzaadasToolStripMenuItem_Click);
            // 
            // modositasToolStripMenuItem
            // 
            this.modositasToolStripMenuItem.Name = "modositasToolStripMenuItem";
            this.modositasToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.modositasToolStripMenuItem.Text = "modositas";
            this.modositasToolStripMenuItem.Click += new System.EventHandler(this.modositasToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.performer,
            this.createdDate,
            this.length,
            this.priority});
            this.dataGridView1.Location = new System.Drawing.Point(16, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 537);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // title
            // 
            this.title.HeaderText = "Cím";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // performer
            // 
            this.performer.HeaderText = "Előadó";
            this.performer.MinimumWidth = 6;
            this.performer.Name = "performer";
            this.performer.ReadOnly = true;
            this.performer.Width = 125;
            // 
            // createdDate
            // 
            this.createdDate.HeaderText = "Kiadás éve";
            this.createdDate.MinimumWidth = 6;
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            this.createdDate.Width = 125;
            // 
            // length
            // 
            this.length.HeaderText = "Zene hossza";
            this.length.MinimumWidth = 6;
            this.length.Name = "length";
            this.length.ReadOnly = true;
            this.length.Width = 125;
            // 
            // priority
            // 
            this.priority.HeaderText = "Prioritás";
            this.priority.MinimumWidth = 6;
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            this.priority.Visible = false;
            this.priority.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(1177, 93);
            this.label1.MaximumSize = new System.Drawing.Size(170, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dupla katt az egyes sor elemeikre a módosításhoz";
            // 
            // searchTBOX
            // 
            this.searchTBOX.Location = new System.Drawing.Point(82, 48);
            this.searchTBOX.Name = "searchTBOX";
            this.searchTBOX.Size = new System.Drawing.Size(304, 22);
            this.searchTBOX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.MaximumSize = new System.Drawing.Size(170, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Keresés";
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(405, 47);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 23);
            this.searchBTN.TabIndex = 5;
            this.searchBTN.Text = "Keresés";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 645);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Search";
            this.Text = "Kereses";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujHozzaadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modositasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn performer;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBTN;
    }
}

