﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sledge.Editor.Tools.VMTools
{
    public partial class EditFaceControl : UserControl
    {
        public delegate void PokeEventHandler(object sender, int num);
        public delegate void BevelEventHandler(object sender, int num);

        public event PokeEventHandler Poke;
        public event BevelEventHandler Bevel;

        protected virtual void OnPoke(int num)
        {
            if (Poke != null)
            {
                Poke(this, num);
            }
        }

        protected virtual void OnBevel(int num)
        {
            if (Bevel != null)
            {
                Bevel(this, num);
            }
        }

        public EditFaceControl()
        {
            InitializeComponent();
        }

        private void BevelButtonClicked(object sender, EventArgs e)
        {
            OnBevel((int)BevelValue.Value);
        }

        private void PokeFaceButtonClicked(object sender, EventArgs e)
        {
            OnPoke((int)PokeFaceCount.Value);
        }
    }
}
