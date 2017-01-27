namespace Notatnik
{
    partial class Find
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonZnajdzNastepny = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonWgore = new System.Windows.Forms.RadioButton();
            this.radioButtonWdol = new System.Windows.Forms.RadioButton();
            this.checkBoxWielkoscLiter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Znajdź:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonZnajdzNastepny
            // 
            this.buttonZnajdzNastepny.Enabled = false;
            this.buttonZnajdzNastepny.Location = new System.Drawing.Point(350, 6);
            this.buttonZnajdzNastepny.Name = "buttonZnajdzNastepny";
            this.buttonZnajdzNastepny.Size = new System.Drawing.Size(141, 23);
            this.buttonZnajdzNastepny.TabIndex = 2;
            this.buttonZnajdzNastepny.Text = "Znajdź następny";
            this.buttonZnajdzNastepny.UseVisualStyleBackColor = true;
            this.buttonZnajdzNastepny.Click += new System.EventHandler(this.buttonZnajdzNastepny_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(350, 35);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(141, 23);
            this.buttonAnuluj.TabIndex = 3;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonWdol);
            this.groupBox1.Controls.Add(this.radioButtonWgore);
            this.groupBox1.Location = new System.Drawing.Point(194, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kierunek";
            // 
            // radioButtonWgore
            // 
            this.radioButtonWgore.AutoSize = true;
            this.radioButtonWgore.Location = new System.Drawing.Point(3, 16);
            this.radioButtonWgore.Name = "radioButtonWgore";
            this.radioButtonWgore.Size = new System.Drawing.Size(60, 17);
            this.radioButtonWgore.TabIndex = 0;
            this.radioButtonWgore.TabStop = true;
            this.radioButtonWgore.Text = "W górę";
            this.radioButtonWgore.UseVisualStyleBackColor = true;
            // 
            // radioButtonWdol
            // 
            this.radioButtonWdol.AutoSize = true;
            this.radioButtonWdol.Location = new System.Drawing.Point(73, 16);
            this.radioButtonWdol.Name = "radioButtonWdol";
            this.radioButtonWdol.Size = new System.Drawing.Size(55, 17);
            this.radioButtonWdol.TabIndex = 1;
            this.radioButtonWdol.TabStop = true;
            this.radioButtonWdol.Text = "W dół";
            this.radioButtonWdol.UseVisualStyleBackColor = true;
            // 
            // checkBoxWielkoscLiter
            // 
            this.checkBoxWielkoscLiter.AutoSize = true;
            this.checkBoxWielkoscLiter.Location = new System.Drawing.Point(12, 62);
            this.checkBoxWielkoscLiter.Name = "checkBoxWielkoscLiter";
            this.checkBoxWielkoscLiter.Size = new System.Drawing.Size(140, 17);
            this.checkBoxWielkoscLiter.TabIndex = 2;
            this.checkBoxWielkoscLiter.Text = "Uwzględnij wielkość liter";
            this.checkBoxWielkoscLiter.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 94);
            this.Controls.Add(this.checkBoxWielkoscLiter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonZnajdzNastepny);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Znajdowanie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonZnajdzNastepny;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonWdol;
        private System.Windows.Forms.RadioButton radioButtonWgore;
        private System.Windows.Forms.CheckBox checkBoxWielkoscLiter;
    }
}