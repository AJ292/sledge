﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sledge.Editor.Brushes.Controls
{
    public partial class NumericControl : BrushControl
    {
        public decimal Minimum
        {
            get { return Numeric.Minimum; }
            set { Numeric.Minimum = value; }
        }

        public decimal Maximum
        {
            get { return Numeric.Maximum; }
            set { Numeric.Maximum = value; }
        }

        public decimal Value
        {
            get { return Numeric.Value; }
            set { Numeric.Value = value; }
        }

        public string LabelText
        {
            get { return Label.Text; }
            set { Label.Text = value; }
        }

        public bool ControlEnabled
        {
            get { return Numeric.Enabled; }
            set { Numeric.Enabled = value; }
        }

        public NumericControl(IBrush brush) : base(brush)
        {
            InitializeComponent();
        }

        public decimal GetValue()
        {
            return Numeric.Value;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            OnValuesChanged(Brush);
        }
    }
}
