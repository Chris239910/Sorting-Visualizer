using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DataSctructures_SortingAlgorithms.Classes
{
    class Selection_Sort : SortPanel
    {
        private Form myForm;
        public Selection_Sort(Form form, string title, int w, int h) : base(title, w, h)
        {
            this.Initialize_Array();
            this.myForm = form;
        }
        //TODO for Final Project 2 (Final Evaluation)
        public override void Run()
        {
            try
            {
                int i, j, minValue, minIndex, temp = 0;
                for(i = 0; i < array.Length; i++)
                {
                    greenColumn = i;
                    redColumn = greenColumn;
                    minValue = array[i];
                    minIndex = i;
                    for(j = i; j <array.Length; j++)
                    {
                        redColumn = j;
                        if(array[j] < minValue)
                        {
                            minValue = array[j];
                            minIndex = j;
                        }
                    }
                    if(minValue < array[i])
                    {
                        Thread.Sleep(3 * sleepTime);
                        //repaint
                        myForm.Refresh();
                        redColumn = i;
                        //repaint
                        myForm.Refresh();
                        Thread.Sleep(4 * sleepTime);
                        temp = array[i];
                        array[i] = array[minIndex];
                        array[minIndex] = temp;
                    }
                }
                redColumn = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            myForm.Refresh();
        }
    }
}
