using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Test
{
    public partial class Form1 : Form
    {
        // tutorial found here: https://www.youtube.com/watch?v=csgO95sbSfA
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 0; i < 10; i++)
            {
                num++;
            }
        }
    }
}
