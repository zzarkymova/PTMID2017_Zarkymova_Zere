using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Task3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Train train = new Train();
            string train_body = Console.ReadLine();
            string[] bbody = train_body.Split(' ');
            int x = bbody.Length;
            train.Draw(x);


            Thread t = new Thread(new ThreadStart(DoIt));
            t.Start();
            
    
               // train.Draw(x);
              
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        train.Move(0, -1, x);
                        break;

                    case ConsoleKey.DownArrow:
                        train.Move(0, 1, x);
                        break;
                    case ConsoleKey.LeftArrow:
                        train.Move(-1, 0, x);
                        break;
                    case ConsoleKey.RightArrow:
                        train.Move(1, 0, x);
                        break;
                    case ConsoleKey.Escape:
                        break;
                }

        }
        static void DoIt()
        {
            while (true)
            {
                Thread.Sleep(1000);
               
            }
        }


       
    }
}
