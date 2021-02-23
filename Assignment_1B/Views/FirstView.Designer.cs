namespace Assignment_1B.Views
{
    partial class FirstView
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
            this.components = new System.ComponentModel.Container();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbCivilian = new System.Windows.Forms.RadioButton();
            this.rbCriminal = new System.Windows.Forms.RadioButton();
            this.rbPolice = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.btn_addPerson = new System.Windows.Forms.Button();
            this.pnl_Civilian = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.pnl_criminal = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_charges = new System.Windows.Forms.TextBox();
            this.pnl_police = new System.Windows.Forms.Panel();
            this.cmb_rank = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.pnl_update = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenu.SuspendLayout();
            this.pnl_Civilian.SuspendLayout();
            this.pnl_criminal.SuspendLayout();
            this.pnl_police.SuspendLayout();
            this.pnl_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.bringToFrontToolStripMenuItem,
            this.sendToBackToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(114, 114);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // bringToFrontToolStripMenuItem
            // 
            this.bringToFrontToolStripMenuItem.Name = "bringToFrontToolStripMenuItem";
            this.bringToFrontToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            // 
            // sendToBackToolStripMenuItem
            // 
            this.sendToBackToolStripMenuItem.Name = "sendToBackToolStripMenuItem";
            this.sendToBackToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            // 
            // rbCivilian
            // 
            this.rbCivilian.AutoSize = true;
            this.rbCivilian.Checked = true;
            this.rbCivilian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCivilian.Location = new System.Drawing.Point(13, 377);
            this.rbCivilian.Name = "rbCivilian";
            this.rbCivilian.Size = new System.Drawing.Size(77, 20);
            this.rbCivilian.TabIndex = 1;
            this.rbCivilian.TabStop = true;
            this.rbCivilian.Text = "Civilian";
            this.rbCivilian.UseVisualStyleBackColor = true;
            this.rbCivilian.Click += new System.EventHandler(this.rbCivilian_Click);
            // 
            // rbCriminal
            // 
            this.rbCriminal.AutoSize = true;
            this.rbCriminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCriminal.Location = new System.Drawing.Point(13, 409);
            this.rbCriminal.Name = "rbCriminal";
            this.rbCriminal.Size = new System.Drawing.Size(82, 20);
            this.rbCriminal.TabIndex = 2;
            this.rbCriminal.Text = "Criminal";
            this.rbCriminal.UseVisualStyleBackColor = true;
            this.rbCriminal.Click += new System.EventHandler(this.rbCriminal_Click);
            // 
            // rbPolice
            // 
            this.rbPolice.AutoSize = true;
            this.rbPolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPolice.Location = new System.Drawing.Point(12, 440);
            this.rbPolice.Name = "rbPolice";
            this.rbPolice.Size = new System.Drawing.Size(70, 20);
            this.rbPolice.TabIndex = 3;
            this.rbPolice.Text = "Police";
            this.rbPolice.UseVisualStyleBackColor = true;
            this.rbPolice.Click += new System.EventHandler(this.rbPolice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y:";
            // 
            // txt_x
            // 
            this.txt_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x.Location = new System.Drawing.Point(157, 394);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(86, 22);
            this.txt_x.TabIndex = 8;
            // 
            // txt_y
            // 
            this.txt_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_y.Location = new System.Drawing.Point(158, 426);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(86, 22);
            this.txt_y.TabIndex = 9;
            // 
            // btn_addPerson
            // 
            this.btn_addPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPerson.Location = new System.Drawing.Point(455, 521);
            this.btn_addPerson.Name = "btn_addPerson";
            this.btn_addPerson.Size = new System.Drawing.Size(117, 28);
            this.btn_addPerson.TabIndex = 10;
            this.btn_addPerson.Text = "Add Person";
            this.btn_addPerson.UseVisualStyleBackColor = true;
            this.btn_addPerson.Click += new System.EventHandler(this.btn_addPerson_Click);
            // 
            // pnl_Civilian
            // 
            this.pnl_Civilian.Controls.Add(this.label5);
            this.pnl_Civilian.Controls.Add(this.label1);
            this.pnl_Civilian.Controls.Add(this.txt_Cash);
            this.pnl_Civilian.Location = new System.Drawing.Point(325, 374);
            this.pnl_Civilian.Name = "pnl_Civilian";
            this.pnl_Civilian.Size = new System.Drawing.Size(247, 71);
            this.pnl_Civilian.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cash In Hand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Civilian Details";
            // 
            // txt_Cash
            // 
            this.txt_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cash.Location = new System.Drawing.Point(130, 31);
            this.txt_Cash.Name = "txt_Cash";
            this.txt_Cash.Size = new System.Drawing.Size(107, 22);
            this.txt_Cash.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "First Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(158, 497);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(145, 22);
            this.txt_firstName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Last Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.Location = new System.Drawing.Point(158, 461);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(144, 22);
            this.txt_lastName.TabIndex = 21;
            // 
            // pnl_criminal
            // 
            this.pnl_criminal.Controls.Add(this.label8);
            this.pnl_criminal.Controls.Add(this.label9);
            this.pnl_criminal.Controls.Add(this.txt_charges);
            this.pnl_criminal.Location = new System.Drawing.Point(315, 374);
            this.pnl_criminal.Name = "pnl_criminal";
            this.pnl_criminal.Size = new System.Drawing.Size(247, 71);
            this.pnl_criminal.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Charges";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Criminal Details";
            // 
            // txt_charges
            // 
            this.txt_charges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_charges.Location = new System.Drawing.Point(130, 31);
            this.txt_charges.Name = "txt_charges";
            this.txt_charges.Size = new System.Drawing.Size(107, 22);
            this.txt_charges.TabIndex = 14;
            // 
            // pnl_police
            // 
            this.pnl_police.Controls.Add(this.cmb_rank);
            this.pnl_police.Controls.Add(this.label10);
            this.pnl_police.Controls.Add(this.label11);
            this.pnl_police.Location = new System.Drawing.Point(305, 379);
            this.pnl_police.Name = "pnl_police";
            this.pnl_police.Size = new System.Drawing.Size(247, 71);
            this.pnl_police.TabIndex = 26;
            // 
            // cmb_rank
            // 
            this.cmb_rank.FormattingEnabled = true;
            this.cmb_rank.Items.AddRange(new object[] {
            "Surgent",
            "Senior Surgent",
            "Sub Inspector",
            "Inspector",
            "Office Incharge"});
            this.cmb_rank.Location = new System.Drawing.Point(89, 31);
            this.cmb_rank.Name = "cmb_rank";
            this.cmb_rank.Size = new System.Drawing.Size(121, 21);
            this.cmb_rank.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Rank";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Police Details";
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(4, 12);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 28);
            this.btn_Update.TabIndex = 28;
            this.btn_Update.Text = "Update Person";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // pnl_update
            // 
            this.pnl_update.Controls.Add(this.btn_cancel);
            this.pnl_update.Controls.Add(this.btn_Update);
            this.pnl_update.Location = new System.Drawing.Point(353, 506);
            this.pnl_update.Name = "pnl_update";
            this.pnl_update.Size = new System.Drawing.Size(219, 43);
            this.pnl_update.TabIndex = 29;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(110, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenu;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(56, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(467, 340);
            this.listBox1.TabIndex = 30;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // FirstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pnl_update);
            this.Controls.Add(this.pnl_police);
            this.Controls.Add(this.pnl_criminal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.pnl_Civilian);
            this.Controls.Add(this.btn_addPerson);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPolice);
            this.Controls.Add(this.rbCriminal);
            this.Controls.Add(this.rbCivilian);
            this.Name = "FirstView";
            this.Text = "First View";
            this.contextMenu.ResumeLayout(false);
            this.pnl_Civilian.ResumeLayout(false);
            this.pnl_Civilian.PerformLayout();
            this.pnl_criminal.ResumeLayout(false);
            this.pnl_criminal.PerformLayout();
            this.pnl_police.ResumeLayout(false);
            this.pnl_police.PerformLayout();
            this.pnl_update.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCivilian;
        private System.Windows.Forms.RadioButton rbCriminal;
        private System.Windows.Forms.RadioButton rbPolice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Button btn_addPerson;
        private System.Windows.Forms.Panel pnl_Civilian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Panel pnl_criminal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_charges;
        private System.Windows.Forms.Panel pnl_police;
        private System.Windows.Forms.ComboBox cmb_rank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringToFrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToBackToolStripMenuItem;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Panel pnl_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ListBox listBox1;
    }
}