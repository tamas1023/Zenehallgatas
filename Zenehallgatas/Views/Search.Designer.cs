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
            this.ujHozzaadasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1010, 28);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(866, 414);
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
            this.label1.Location = new System.Drawing.Point(896, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(128, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dupla katt az egyes sor elemeikre a módosításhoz";
            // 
            // searchTBOX
            // 
            this.searchTBOX.Location = new System.Drawing.Point(77, 40);
            this.searchTBOX.Margin = new System.Windows.Forms.Padding(2);
            this.searchTBOX.Name = "searchTBOX";
            this.searchTBOX.Size = new System.Drawing.Size(252, 20);
            this.searchTBOX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MaximumSize = new System.Drawing.Size(128, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Keresés";
            // 
            // searchBTN
            // 
            this.searchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.searchBTN.Location = new System.Drawing.Point(339, 34);
            this.searchBTN.Margin = new System.Windows.Forms.Padding(2);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(121, 36);
            this.searchBTN.TabIndex = 5;
            this.searchBTN.Text = "Keresés";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 524);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Search";
            this.Text = "Kereses";
            this.Load += new System.EventHandler(this.Search_Load);
            this.VisibleChanged += new System.EventHandler(this.Search_VisibleChanged);
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

