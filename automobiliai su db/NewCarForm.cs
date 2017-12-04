using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automobiliai_su_db
{
    public partial class NewCarForm : Form
    {
        public Car Car { get; private set; }

        public NewCarForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var make = textBoxMake.Text;
            var model = textBoxModel.Text;
            var year = Convert.ToInt32(textBoxYear.Text);
            var mileage = Convert.ToInt32(textBoxMileage.Text);

            Car = new Car(make, model, year, mileage);
        }
    }
}
