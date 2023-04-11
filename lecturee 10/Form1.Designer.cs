namespace lecturee_10
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
            this.txtnumberofcontols = new System.Windows.Forms.TextBox();
            this.lblnumberofcontrols = new System.Windows.Forms.Label();
            this.btncreateconrtols = new System.Windows.Forms.Button();
            this.pnldynamkcontrols = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblcontoltype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnumberofcontols
            // 
            this.txtnumberofcontols.Location = new System.Drawing.Point(132, 99);
            this.txtnumberofcontols.Name = "txtnumberofcontols";
            this.txtnumberofcontols.Size = new System.Drawing.Size(230, 20);
            this.txtnumberofcontols.TabIndex = 0;
            // 
            // lblnumberofcontrols
            // 
            this.lblnumberofcontrols.AutoSize = true;
            this.lblnumberofcontrols.Location = new System.Drawing.Point(26, 106);
            this.lblnumberofcontrols.Name = "lblnumberofcontrols";
            this.lblnumberofcontrols.Size = new System.Drawing.Size(100, 13);
            this.lblnumberofcontrols.TabIndex = 2;
            this.lblnumberofcontrols.Text = "number of controls :";
            // 
            // btncreateconrtols
            // 
            this.btncreateconrtols.Location = new System.Drawing.Point(158, 125);
            this.btncreateconrtols.Name = "btncreateconrtols";
            this.btncreateconrtols.Size = new System.Drawing.Size(139, 39);
            this.btncreateconrtols.TabIndex = 3;
            this.btncreateconrtols.Text = "create controls ";
            this.btncreateconrtols.UseVisualStyleBackColor = true;
            this.btncreateconrtols.Click += new System.EventHandler(this.btncreateconrtols_Click);
            // 
            // pnldynamkcontrols
            // 
            this.pnldynamkcontrols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldynamkcontrols.Location = new System.Drawing.Point(55, 170);
            this.pnldynamkcontrols.Name = "pnldynamkcontrols";
            this.pnldynamkcontrols.Size = new System.Drawing.Size(351, 251);
            this.pnldynamkcontrols.TabIndex = 4;
            this.pnldynamkcontrols.Paint += new System.Windows.Forms.PaintEventHandler(this.pnldynamkcontrols_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "button",
            "text box ",
            "label"});
            this.comboBox1.Location = new System.Drawing.Point(132, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblcontoltype
            // 
            this.lblcontoltype.AutoSize = true;
            this.lblcontoltype.Location = new System.Drawing.Point(52, 20);
            this.lblcontoltype.Name = "lblcontoltype";
            this.lblcontoltype.Size = new System.Drawing.Size(68, 13);
            this.lblcontoltype.TabIndex = 6;
            this.lblcontoltype.Text = "control type :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcontoltype);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnldynamkcontrols);
            this.Controls.Add(this.btncreateconrtols);
            this.Controls.Add(this.lblnumberofcontrols);
            this.Controls.Add(this.txtnumberofcontols);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumberofcontols;
        private System.Windows.Forms.Label lblnumberofcontrols;
        private System.Windows.Forms.Button btncreateconrtols;
        private System.Windows.Forms.Panel pnldynamkcontrols;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblcontoltype;
    }
}

