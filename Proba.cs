using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ism
{
    // + public, - private (alapértelmezett)
    class Proba
    {
        // Adattagok
        private int x;
        private int y;

        public int X
        {
            get 
            { 
                return x; 
            }
            set 
            {
                if (value < 1)
                {
                    x = 1;
                }
                else
                {
                    x = value;
                }
            }
        }

        public int Y
        {
            get 
            { 
                return y; 
            }
            set
            { 
            }

        }
 
        // Metódusok
        // Konstruktor
        //public Proba(int a, int b)
        //{
            

        //    if (b < 1)
        //    {
        //        y = 1;
        //    }
        //    else
        //    {
        //        y = b;
        //    }

        //}
       
        public int Osszead(  )
        {
            return x + y;
        }

    }
}
