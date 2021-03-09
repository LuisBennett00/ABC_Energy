using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCEnergy.Forms
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            //LoadTheme();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColour.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColour.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColour.SecondaryColor;
            label5.ForeColor = ThemeColour.PrimaryColor;
        }
    }
}
