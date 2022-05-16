using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs_OOP6_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            int size = 10;
            int[,] matr = new int[size, size];
            for (int k = 0; k < size; k++)
            {
                for (int l = 0; l < size; l++)
                {
                    matr[k, l] = 0;
                }
            }

            int x = 0, y = 0;
            bool positiveDirection = false;
            bool down = false;
            int n = 1;
            for (; n < size * size + 1;)
            {
                if (down) { break; }
                if (positiveDirection)
                {
                    while ((x != size) && (y != -1))
                    {
                        matr[y, x] = n;
                        n++;
                        x++;
                        y--;
                    }

                    positiveDirection = false;

                    if (x == size)
                    {
                        x--;
                        down = true;
                    }
                    if (y == -1) { y++; }

                }
                else
                {
                    while ((x != -1) && (y != size))
                    {
                        matr[y, x] = n;
                        n++;
                        x--;
                        y++;
                    }
                    positiveDirection = true;
                    if (x == -1) { x++; }
                    if (y == size)
                    {
                        y--;
                        down = true;
                    }

                }
            }

            if (x == 0)
            {
                x++;
                positiveDirection = true;
            }
            else
            {
                positiveDirection = false;
                y++;
            }
            while (n < size * size + 1)
            {
                if (positiveDirection)
                {
                    while ((x != size) && (y != -1))
                    {
                        matr[y, x] = n;
                        n++;
                        x++;
                        y--;
                    }
                    positiveDirection = false;
                    if (x == size)
                    {
                        x--;
                        y += 2;
                        //down = true;
                    }
                    if (y == -1) { y++; }
                }
                else
                {
                    while ((x != -1) && (y != size))
                    {
                        matr[y, x] = n;
                        n++;
                        x--;
                        y++;
                    }
                    positiveDirection = true;
                    if (x == -1) { x++; }
                    if (y == size)
                    {
                        y--;
                        x += 2;
                        //down = true;
                    }
                }
            }
            dataGridView1.RowCount = 10;
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                for (int l = 0; l < matr.GetLength(1); l++)
                {
                    dataGridView1[l, k].Value = matr[k, l].ToString();
                }
            }
        }

    }
}
