using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public partial class WalcomeForm : Form
    {
        public WalcomeForm()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            LabirintForm labirintForm = new LabirintForm();
            labirintForm.OpenLevel(1);
            labirintForm.ShowDialog();
        }
    }
}
