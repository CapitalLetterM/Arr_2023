using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = show(sort(square(fillArr(textBoxIn.Text))));
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
        private int[] square(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
            }
            return arr;

        }

        //потрібна функція
        private int[] sort(int[] arr)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                int item = arr[i];
                int currentIndex = i;

                while (currentIndex > 0 && arr[currentIndex - 1] > item)
                {
                    arr[currentIndex] = arr[currentIndex - 1];
                    currentIndex--;
                }

                arr[currentIndex] = item;
            }
            return arr;
        }

        private string show(int[] arr)
        {
            string text = "";
            for(int i = 0; i < arr.Length; i++)
            {
                text += arr[i];
                if(i != arr.Length - 1)
                {
                    text += ", ";
                }
            }
            return text;
        }
    }
}
