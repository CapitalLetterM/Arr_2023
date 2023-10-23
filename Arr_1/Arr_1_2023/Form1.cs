using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_1_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = countOnes(fillArr(textBoxIn.Text)).ToString();
        }

        private int[] fillArr(string text)
        {
            Queue<int> q = new Queue<int>();
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == '1')
                {
                    q.Enqueue(1);
                }
                else if (text[i] == '0')
                {
                    q.Enqueue(0);
                }
            }
            int[] arr = new int[q.Count];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = q.Dequeue();
            }
            return arr;
        }

        //потрібна функція
        private int countOnes(int[] arr)
        {
            int count = 0;
            int finalCount = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 1)
                {
                    count++;
                }
                else
                {
                    if(finalCount < count)
                    {
                        finalCount = count;
                    }
                    count = 0;
                }
            }
            return finalCount;
        }
    }
}
