using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BWS.ERP.BaseForm;

namespace BWSERP
{
    public partial class Form2 : BWS.ERP.BaseForm.frmBaseForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BWS.ERP.BaseControl.Public.SystemInfo("是否关闭？", 4) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void bwsFlowChart1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (radioGroup1.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        bwsFlowChart1.AddFlowChartItem("hah", new Rectangle(X, Y, Math.Abs(e.X - X), Math.Abs(e.Y - Y)), Color.Gray, Color.Red, Color.Blue, "ha", "", "", null, DefaultFont);
                        break;
                    }
                case 2:
                    {
                        bwsFlowChart1.AddFlowChartLine(new Point(X, Y), new Point(e.X, e.Y));
                        break;
                    }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bwsFlowChart1.AddFlowChartItem("hah", new Rectangle(0, 0, 100, 60), Color.Gray, Color.Red, Color.Blue, "ha", "", "", null, DefaultFont);
        }

        int X = 0;
        int Y = 0;
        private void bwsFlowChart1_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }
    }
}
