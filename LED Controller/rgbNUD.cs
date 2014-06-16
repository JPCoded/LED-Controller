using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace LED_Controller
{
    public class rgbNUD : NumericUpDown
    {
        public rgbNUD()
            : base()
        {
            this.Maximum = 255;
            this.Minimum = 0;
            this.Value = 0;
            this.Width = 40;
        }
        public int iValue
        {
            get { return Convert.ToInt32(base.Value); }
            set { base.Value = (decimal)value; }
        }

        public byte getByte
        {
            get { return (byte)base.Value; }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (Char.IsDigit(e.KeyChar))
            {
                int current = this.iValue;
                int newcurrent = Convert.ToInt32(e.KeyChar);
                if (newcurrent > 255)
                {
                    this.iValue = current;
                    // e.Handled = true; 
                }
                else if (newcurrent < 0)
                { this.iValue = 0; }
            }
            else if (e.KeyChar == '\b')
            { e.Handled = false; }
            else
            { e.Handled = true; }
        }
    }
}
