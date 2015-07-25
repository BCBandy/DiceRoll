using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form4 : Form
    {
        form_stdDist mainForm;

        public Form4(form_stdDist mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.Location = new Point(
                                            mainForm.Location.X - this.Width,
                                            mainForm.Location.Y
                                        );
            chart1.Series.Clear();
            chart1.Series.Add("N d1 sum");
            chart1.Series.Add("N x d1 face");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
