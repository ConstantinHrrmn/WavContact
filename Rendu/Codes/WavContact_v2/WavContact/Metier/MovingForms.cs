using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WavContact.Metier
{
    class MovingForms
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MovingForms()
        {

        }

        public bool CanDrag()
        {
            return this.dragging;
        }

        public void MouseDown(Point position)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = position;
        }

        public Point MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));

                return Point.Add(dragFormPoint, new Size(dif));
            }
            return new Point(0,0);
        }

        public void MouseUp()
        {
            dragging = false;
        }
    }
}
