using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private double NumA;
        private String flag;
        private double NumB;
        private double NumC;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //String v_tB1 = textBox1.ToString();
            //NumA = (double)v_tB1;
            //NumA = double.Parse(v_tB1);
            //bool b = double.TryParse(v_tB1,out NumA);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //String v_tB2 = textBox2.ToString();
            //flag = v_tB2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           // String v_tB3 = textBox3.ToString();
           // NumB = (double)v_tB3;
            //NumB = double.TryParse(v_tB3);
            //bool b = double.TryParse(v_tB3,out NumB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String v_tB1 = textBox1.Text.ToString();
            NumA = double.Parse(v_tB1);
            String v_tB2 = textBox2.Text.ToString();
            flag = v_tB2;
            String v_tB3 = textBox3.Text.ToString();
            NumB = double.Parse(v_tB3);
            localhost.Service web = new localhost.Service();
            /*
            switch (flag)
            {
            case "+":
                NumC=web.addition(NumA, NumB);
            	break;
            case "-":
                NumC = web.subtract(NumA, NumB);
                break;
                case "*":
                NumC = web.multiplication(NumA, NumB);
                break;
                case "/":
                //NumC=NumA/NumB;
                NumC = web.division(NumA, NumB);
                break;

            }
            */
            if (flag.Equals("+"))
            {
                NumC = web.addition(NumA,NumB);
            }
            else if (flag.Equals("-"))
            {
                NumC= web.subtract(NumA, NumB);
            }
            else if (flag.Equals("*"))
            {
                NumC= web.multiplication(NumA,NumB);
            }
            else if (flag.Equals("/"))
            {
                NumC= web.division(NumA,NumB);
            }
            textBox4_TextChanged(sender,e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text =NumC+"";
        }
    }
}
