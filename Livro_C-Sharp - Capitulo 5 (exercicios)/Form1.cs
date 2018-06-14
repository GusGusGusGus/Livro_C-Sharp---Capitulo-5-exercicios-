using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livro_C_Sharp___Capitulo_5__exercicios_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult resposta;

            MessageBox.Show("Só faz OK..", "Aquele título", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Faz OK e Cancel..", "Aquele título", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Faz Abort, Retry e Ignore..", "Aquele título", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            MessageBox.Show("Faz Yes, No, Cancel..", "Aquele título", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            MessageBox.Show("Faz Yes e No..", "Aquele título", MessageBoxButtons.YesNo);
            resposta = MessageBox.Show("Fechar aplicação?", "Aquele título", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show("Escolheu o botão..."+ resposta.ToString()+".", "Aquele título FINAL", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
