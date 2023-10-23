using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = countNumbers(fillArr(textBoxIn.Text)).ToString();
        }

        private int[] fillArr(string text)
        {
            Queue<int> q = new Queue<int>();
            string temp = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text, i) == true)
                {
                    temp += text[i];
                }
                else
                {
                    if(temp != "")
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
        private int countNumbers(int[] numbers)
        {
            int total = 0;
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                if(current == 0)
                {
                    count++;
                }
                while(current != 0)
                {
                    current = current / 10;
                    count++;
                }
                if(count % 2 == 0 && count != 0)
                {
                    total++;
                }
                count = 0;
            }
            return total;
        }
    }
}
