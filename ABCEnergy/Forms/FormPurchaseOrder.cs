using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

/*The Purchase Order Form item code. Here all elements that are used within this page are programmed. This includes code that manipulates the
 data grid view object used to display records of Purchase Orders that have been saved. Through using a number of tools for data input, buttons
 are used to create, read, update and delete purchase orders.*/


namespace ABCEnergy.Forms
{
    public partial class FormPurchaseOrder : Form
    {

        private int speechRate = 0;
        private int speechVolume = 50;

        public FormPurchaseOrder()
        {
            InitializeComponent();

            //bindData is called to display current purchase orders saved in the SQL database
            bindData();

            label_speechRate.Text = speechRate.ToString(CultureInfo.InvariantCulture);
            label_speechRate.Text = speechVolume.ToString(CultureInfo.InvariantCulture);
            AddInstalledVoicesToList();
        }

        private void FormPurchaseOrder_Load(object sender, EventArgs e)
        {
            //When the form is loaded, themes used for the UI are loaded
            LoadTheme();
        }


        //Load theme uses a for each loop to attain the buttons available in the form and manipulate the appearence to fit the rest of the UI
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
        }


        /*Allow for a connection between the application and the database through a connection string.
         The connection string contains the information that the provider needs to know to establish a connection
         to the database. Connection string is defines due to its constant use throughout functions, these functions
         are accessing the same declaration*/
        SqlConnection con = new SqlConnection("Data Source=THE_BEAST_00;Initial Catalog=ABCEnergy;Integrated Security=True");


