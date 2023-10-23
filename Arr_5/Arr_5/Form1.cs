using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int[] arr1 = fillArr(textBoxArr1.Text);
            int[] arr2 = fillArr(textBoxArr2.Text);
            merge(arr1, arr2, Convert.ToInt32(numericUpDownArrLength1.Value), Convert.ToInt32(numericUpDownArrLength2.Value));
            textBoxOut.Text = show(arr1);
        }

        private int[] fillArr(string text)
        {
            Queue<int> q = new Queue<int>();
            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text, i) == true || text[i] == '-')
                {
                    temp += text[i];
                }
                else
                {
                    if (temp != "")
                    {
                        q.Enqueue(Convert.ToInt32(temp));
                        temp = "";
                    }
                }
            }
            if (temp != "")
            {
                q.Enqueue(Convert.ToInt32(temp));
                temp = "";
            }
            int[] arr = new int[q.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = q.Dequeue();
            }
            return arr;
        }

        //потрібна функція
        private void merge(int[] arr1, int[] arr2, int length1, int length2)
        {
            for (int i = length1; i < length1 + length2; i++)
            {
                arr1[i] = arr2[i - length1];
            }
        }

        private string show(int[] arr)
        {
            string text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i];
                if (i != arr.Length - 1)
                {
                    text += ", ";
                }
            }
            return text;
        }
    }
}
