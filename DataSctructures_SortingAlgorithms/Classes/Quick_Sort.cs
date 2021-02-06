using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DataSctructures_SortingAlgorithms.Classes
{
    public class Quick_Sort : SortPanel
    {
        private Form myForm;
        public Quick_Sort(Form form, string title, int w, int h) : base(title, w, h)
        {
            this.Initialize_Array();
            this.myForm = form;
        }
        //TODO for Final Project 2 (Final Evaluation)


        private void QuickSort(int[] arr, int start, int end)
        {
            int i;
            redColumn = -1;
            if (start < end)
            {
                i = Partition(arr, start, end);
                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
                greenColumn = end;
                myForm.Refresh();

            }
        }

        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;
            for (int j = start; j <= end - 1; j++)
            {
                redColumn = j;
                if (arr[j] <= p)
                {
                    Thread.Sleep(3 * sleepTime);
                    myForm.Refresh();
                    myForm.Refresh();
                    Thread.Sleep(4 * sleepTime);
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            redColumn = -1;
            myForm.Refresh();
            return i + 1;
        }

        public override void Run()
        {
            QuickSort(array, 0, array.Length-1);
        }
    }
}
