using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = show(fillArr(textBoxIn.Text));
        }

        //потрібна функція
        private int[] fillArr(string text)
        {
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if(char.IsNumber(text, i))
                {
                    if(text[i] == '0')
                    {
                        q.Enqueue(0);
                    }
                    q.Enqueue(Convert.ToInt32(text[i].ToString()));
                }
            }
            int[] arr = new int[q.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = q.Dequeue();
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
