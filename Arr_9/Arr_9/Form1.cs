using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = show(replace(fillArr(textBoxIn.Text)));
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
        private int[] replace(int[] arr)
        {
            if(arr.Length == 0)
            {
                return arr;
            }
            int max = arr[arr.Length - 1];
            int temp = 0;
            arr[arr.Length - 1] = -1;
            if(arr.Length == 1)
            {
                return arr;
            }
            for(int i = arr.Length - 2; i >= 0; i--)
            {
                temp = arr[i];
                arr[i] = max;
                if(temp > max)
                {
                    max = temp;
                }
            }
            return arr;
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