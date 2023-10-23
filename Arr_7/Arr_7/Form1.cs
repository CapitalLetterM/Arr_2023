using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = "";
            if (findDouble(fillArr(textBoxIn.Text)) == true)
            {
                textBoxResult.Text = "Існують елементи що відповідають умовам";
            }
            else
            {
                textBoxResult.Text = "Не існує елементів що відповідають умовам";
            }
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
        private bool findDouble(int[] arr)
        {
            bool exists = false;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == 2 * arr[j])
                    {
                        textBoxOut.Text += "arr[" + i + "]:" + arr[i] + " | arr[" + j + "]:" + arr[j] + ";";
                        exists = true;
                    }
                }
            }
            return exists;
        }
    }
}
