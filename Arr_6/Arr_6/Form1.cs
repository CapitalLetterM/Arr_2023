using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int[] arr = fillArr(textBoxIn.Text);
            textBoxUnique.Text = unique(arr).ToString();
            textBoxOut.Text = show(arr);
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
        private int unique(int[] arr)
        {
            Stack<int> el = new Stack<int>();
            el.Push(arr[0]);
            int uNumbers = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] != el.Peek())
                {
                    el.Push(arr[i]);
                }
            }
            int[] newArr = new int[el.Count];
            uNumbers = el.Count;
            for(int i = el.Count - 1; i >= 0; i--)
            {
                newArr[i] = el.Pop();
            }
            for(int i = 0; i < arr.Length; i++)
            {
                if(i < newArr.Length)
                {
                    arr[i] = newArr[i];
                }
                else
                {
                    arr[i] = 0;
                }
            }
            return uNumbers;
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
