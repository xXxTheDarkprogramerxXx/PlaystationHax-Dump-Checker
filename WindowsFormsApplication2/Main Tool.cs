using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class Main_Tool : Form
    {
        public Main_Tool()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath;

        private void Main_Tool_Load(object sender, EventArgs e)
        {
            if (richTextBox1.Find("3.56") > 0)
                {
                    richTextBox1.SelectionFont = new Font("Verdana", 12, FontStyle.Bold); 
                    richTextBox1.SelectionColor = Color.Red;
                }
            this.Size = new Size(362, 156);
            Main_Tool main = new Main_Tool();
            Form1 frm1 = new Form1();
            frm1.Close();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Focus();   
            panel3.Visible = true;
            panel2.Visible = true;
            panel4.Visible = true;
            this.Size = new Size(925, 458);
            button2.Visible = false;
            button1.Location = new System.Drawing.Point(95,65) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path + @"\MinVer\",
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path + @"\PS3AutoPatcher\",
                UseShellExecute = true,
                Verb = "open"
            });
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path + @"\BWE\",
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path + @"\E3 Dump Checker\E3 Nor Dump Checker V1.0.exe",
                UseShellExecute = true,
                Verb = "open"
            });

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path + @"\NorIn\NorInspector.exe",
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path + @"\ps3Extra\",
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tortuga-cove.com/forums/abbcode_page.php?mode=click&id=1335");
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("http://rebug.me/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.mediafire.com/?55ti06x8jpc38tx");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "This App Was Created for PlaystationHax.it by \n \n xXx The Darkprogramer xXx \n The tools Included are created by other dev's \n Enjoy XD","About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("www.playstationhax.it");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.playstationhax.it/");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProblems_Click(object sender, EventArgs e)
        {
            Problems_Page prob = new Problems_Page();
            prob.ShowDialog();
        }
    }
}
