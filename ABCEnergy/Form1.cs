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

            //When initialized, the user cannot exit a child form as one is not open
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            //this.ControlBox = false;
        }

        //Methods

        /*Method used to randomly select a colour to be used on the UI theme. While loops allows for an index to traverse a list of colours
         so when the function is called, the index is increased giving a different colour from the previous caller*/
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
        public string User { get; set; }


        //Method used to set the theme and call methods to allow for a colour coordinated UI.
        private void ActivateButton(object btnSender)
        {
            if(User=="Public")
            {
                btnContracts.Visible = false;
                btnPurchaseOrder.Visible = false;
                btnQuote.Visible = false;
            }
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    //When a button is selected, it is disbaled so that the UI keeps the same theme
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

                    //Now the child form is open, make the exit visible
                    btnCloseChildForm.Visible = true;
                }
            }
        }


        /*Method used to disable the button once pressed, for each presvious button, a new theme is chosen to be applied when another button
        is activated, therefore, no form uses the same colour twice*/
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


        //Method to open the child form and apply current button theme to the child form theme
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


      ////////////////////////////////////////////////////////////////
      //Button commands to open child forms//
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

        //method to clode a child form when exit button is pressed
        private void BtnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }


        //reset the themes once a child form has been closed and user is returned to the menu
        private void Reset()
        {
            //disable the button
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
