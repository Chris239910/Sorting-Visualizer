using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DataSctructures_SortingAlgorithms.Classes
{
    class Bubble_Sort : SortPanel
    {
        private Form myForm;
        public Bubble_Sort(Form form, string title, int w, int h) : base(title, w, h)
        {
            this.Initialize_Array();
            this.myForm = form;
        }
        //TODO for Final Project 2 (Final Evaluation)
        //O(n^2)
  
        public override void Run()
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                   
                    int k;
                    for (k = 0 ; k < array.Length -1-i; k++)
                    {
                        if (array[k] > array[k + 1])
                        {
                            greenColumn = k;
                            Thread.Sleep(3 * sleepTime);
                            //repaint
                            myForm.Refresh();
                            redColumn = k-1;
                            //repaint
                            myForm.Refresh();
                            Thread.Sleep(4 * sleepTime);
                            int tmp = array[k];
                            array[k] = array[k + 1];
                            array[k + 1] = tmp;
                        }
                    }
                    redColumn = k-1;
                    //repaint					
                    myForm.Refresh();
                }
                greenColumn = array.Length - 1;
                redColumn = -1;
                myForm.Refresh();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            myForm.Refresh();
        }
    }
}
