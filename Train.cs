using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Task3
{
    public class Train
    {
        public char sign = '#';
     //   List<Point> body = new List<Point>();

        
        
       
        public void Draw(int x)
        {
            for (int i = 0; i < x; ++i)
            {
                //Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
            }
        }
        public void Move(int dx, int dy, int x)
        {
            for (int i = x - 1; i > 0; --i)
            {
                bbody[i].x = bbody[i - 1].x;
                bbody[i].y = bbody[i - 1].y;
            }

            bbody[0].x = bbody[0].x + dx;
            bbody[0].y = bbody[0].y + dy;


        }

       

    }
}