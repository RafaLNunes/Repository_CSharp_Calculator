﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002.Projeto_Exercicio
{
    public partial class FrmTamanhoCamiseta : Form
    {

        cltamanhocamiseta cltc = new cltamanhocamiseta();
        public FrmTamanhoCamiseta()
        {
            InitializeComponent();
        }

        private void FrmTamanhoCamiseta_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cltc.tamanho_camiseta(textAlt, textLarg));
        }
    }
}
