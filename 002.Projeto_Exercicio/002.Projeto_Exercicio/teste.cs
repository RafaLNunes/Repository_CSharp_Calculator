﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _002.Projeto_Exercicio
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {
            home hm = new home();

            // Add the MenuStrip to the form.
            this.Controls.Add(hm.vemhome());
        }
    }
}
