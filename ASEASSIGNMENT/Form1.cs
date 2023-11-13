using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASEASSIGNMENT
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Declarations
        /// </summary>
        private Parser commandParser;
        private Pen pen;
        private Color penColor;
        Bitmap OutputBitmap;
        Bitmap CursorBitmap;
        Canvas MyCanvas;
        Parser MyParser;
        Commands MyCommands;
        int radius;
        public Form1()
        {
            InitializeComponent();
            OutputBitmap = new Bitmap(width: 640, height: 480);
            CursorBitmap = new Bitmap(width: 640, height: 480);
            MyCanvas = new Canvas(Graphics.FromImage(OutputBitmap), Graphics.FromImage(CursorBitmap));
            MyParser = new Parser();

        }
        /// <summary>
        /// 
        /// </reads all the text inside the rich text box>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "GPL File (*.gpl)|*.gpl";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }
        /// <summary>
        /// reads the text line by line from the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string RichTextBoxContents = richTextBox1.Text;
            string[] RichTextBoxLines = richTextBox1.Lines;

        }
        /// <summary>
        /// saves the file when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sfd.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        
        {
            //creates an instance of graphics
            Graphics graphics = e.Graphics;

            graphics.DrawImageUnscaled(OutputBitmap, x: 0, y: 0);
            graphics.DrawImageUnscaled(CursorBitmap, x: 0, y: 0);

            Circle myCircle = new Circle(100, 100, radius);
            myCircle.draw(graphics);
        }
        /// <summary>
        /// clears any drawing inside the picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                pictureBox2.Dispose();
                pictureBox2.Image = null;
                pictureBox2.Update();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

}