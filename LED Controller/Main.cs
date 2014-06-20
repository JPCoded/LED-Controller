using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO.Ports;

namespace LED_Controller
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            populatePorts();
        }

        #region Custom Functions
        public Color HovCol(int red = 0, int green = 0, int blue = 0)
        {
            return Color.FromArgb(red, green, blue);
        }

        private void ChangeColor()
        {

            rgbHRed.iValue = cpcColors.HoverColor.R;
            rgbHGreen.iValue = cpcColors.HoverColor.G;
            rgbHBlue.iValue = cpcColors.HoverColor.B;
            pnlHoverColor.BackColor = cpcColors.HoverColor;
        }

        private void populatePorts()
        {
            //gets list of all connected ports
            string[] ports = SerialPort.GetPortNames();
            //remove previous entries so we don't get duplicate items
            tsmiPorts.DropDownItems.Clear();
            //need to clean this up to prevent memory leaks
            foreach (var port in ports)
            {
                ToolStripItem subPort = new ToolStripMenuItem(port);
                subPort.Click += subPort_Click;
                tsmiPorts.DropDownItems.Add(subPort);
            }
        }

        //TODO: Figure out way to uncheck any other ports that are already checked.
        void subPort_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            clickedItem.Checked = true;
            try
            {
                if (ArduinoPort.IsOpen)
                {
                    ArduinoPort.Close();
                }
                ArduinoPort.PortName = clickedItem.Text;
                ArduinoPort.Open();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No comm port selected");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error connecting to port " + clickedItem.Text + ". Make sure the Aruduino is connected or correct port selected.");
            }
            if (ArduinoPort.IsOpen)
            {
                tbsStatus.Text = "Connected to port: " + clickedItem.Text;
            }
        }

        private void ConvertToHex(char HS)
        {
            string hexValue = string.Empty;
            if (HS == 'H')
            {
                hexValue = ColorTranslator.ToHtml(pnlHoverColor.BackColor);
                htbHover.Text = hexValue.Replace("#", string.Empty);
            }
            else
            {
                hexValue = ColorTranslator.ToHtml(pnlSavedColor.BackColor);
                htbSaved.Text = hexValue.Replace("#", string.Empty);
            }

        }

        #endregion

        #region Toolbar Clicks
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Saved = Color.FromArgb(rgbSRed.iValue, rgbSGreen.iValue, rgbSBlue.iValue);
            Properties.Settings.Default.Hover = Color.FromArgb(rgbHRed.iValue, rgbHGreen.iValue, rgbHBlue.iValue);
            Properties.Settings.Default.Save();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            rgbHRed.iValue = Properties.Settings.Default.Hover.R;
            rgbHGreen.iValue = Properties.Settings.Default.Hover.G;
            rgbHBlue.iValue = Properties.Settings.Default.Hover.B;

            rgbSRed.iValue = Properties.Settings.Default.Saved.R;
            rgbSGreen.iValue = Properties.Settings.Default.Saved.G;
            rgbSBlue.iValue = Properties.Settings.Default.Saved.B;
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            populatePorts();
        }
        #endregion

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            if (grpHover.Visible)
            {
                grpSaved.Visible = false;
                grpHover.Visible = false;
                btnAdvance.Text = "More ->";
            }
            else
            {
                grpSaved.Visible = true;
                grpHover.Visible = true;
                btnAdvance.Text = "<- Less";
            }
        }

        #region cpcColors
        private void cpcColors_ColorPicked(object sender, EventArgs e)
        {
            pnlSavedColor.BackColor = cpcColors.SelectedColor;
            rgbSRed.iValue = cpcColors.SelectedColor.R;
            rgbSGreen.iValue = cpcColors.SelectedColor.G;
            rgbSBlue.iValue = cpcColors.SelectedColor.B;
        }

        private void cpcColors_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeColor();
        }

        #endregion

        #region rgbNUD ValueChanged
        private void rgbHRed_ValueChanged(object sender, EventArgs e)
        {
            pnlHoverColor.BackColor = Color.FromArgb(rgbHRed.iValue, rgbHGreen.iValue, rgbHBlue.iValue);
            pnlHRed.BackColor = HovCol(red: rgbHRed.iValue);
            ConvertToHex('H');
        }

        private void rgbHGreen_ValueChanged(object sender, EventArgs e)
        {
            pnlHoverColor.BackColor = Color.FromArgb(rgbHRed.iValue, rgbHGreen.iValue, rgbHBlue.iValue);
            pnlHGreen.BackColor = HovCol(green: rgbHGreen.iValue);
            ConvertToHex('H');
        }

        private void rgbHBlue_ValueChanged(object sender, EventArgs e)
        {
            pnlHoverColor.BackColor = Color.FromArgb(rgbHRed.iValue, rgbHGreen.iValue, rgbHBlue.iValue);
            pnlHBlue.BackColor = HovCol(blue: rgbHBlue.iValue);
            ConvertToHex('H');
        }

        private void rgbSRed_ValueChanged(object sender, EventArgs e)
        {
            pnlSavedColor.BackColor = Color.FromArgb(rgbSRed.iValue, rgbSGreen.iValue, rgbSBlue.iValue);
            pnlSRed.BackColor = HovCol(red: rgbSRed.iValue);
            ConvertToHex('S');
        }

        private void rgbSGreen_ValueChanged(object sender, EventArgs e)
        {
            pnlSavedColor.BackColor = Color.FromArgb(rgbSRed.iValue, rgbSGreen.iValue, rgbSBlue.iValue);
            pnlSGreen.BackColor = HovCol(green: rgbSGreen.iValue);
            ConvertToHex('S');
        }

        private void rgbSBlue_ValueChanged(object sender, EventArgs e)
        {
            pnlSavedColor.BackColor = Color.FromArgb(rgbSRed.iValue, rgbSGreen.iValue, rgbSBlue.iValue);
            pnlSBlue.BackColor = HovCol(blue: rgbSBlue.iValue);
            ConvertToHex('S');
        }
        #endregion

        private void btnSet_Click(object sender, EventArgs e)
        {

            byte[] colorBytes = { rgbSRed.getByte, rgbSGreen.getByte, rgbSBlue.getByte, 0x0A };

            if (ArduinoPort.IsOpen)
            {
                try
                {
                    ArduinoPort.Write(colorBytes, 0, 3);
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Failed to communicate with arduino. Make sure you have port selected.");
                }
            }
            else
            {
                MessageBox.Show("No Port is selected. Please select a port from Settings->Ports menu.");
            }

        }

        private void htbHover_TextChanged(object sender, EventArgs e)
        {
            if (htbHover.isLength)
            {
                rgbHRed.iValue = htbHover.Red;
                rgbHGreen.iValue = htbHover.Green;
                rgbHBlue.iValue = htbHover.Blue;
            }
        }

        private void htbSaved_TextChanged(object sender, EventArgs e)
        {
            if (htbSaved.isLength)
            {
                rgbSRed.iValue = htbSaved.Red;
                rgbSGreen.iValue = htbSaved.Green;
                rgbSBlue.iValue = htbSaved.Blue;
            }
        }

    }
}
