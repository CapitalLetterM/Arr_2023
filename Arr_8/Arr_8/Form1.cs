using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if(mountain(fillArr(textBoxIn.Text)) == true)
            {
                textBoxOut.Text = "Комбінація підходить";
            }
            else
            {
                textBoxOut.Text = "Комбінація не підходить";
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
        private bool mountain(int[] arr)
        {
            if(arr.Length < 4)
            {
                return false;
            }
            int current = arr[0];
            bool increase = false;
            bool decreace = false;
            for (int i = 1; i < arr.Length; i++)
            {
                if (decreace == false)
                {
                    if(current < arr[i])
                    {
                        increase = true;
                        current = arr[i];
                    }
                    else
                    {
                        decreace = true;
                    }
                }
                else
                {
                    if(arr[i] < current)
                    {
                        current = arr[i];
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if(increase == true && decreace == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
