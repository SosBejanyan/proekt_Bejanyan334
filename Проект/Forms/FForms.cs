using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage2.Forms
{
    public partial class FForms : Form
    {
        //выбираем форму для просмотра
        public FForms()
        { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        { new FProductType().Show(); }

        private void button2_Click(object sender, EventArgs e)
        { new FProductInfo().Show(); }

        private void button3_Click(object sender, EventArgs e)
        { new FProductStore().Show(); }

        private void button4_Click(object sender, EventArgs e)
        { new FClient().Show(); }

        private void button5_Click(object sender, EventArgs e)
        { new FWorker().Show(); }

        private void button6_Click(object sender, EventArgs e)
        { new FBuying().Show(); }

        private void button7_Click(object sender, EventArgs e)
        { new FSale().Show(); }
    }
}
