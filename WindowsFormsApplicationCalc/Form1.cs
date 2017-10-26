using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Button btn = (Button)Sender;
//6 калькуляторов:
//3 с кнопками, 3 с 4 полями (как этот)

namespace WindowsFormsApplicationCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            char op = Convert.ToChar(txtOp.Text);
            try
            {
                int res = calc(a, b, op);
                txtRes.Text = Convert.ToString(res);
            }
            catch (DivideByZeroException)
            {
                txtRes.Text = "∞";
            }
        }
        public int calc(int a, int b, char op)
        {
            int res = 0;
            if (op == '+')
                res = a + b;
            if (op == '-')
                res = a - b;
            if (op == '*')
                res = a * b;
            if (op == '/')
                if (b == 0)
                    throw new DivideByZeroException();
            else
                res = a / b;
            return res;
        }
    }
}
