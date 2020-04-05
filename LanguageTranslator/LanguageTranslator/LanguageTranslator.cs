using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTranslator
{
    public partial class LangTranslatorForm : Form
    {
        public LangTranslatorForm()
        {
            InitializeComponent();
        }

   
        private void btnSpanish_Click_1(object sender, EventArgs e)
        {
            lblTranslation.Text = "Bueno Dias";
            this.BackColor = Color.DarkSalmon;
        }

        private void btnGerman_Click_1(object sender, EventArgs e)
        {
            lblTranslation.Text = "Guten Morgan";
            this.BackColor = Color.Firebrick;
        }

        private void btnItailan_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Buongiorno";
            this.BackColor = Color.CornflowerBlue;
        }
    }
}
