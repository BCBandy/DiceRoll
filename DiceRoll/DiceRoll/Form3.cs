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
    public partial class Form3 : Form
    {
        form_stdDist mainForm;

        public Form3(form_stdDist mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.Location = new Point(
                                            mainForm.Location.X - 528,
                                            mainForm.Location.Y + mainForm.Height
                                        );
            chart1.Series.Clear();
            chart1.Series.Add("die1 * die2");
            chart1.Series.Add("die1 squared");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
