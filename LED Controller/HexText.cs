using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace LED_Controller
{
    public partial class HexTextBox : TextBox
    {

        [DefaultValue("000000")]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value.ToUpper(); }
        }
        public int Red
        {
            get
            {
                int num = (int)long.Parse(this.Text, NumberStyles.HexNumber);
                int r = (num & 0xFF0000) >> 16;
                return r;
            }
        }

        public int Green
        {
            get
            {
                int num = (int)long.Parse(this.Text, NumberStyles.HexNumber);
                int g = (num & 0xFF00) >> 8;
                return g;
            }
        }

        public int Blue
        {
            get
            {
                int num = (int)long.Parse(this.Text, NumberStyles.HexNumber);
                int b = num & 0xFF;
                return b;
            }
        }

        public bool isLength
        {
            get { return this.TextLength == 6 ? true : false; }
        }

        public HexTextBox()
            : base()
        {
            this.MaxLength = 6;
            this.Text = string.Empty;
            this.Width = 65;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            //multiple if else cause 1 long if statement would get to confusing
            if ((e.KeyChar >= 'A' || e.KeyChar >= 'a') && (e.KeyChar <= 'F' || e.KeyChar <= 'f'))
            {
                //Characters A or a through F or f are ok
            }
            else if(Char.IsDigit(e.KeyChar))
            {
                //digits ok
            }
            else if(e.KeyChar == '\b')
            {
                //backspace ok
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
