namespace ClassinClass
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.listBoxNaam = new System.Windows.Forms.ListBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.lbNew = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbElf = new System.Windows.Forms.RadioButton();
            this.rdbHuman = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbOrcs = new System.Windows.Forms.RadioButton();
            this.rdbUndead = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbHero = new System.Windows.Forms.RadioButton();
            this.rdbArcher = new System.Windows.Forms.RadioButton();
            this.rdbHorseman = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(15, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(96, 122);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(12, 130);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(121, 21);
            this.cmbBox.TabIndex = 1;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxNaam
            // 
            this.listBoxNaam.FormattingEnabled = true;
            this.listBoxNaam.Location = new System.Drawing.Point(12, 157);
            this.listBoxNaam.Name = "listBoxNaam";
            this.listBoxNaam.Size = new System.Drawing.Size(121, 95);
            this.listBoxNaam.TabIndex = 2;
            this.listBoxNaam.SelectedIndexChanged += new System.EventHandler(this.listBoxNaam_SelectedIndexChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 270);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 3;
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.Location = new System.Drawing.Point(306, 9);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(78, 13);
            this.lbNew.TabIndex = 4;
            this.lbNew.Text = "New Character";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(291, 48);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(130, 20);
            this.txtNaam.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(291, 74);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUndead);
            this.groupBox1.Controls.Add(this.rdbOrcs);
            this.groupBox1.Controls.Add(this.rdbHuman);
            this.groupBox1.Controls.Add(this.rdbElf);
            this.groupBox1.Location = new System.Drawing.Point(291, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rdbElf
            // 
            this.rdbElf.AutoSize = true;
            this.rdbElf.Location = new System.Drawing.Point(6, 10);
            this.rdbElf.Name = "rdbElf";
            this.rdbElf.Size = new System.Drawing.Size(37, 17);
            this.rdbElf.TabIndex = 0;
            this.rdbElf.TabStop = true;
            this.rdbElf.Text = "Elf";
            this.rdbElf.UseVisualStyleBackColor = true;
            // 
            // rdbHuman
            // 
            this.rdbHuman.AutoSize = true;
            this.rdbHuman.Location = new System.Drawing.Point(6, 33);
            this.rdbHuman.Name = "rdbHuman";
            this.rdbHuman.Size = new System.Drawing.Size(59, 17);
            this.rdbHuman.TabIndex = 1;
            this.rdbHuman.TabStop = true;
            this.rdbHuman.Text = "Human";
            this.rdbHuman.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // rdbOrcs
            // 
            this.rdbOrcs.AutoSize = true;
            this.rdbOrcs.Location = new System.Drawing.Point(77, 10);
            this.rdbOrcs.Name = "rdbOrcs";
            this.rdbOrcs.Size = new System.Drawing.Size(47, 17);
            this.rdbOrcs.TabIndex = 2;
            this.rdbOrcs.TabStop = true;
            this.rdbOrcs.Text = "Orcs";
            this.rdbOrcs.UseVisualStyleBackColor = true;
            // 
            // rdbUndead
            // 
            this.rdbUndead.AutoSize = true;
            this.rdbUndead.Location = new System.Drawing.Point(71, 33);
            this.rdbUndead.Name = "rdbUndead";
            this.rdbUndead.Size = new System.Drawing.Size(63, 17);
            this.rdbUndead.TabIndex = 3;
            this.rdbUndead.TabStop = true;
            this.rdbUndead.Text = "Undead";
            this.rdbUndead.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Life style";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Specifiek";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(462, 229);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(297, 289);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(137, 20);
            this.txtSpec.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbHorseman);
            this.groupBox2.Controls.Add(this.rdbArcher);
            this.groupBox2.Controls.Add(this.rdbHero);
            this.groupBox2.Location = new System.Drawing.Point(291, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 89);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // rdbHero
            // 
            this.rdbHero.AutoSize = true;
            this.rdbHero.Location = new System.Drawing.Point(7, 20);
            this.rdbHero.Name = "rdbHero";
            this.rdbHero.Size = new System.Drawing.Size(48, 17);
            this.rdbHero.TabIndex = 0;
            this.rdbHero.TabStop = true;
            this.rdbHero.Text = "Hero";
            this.rdbHero.UseVisualStyleBackColor = true;
            // 
            // rdbArcher
            // 
            this.rdbArcher.AutoSize = true;
            this.rdbArcher.Location = new System.Drawing.Point(6, 43);
            this.rdbArcher.Name = "rdbArcher";
            this.rdbArcher.Size = new System.Drawing.Size(56, 17);
            this.rdbArcher.TabIndex = 1;
            this.rdbArcher.TabStop = true;
            this.rdbArcher.Text = "Archer";
            this.rdbArcher.UseVisualStyleBackColor = true;
            // 
            // rdbHorseman
            // 
            this.rdbHorseman.AutoSize = true;
            this.rdbHorseman.Location = new System.Drawing.Point(7, 66);
            this.rdbHorseman.Name = "rdbHorseman";
            this.rdbHorseman.Size = new System.Drawing.Size(73, 17);
            this.rdbHorseman.TabIndex = 2;
            this.rdbHorseman.TabStop = true;
            this.rdbHorseman.Text = "Horseman";
            this.rdbHorseman.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lbNew);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.listBoxNaam);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.ListBox listBoxNaam;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label lbNew;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUndead;
        private System.Windows.Forms.RadioButton rdbOrcs;
        private System.Windows.Forms.RadioButton rdbHuman;
        private System.Windows.Forms.RadioButton rdbElf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbHorseman;
        private System.Windows.Forms.RadioButton rdbArcher;
        private System.Windows.Forms.RadioButton rdbHero;
    }
}

