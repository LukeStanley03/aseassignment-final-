using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEASSIGNMENT
{
    class Canvas
    {
        Graphics g;
        Pen pen;
        int xPos, yPos; //Position pen while drawing

        /// <summary>
        /// constructer that initialises the canvas to a white pen at 0,0
        /// </summary>
        /// <param name="g">Graphics context of where to draw on>
        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            pen = new Pen(Color.Black, 1); //normal pen (should use constants)
        }
        /// <summary>
        /// draw a line from the current pen position
        /// </summary>
        /// <param name="toX"> x postion to draw to>
        /// <param name="toY"> y postion to draw to>
        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(pen, xPos, yPos, toX, toY); //draws the line
            xPos = toX;
            yPos = toY; //this will update the pen position as it is moved to the end of the line
        }

        public void DrawSquare(int width)
        {
            g.DrawRectangle(pen, xPos, yPos, xPos + width, yPos + width);
        }
    }
}
