using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPuzzle
{
    public partial class FmWin : Form
    {
        private Game g;
        public TabControl mytab;
        public TabPage mypage;

        public FmWin(TabControl tb, TabPage tp)
        {
            mytab = tb;
            mypage = tp;
            InitializeComponent();
            g = new Game();
            buNewGame.Click += BuNewGame_Click;
            
        }

        private void BuNewGame_Click(object? sender, EventArgs e)
        {
            g.DoReset();
            Close();
            mytab.SelectTab(mypage);
        }
    }
}
