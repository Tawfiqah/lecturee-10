using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecturee_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(new Label());

        }

        private void pnldynamkcontrols_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncreateconrtols_Click(object sender, EventArgs e)
        {
            int numberOfControls= int.Parse(txtnumberofcontols.Text);
            for (int i = 0; i < numberOfControls; i++)
            {
                Button newButton = new Button();
                newButton.Name = "DButton" + (i + 1);
                newButton.Text = "DButton" + (i + 1);
                newButton.Size = new Size(120, 40);
                newButton.Location = new Point((50 * i), (50 * i));
            }


            pnldynamkcontrols.Controls.Add(new Button());

            for (int i = 0; i < numberOfControls; i++)
            {
                Label newLabel = new Label();
                newLabel.Name = "DLabel" + (i + 1);
                newLabel.Text = "DLabel" + (i + 1);
                newLabel.Size = new Size(120, 40);
                newLabel.Location = new Point((50 * i), (50 * i));
            }

            pnldynamkcontrols.Controls.Add(new Label());

            for (int i = 0; i < numberOfControls; i++)
            {
                TextBox newTextBox = new TextBox();
                newTextBox.Name = "DTextBox" + (i + 1);
                newTextBox.Text = "DTextBox" + (i + 1);
                newTextBox.Size = new Size(120, 40);
                newTextBox.Location = new Point((50 * i), (50 * i));
            






                pnldynamkcontrols.Controls.Add(new TextBox());




        }



            




        }
    }
}