        /*Bind data establishes a connection with a specific table within the database. The specific use of bind data in this form fills
         the data view grid with stored information in the database, it is called to refresh values in the database to display values after 
         changes have occured when using the application*/
        void bindData()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from ABCEnergy_PurchaseOrders_", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt); //TODO: Fix Crash On this line
                dataGridView1.DataSource = dt;
            }
            catch
            {
                dataGridView1.DataSource = new DataTable();
            }
        }


        /*This function is called when the insert button within this form is pressed. This function creats and inserts data entered by a user
         into the database.*/
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                //Open and establish a connection with the database
                con.Open();

                /*SqlCommand allows for the combination of SQl and C# to amend the database. Here we use the INSERT command to take the values
                 entered by the user in relevant fields, and where neccasry parsing that data to be entered into the database as the correct
                 datatypes.*/
                SqlCommand command = new SqlCommand("insert into ABCEnergy_PurchaseOrders_ values('" + int.Parse(textBox_PON.Text) + "','" + DateTime.Parse(dateTimePicker_POD.Text)
                                                                                        + "','" + DateTime.Parse(dateTimePicker_DD.Text)
                                                                                        + "','" + int.Parse(textBox_Quantity.Text)
                                                                                        + "','" + textBox_Supplier.Text
                                                                                        + "','" + float.Parse(textBox_OrderTotal.Text)
                                                                                        + "','" + comboBox_Approval.Text + "')", con);

                //The query is executed
                command.ExecuteNonQuery();

                //Alert the user of successfull database insertion
                MessageBox.Show("Successfully inserted.");

                //close the connection as it is no longer needed
                con.Close();
            }
            catch
            {
                MessageBox.Show("DATABASE ERROR - Insert Failed");
            }

            //call bindData to update and display the data view with the new inserted data
            bindData();
        }

        /*Function is called when the update button is clicked. Based on the purchase order which is used a unique identifier,
         a purchase order record is allowed to be updated base on the users input*/
        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                //Open and establish a connection with the database
                con.Open();

                /*SqlCommand used to declare a query with C# variables. Here an "UPDATE SET WHERE" qeury is formulated. Based on existing variables,
                 the table is updated setting current collumns equal to the variables in this form. These collumns are identified using the 
                 Purchase Order Number as the unique identifier*/
                SqlCommand cmd = new SqlCommand("Update ABCEnergy_PurchaseOrders_ set PurchaseOrderDate=@PurchaseOrderDate, Quantity = @Quantity, Supplier = @Supplier, OrderTotal = @OrderTotal, Approval = @Approval WHERE PurchaseOrderNumber = @PurchaseOrderNumber", con);

                /*Where needed, parsing the relevant information and assinging them in the sqlcommand string to set its respective ocject in the 
                 database*/
                cmd.Parameters.AddWithValue("@PurchaseOrderNumber", int.Parse(textBox_PON.Text));
                cmd.Parameters.AddWithValue("@PurchaseOrderDate", DateTime.Parse(dateTimePicker_POD.Text));
                cmd.Parameters.AddWithValue("@DeliveryDate", DateTime.Parse(dateTimePicker_DD.Text));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox_Quantity.Text));
                cmd.Parameters.AddWithValue("@Supplier", textBox_Supplier.Text);
                cmd.Parameters.AddWithValue("@OrderTotal", float.Parse(textBox_OrderTotal.Text));
                cmd.Parameters.AddWithValue("@Approval", comboBox_Approval.Text);

                //The query is executed
                cmd.ExecuteNonQuery();

                //Alert the user of successfully updating the database
                MessageBox.Show("Successfully Updated");

                //close the connection as it is no longer needed
                con.Close();
            }
            catch
            {
                MessageBox.Show("DATABASE ERROR - Update Failed");
            }

            //call bindData to update and display the data view with the new inserted data
            bindData();
        }


        /*Delete Purchase Order function. Allows for the deletion of a purchase order record given the Purchase Order Number
         used as the unique identifer.*/
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            //Statement checks to ensure a Purchase Order Number is entered. If so then delete the record otherwise alert the user of an error
            if (textBox_PON.Text != "")
            {
                /*Check to ensure the user wants to delete the purchase order. Message box is used to carry out this question.
                 If yes then delete the record, otherwise leave it.*/
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Purchase Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //Open and establish a connection with the database
                        con.Open();

                        //Using a DELETE WHERE sql command to identify the record linked with the purchase order number
                        SqlCommand command = new SqlCommand("Delete ABCEnergy_PurchaseOrders_ where PurchaseOrderNumber = '" + int.Parse(textBox_PON.Text) + "'", con);

                        //The query is executed
                        command.ExecuteNonQuery();

                        //close the connection as it is no longer needed
                        con.Close();

                        //Alert the user of successfully deletion
                        MessageBox.Show("Successfully deleted purchase order");
                    }
                    catch
                    {
                        MessageBox.Show("DATABASE ERROR - Deltetion Falied");
                    }

                    //call bindData to update and display the data view with the new inserted data
                    bindData();
                }
            }
            else
            {
                MessageBox.Show("Requires Purchase Order Number");
            }
        }


        //Function to search specific purchase orders based on Purchase Order Number
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from ABCEnergy_PurchaseOrders_ where PurchaseOrderNumber = '" + int.Parse(textBox_PON.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                dataGridView1.DataSource = new DataTable();
                MessageBox.Show("DATABASE ERROR - Search Failed");
            }
        }

        SpeechSynthesizer reader = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();

        private void Btn_speak_Click(object sender, EventArgs e)
        {
            if((textBox_PON.Text != null) && (dateTimePicker_POD.Text != null) && (dateTimePicker_DD.Text != null) && (textBox_Quantity.Text != null) && (textBox_Supplier.Text != null) && (textBox_OrderTotal.Text != null) && (comboBox_Approval.Text != null))
            {
                using (SpeechSynthesizer synth = new SpeechSynthesizer { Volume = speechVolume, Rate = speechRate })
                {
                    synth.SelectVoice(ddlVoices.Text);
                    //synth.Dispose();
                    //synth = new SpeechSynthesizer();
                    synth.Speak(PO_label_editor.Text);
                    synth.Speak(textBox_PON.Text);

                    synth.Speak(label5.Text);
                    synth.Speak(dateTimePicker_POD.Text);

                    synth.Speak(label4.Text);
                    synth.Speak(dateTimePicker_DD.Text);

                    synth.Speak(label2.Text);
                    synth.Speak(textBox_Quantity.Text);

                    synth.Speak(label3.Text);
                    synth.Speak(textBox_Supplier.Text);

                    synth.Speak(label1.Text);
                    synth.Speak(textBox_OrderTotal.Text);

                    synth.Speak(label6.Text);
                    synth.Speak(comboBox_Approval.Text);
                    
                }

            }
            else
            {
                MessageBox.Show("Please eneter text first!");
            }
        }
        private void Btn_pause_Click(object sender, EventArgs e)
        {
            if(reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }
        private void Btn_resume_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }
        private void Btn_stop_Click(object sender, EventArgs e)
        {
            if(reader != null)
            {
                reader.Dispose();
            }
        }
        private void TrackBar_SpeechRate_Scroll(object sender, EventArgs e)
        {
            speechRate = trackBar_SpeechRate.Value;
            label_speechRate.Text = speechRate.ToString(CultureInfo.InvariantCulture);

        }
        private void TrackBar_Volume_Scroll(object sender, EventArgs e)
        {
            speechVolume = trackBar_Volume.Value;
            label_volume.Text = speechVolume.ToString(CultureInfo.InvariantCulture);
        }
        private void AddInstalledVoicesToList()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (var voice in synth.GetInstalledVoices())
                {
                    ddlVoices.Items.Add(voice.VoiceInfo.Name);
                }
            }

            ddlVoices.SelectedIndex = 0;
        }

        private void TextBox_OrderTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_Approval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_DD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_POD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_PON_TextChanged(object sender, EventArgs e)
        {

        }

        private void PO_label_editor_Click(object sender, EventArgs e)
        {

        }

        private void Btn_listen_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            btn_stop_listen.Enabled = true;
            //clist.Add(new string[] { "hello1", "hello2", "hello3", "hello4" });
            //Grammar gr = new Grammar(new GrammarBuilder(clist));
            Grammar gr = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex ) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox_PON.Text = textBox_PON + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void stopListening()
        {
            sre.RecognizeAsyncStop();
            btn_listen.Enabled = true;
            btn_stop_listen.Enabled = false;
        }

        private void Btn_stop_listen_Click(object sender, EventArgs e)
        {
            stopListening();
            //sre.RecognizeAsyncStop();
            //btn_listen.Enabled = true;
            //btn_stop_listen.Enabled = false;
        }

        private void Btn_Listen_POD_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            btn_stop_listen.Enabled = true;
            Grammar gr = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized_POD;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void sre_SpeechRecognized_POD(object sender, SpeechRecognizedEventArgs e)
        {
            dateTimePicker_POD.Text = dateTimePicker_POD + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void Btn_Listen_DD_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            btn_stop_listen.Enabled = true;
            Grammar gr = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized_DD;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }
        private void sre_SpeechRecognized_DD(object sender, SpeechRecognizedEventArgs e)
        {
            dateTimePicker_DD.Text = dateTimePicker_DD + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void Btn_Listen_Quantity_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            btn_stop_listen.Enabled = true;
            Grammar gr = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized_Quanitity;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }
        private void sre_SpeechRecognized_Quanitity(object sender, SpeechRecognizedEventArgs e)
        {
            textBox_Quantity.Text = textBox_Quantity + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void Btn_Listen_Supplier_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            btn_stop_listen.Enabled = true;
            Grammar gr = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized_Supplier;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void sre_SpeechRecognized_Supplier(object sender, SpeechRecognizedEventArgs e)
        {
            textBox_Supplier.Text = textBox_Supplier + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void Btn_Listen_OrderTotal_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            btn_stop_listen.Enabled = true;
            Grammar gr = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized_OrderTotal;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }
        private void sre_SpeechRecognized_OrderTotal(object sender, SpeechRecognizedEventArgs e)
        {
            textBox_OrderTotal.Text = textBox_OrderTotal + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void Btn_Listen_Approval_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            btn_stop_listen.Enabled = true;
            clist.Add(new string[] { "Approved", "Not Approved" });
            Grammar gr = new Grammar(new GrammarBuilder(clist));
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized_Approval;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }
        private void sre_SpeechRecognized_Approval(object sender, SpeechRecognizedEventArgs e)
        {
            comboBox_Approval.Text = comboBox_Approval + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void Btn_stopListening_POD_Click(object sender, EventArgs e)
        {
            stopListening();
        }

        private void Btn_stopListening_DD_Click(object sender, EventArgs e)
        {
            stopListening();
        }

        private void Btn_stopListening_Quantity_Click(object sender, EventArgs e)
        {
            stopListening();
        }

        private void Btn_stopListening_Supplier_Click(object sender, EventArgs e)
        {
            stopListening();
        }

        private void Btn_stopListening_OrderTotal_Click(object sender, EventArgs e)
        {
            stopListening();
        }

        private void Btn_stopListening_Approval_Click(object sender, EventArgs e)
        {
            stopListening();
        }
    }
}
