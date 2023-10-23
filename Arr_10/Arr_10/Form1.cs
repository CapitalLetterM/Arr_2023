using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = show(sort(fillArr(textBoxIn.Text)));
        }

        private int[] fillArr(string text)
        {
            Queue<int> q = new Queue<int>();
            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text, i) == true)
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
        private int[] sort(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int last = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    temp[last] = arr[i];
                    last++;
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 1)
                {
                    temp[last] = arr[i];
                    last++;
                }
            }
            return temp;
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
