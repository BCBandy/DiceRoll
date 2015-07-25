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
    public partial class FormSub : Form
    {
        form_stdDist mainForm;

        public FormSub(form_stdDist mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.Location = new Point(
                                            mainForm.Location.X + mainForm.Width,
                                            mainForm.Location.Y
                                        );
            chart1.Series.Clear();
            chart1.Series.Add("d1 - d2");
        }

        private void FormSub_Load(object sender, EventArgs e)
        {

        }
    }
}
