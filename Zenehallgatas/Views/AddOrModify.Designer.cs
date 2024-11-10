namespace Zenehallgatas.Views
{
    partial class AddOrModify
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.releaseDateNumeric = new System.Windows.Forms.NumericUpDown();
            this.performerLabel = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.Label();
            this.lengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.priorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.performerTB = new System.Windows.Forms.TextBox();
            this.addOrModifyBTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.releaseDateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresesToolStripMenuItem
            // 
            this.keresesToolStripMenuItem.Name = "keresesToolStripMenuItem";
            this.keresesToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.keresesToolStripMenuItem.Text = "kereses";
            this.keresesToolStripMenuItem.Click += new System.EventHandler(this.keresesToolStripMenuItem_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.6F);
            this.titleLabel.Location = new System.Drawing.Point(16, 73);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(64, 32);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Cím";
            // 
            // releaseDateNumeric
            // 
            this.releaseDateNumeric.Location = new System.Drawing.Point(335, 246);
            this.releaseDateNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.releaseDateNumeric.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.releaseDateNumeric.Name = "releaseDateNumeric";
            this.releaseDateNumeric.Size = new System.Drawing.Size(160, 22);
            this.releaseDateNumeric.TabIndex = 3;
            // 
            // performerLabel
            // 
            this.performerLabel.AutoSize = true;
            this.performerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.6F);
            this.performerLabel.Location = new System.Drawing.Point(16, 150);
            this.performerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.performerLabel.Name = "performerLabel";
            this.performerLabel.Size = new System.Drawing.Size(104, 32);
            this.performerLabel.TabIndex = 4;
            this.performerLabel.Text = "Előadó";
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.6F);
            this.releaseDateLabel.Location = new System.Drawing.Point(16, 246);
            this.releaseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(155, 32);
            this.releaseDateLabel.TabIndex = 5;
            this.releaseDateLabel.Text = "Kiadás éve";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.6F);
            this.lengthLabel.Location = new System.Drawing.Point(16, 315);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(176, 32);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "Zene hossza";
            // 
            // priority
            // 
            this.priority.AutoSize = true;
            this.priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.6F);
            this.priority.Location = new System.Drawing.Point(16, 411);
            this.priority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(119, 32);
            this.priority.TabIndex = 7;
            this.priority.Text = "Prioritás";
            // 
            // lengthNumeric
            // 
            this.lengthNumeric.Location = new System.Drawing.Point(335, 325);
            this.lengthNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.lengthNumeric.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.lengthNumeric.Name = "lengthNumeric";
            this.lengthNumeric.Size = new System.Drawing.Size(160, 22);
            this.lengthNumeric.TabIndex = 8;
            // 
            // priorityNumeric
            // 
            this.priorityNumeric.Location = new System.Drawing.Point(335, 411);
            this.priorityNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.priorityNumeric.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.priorityNumeric.Name = "priorityNumeric";
            this.priorityNumeric.Size = new System.Drawing.Size(160, 22);
            this.priorityNumeric.TabIndex = 9;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(335, 82);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(160, 22);
            this.titleTB.TabIndex = 10;
            // 
            // performerTB
            // 
            this.performerTB.Location = new System.Drawing.Point(335, 160);
            this.performerTB.Name = "performerTB";
            this.performerTB.Size = new System.Drawing.Size(160, 22);
            this.performerTB.TabIndex = 11;
            // 
            // addOrModifyBTN
            // 
            this.addOrModifyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addOrModifyBTN.Location = new System.Drawing.Point(525, 403);
            this.addOrModifyBTN.Name = "addOrModifyBTN";
            this.addOrModifyBTN.Size = new System.Drawing.Size(154, 40);
            this.addOrModifyBTN.TabIndex = 12;
            this.addOrModifyBTN.Text = "button1";
            this.addOrModifyBTN.UseVisualStyleBackColor = true;
            this.addOrModifyBTN.Click += new System.EventHandler(this.addOrModifyBTN_Click);
            // 
            // AddOrModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 554);
            this.Controls.Add(this.addOrModifyBTN);
            this.Controls.Add(this.performerTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.priorityNumeric);
            this.Controls.Add(this.lengthNumeric);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.performerLabel);
            this.Controls.Add(this.releaseDateNumeric);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddOrModify";
            this.Text = "HozzadasVagyModositas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrModify_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.releaseDateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresesToolStripMenuItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.NumericUpDown releaseDateNumeric;
        private System.Windows.Forms.Label performerLabel;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label priority;
        private System.Windows.Forms.NumericUpDown lengthNumeric;
        private System.Windows.Forms.NumericUpDown priorityNumeric;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox performerTB;
        private System.Windows.Forms.Button addOrModifyBTN;
    }
}