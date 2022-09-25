﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolvingTheEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private double borderA, borderB, stepH, epsE;
        List<(double X1, double X2)> segments;
        Method.Func func;
        Method.DFunc dfunc;

        private void minimumX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && minimumX.SelectionStart == 0) { }
            else
            {
                if (e.KeyChar == 46) e.KeyChar = ',';
                if ((e.KeyChar == 44 || e.KeyChar == 46) && minimumX.SelectionStart > (minimumX.Text.IndexOf('-') == 0 ? 1 : 0))
                {
                    if (minimumX.Text.IndexOf(',') > 0)
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                        {
                            e.Handled = true;
                        }
                    }
                }
                else
                {
                    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void maximumX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && maximumX.SelectionStart == 0) { }
            else
            {
                if (e.KeyChar == 46) e.KeyChar = ',';
                if ((e.KeyChar == 44 || e.KeyChar == 46) && maximumX.SelectionStart > (maximumX.Text.IndexOf('-') == 0 ? 1 : 0))
                {
                    if (maximumX.Text.IndexOf(',') > 0)
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                        {
                            e.Handled = true;
                        }
                    }
                }
                else
                {
                    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void step_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && step.SelectionStart == 0) { }
            else
            {
                if (e.KeyChar == 46) e.KeyChar = ',';
                if ((e.KeyChar == 44 || e.KeyChar == 46) && step.SelectionStart > (step.Text.IndexOf('-') == 0 ? 1 : 0))
                {
                    if (step.Text.IndexOf(',') > 0)
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                        {
                            e.Handled = true;
                        }
                    }
                }
                else
                {
                    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void epsilon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 && epsilon.SelectionStart == 0) { }
            else
            {
                if (e.KeyChar == 46) e.KeyChar = ',';
                if ((e.KeyChar == 44 || e.KeyChar == 46) && epsilon.SelectionStart > (epsilon.Text.IndexOf('-') == 0 ? 1 : 0))
                {
                    if (epsilon.Text.IndexOf(',') > 0)
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                        {
                            e.Handled = true;
                        }
                    }
                }
                else
                {
                    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void build_Click(object sender, EventArgs e)
        {
            double.TryParse(minimumX.Text, out borderA);
            double.TryParse(maximumX.Text, out borderB);
            double.TryParse(step.Text, out stepH);
            graph.Series[0].Points.Clear();
            graph.Series[1].Points.Clear();
            graph.ChartAreas[0].AxisX.Minimum = borderA;
            graph.ChartAreas[0].AxisX.Maximum = borderB;
            double y, fb, buffer = borderA;
            segments = new List<(double X1, double X2)>();
            Condition();
            for (double x = borderA; x <= borderB; x += stepH)
            {
                y = func(x);
                graph.Series[0].Points.AddXY(x, y);
                fb = func(buffer);
                if (y * fb <= 0)
                {
                    segments.Add((buffer, x));
                    graph.Series[1].Points.AddXY((buffer * y - fb * x) / (y - fb), 0);
                }
                buffer = x;
            }
        }
        private void Condition()
        {
            int.TryParse(number.Text, out int condition);
            switch (condition)
            {
                case 1: func = Method.Function1; dfunc = Method.DFunction1; break;
                case 2: func = Method.Function2; dfunc = Method.DFunction2; break;
                case 3: func = Method.Function3; dfunc = Method.DFunction3; break;
                case 4: func = Method.Function4; dfunc = Method.DFunction4; break;
                case 5: func = Method.Function5; dfunc = Method.DFunction5; break;
                case 6: func = Method.Function6; dfunc = Method.DFunction6; break;
                case 7: func = Method.Function7; dfunc = Method.DFunction7; break;
                case 8: func = Method.Function8; dfunc = Method.DFunction8; break;
                case 9: func = Method.Function9; dfunc = Method.DFunction9; break;
                case 10: func = Method.Function10; dfunc = Method.DFunction10; break;
                case 11: func = Method.Function11; dfunc = Method.DFunction11; break;
                case 12: func = Method.Function12; dfunc = Method.DFunction12; break;
                case 13: func = Method.Function13; dfunc = Method.DFunction13; break;
            }
        }

        private void solving_Click(object sender, EventArgs e)
        {
            double.TryParse(epsilon.Text, out epsE);
            roots.Clear();
            double root;
            if (methodBisection.Checked)
            {
                foreach (var item in segments)
                {
                    root = Method.Bisection(func, item.X1, item.X2, epsE);
                    roots.Text += $"x = {root}" + Environment.NewLine + $"f(x) = {func(root)}" + Environment.NewLine + $"[{item.X1}; {item.X2}]" + Environment.NewLine + Environment.NewLine;
                }
            }
            if (methodNewton.Checked)
            {
                foreach (var item in segments)
                {
                    root = Method.Newton(func, dfunc, item.X1, epsE);
                    roots.Text += $"x = {root}" + Environment.NewLine + $"f(x) = {func(root)}" + Environment.NewLine + $"[{item.X1}; {item.X2}]" + Environment.NewLine + Environment.NewLine;
                }
            }
            if (methodChord.Checked)
            {
                foreach (var item in segments)
                {
                    root = Method.Chord(func, item.X1, item.X2, epsE);
                    roots.Text += $"x = {root}" + Environment.NewLine + $"f(x) = {func(root)}" + Environment.NewLine + $"[{item.X1}; {item.X2}]" + Environment.NewLine + Environment.NewLine;
                }
            }
        }
    }
}
