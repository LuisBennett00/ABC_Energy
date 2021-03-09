using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCEnergy
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        //Methods
        private Color SelectThemeColour()
        {
            int index = random.Next(ThemeColour.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColour.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColour.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColour();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.BackColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColour.ChangeColorBrightness(color, -0.3);
                    ThemeColour.PrimaryColor = color;
                    ThemeColour.SecondaryColor = ThemeColour.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }



        private void BtnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProducts(), sender);
        }

        private void BtnQuote_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuotes(), sender);
        }

        private void BtnPurchaseOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPurchaseOrder(), sender);
        }

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormContracts(), sender);
        }



        //////////////////////////////////////////////////////////////
        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void BtnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
    }
}
