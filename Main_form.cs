using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicTimeWarping
{
    public partial class Main_form : Form
    {
        DTWAlgorithm DTW_ = new DTWAlgorithm();
        List<float> graph1, graph2 = new List<float>();
        Pen Pen_blk = new Pen(Color.Black);
        Pen Pen_red = new Pen(Color.Red);

        SolidBrush Brush_blk = new SolidBrush(Color.Black);
        SolidBrush Brush_red = new SolidBrush(Color.Red);
        SolidBrush Brush_grn = new SolidBrush(Color.Green);
        SolidBrush Brush_blu = new SolidBrush(Color.Blue);

        public Main_form()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Show_Graph1.Refresh();
            Show_Graph2.Refresh();

            Statement_line.Text = "Generating ....";

            Generate.Enabled = false;
            Size_1.Enabled = false;
            Size_2.Enabled = false;
            Limit_1.Enabled = false;
            Limit_2.Enabled = false;

            System.Threading.Thread.Sleep(1);

            int n1, n2, l1, l2;

            n1 = text_int(Size_1);
            n2 = text_int(Size_2);
            l1 = text_int(Limit_1);
            l2 = text_int(Limit_2);

            graph1 = DTW_.Initializer(l1, n1);
            graph2 = DTW_.Initializer(l2, n2);

            Graphics g1 = Show_Graph1.CreateGraphics();
            Graphics g2 = Show_Graph2.CreateGraphics();

            liner(n1, l1, graph1, g1, false);
            liner(n2, l2, graph2, g2, true);

            Statement_line.Text = "Completely Generated !!";
            Process.Enabled = true;
        }
        private void Process_Click(object sender, EventArgs e)
        {
            
            Result_Graph.Controls.Clear();
            Statement_line.Text = "Processing ...";
            Process.Enabled = false;
            System.Threading.Thread.Sleep(1);

            Graphics g = Result_Graph.CreateGraphics();

            List<List<float>> Temp = new List<List<float>>();
            Temp = DTW_.DTWDistance(graph1, graph2);

            int n1, n2;
            n1 = graph1.Count;
            n2 = graph2.Count;
            float x, y;
            float x_size = 1.0f / (n1 - 1) * 400;
            float y_size = 1.0f / (n2 - 1) * 400;

            for (int i = 1; i < n1; i++)
            {
                for (int j = 1; j < n2; j++)
                {
                    x = (i - 0.9f) / (n1-1) * 450;
                    y = (j - 0.9f) / (n2-1) * 450;
                    Label tmp_label = new Label();
                    tmp_label.Location = new Point((int)x ,(int)y);
                    tmp_label.Size = new Size((int)x_size ,(int)y_size);
                    tmp_label.Name = Convert.ToString(Temp[i][j]);
                    tmp_label.Text = Convert.ToString(Temp[i][j]);
                    Result_Graph.Controls.Add(tmp_label);
                }
            }

            
            Resultbox.Text = Convert.ToString(Temp[graph1.Count-1][graph2.Count-1]);

            Statement_line.Text = "Completely Processed ...";

            Generate.Enabled = true;
            Size_1.Enabled = true;
            Size_2.Enabled = true;
            Limit_1.Enabled = true;
            Limit_2.Enabled = true;

        }

        void liner(int n, int l, List<float> graph, Graphics g , bool rotate)
        {
            if (rotate == true)
            {
                for (int i = 1; i < n; i++)
                {
                    g.DrawLine(Pen_blk, 
                        100 - graph[i - 1] / (l-1) * 100, 450 - (float)(i-1)/(n-1) * 450, 
                        100 - graph[i] / (l-1) * 100, 450 - (float)i/(n-1) * 450);
                }
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    g.DrawLine(Pen_red, 
                        (float)(i-1)/(n-1)*450, 100 - graph[i-1] / (l-1) * 100, 
                        (float)i/(n-1) * 450,  100 - graph[i] / (l-1) * 100);
                }
            }

        }
        int text_int(TextBox T)
        {
            return Convert.ToInt32(T.Text);
        }

        private void Size_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) 
            {
                e.Handled = true;
            }
        }
        private void Size_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void Limit_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void Limit_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

    }
}
