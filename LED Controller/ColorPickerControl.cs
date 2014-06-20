using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing;

// Original is AboControls.ExtendedControls. Was modified by me to work better with my project.
namespace LED_Controller
{
    [DefaultEvent("ColorPicked")]
    public class ColorPickerControl : Control
    {


        private Bitmap _canvas;
        private Graphics _graphicsBuffer;
        private LinearGradientBrush _spectrumGradient, _blackBottomGradient, _whiteTopGradient;
        public event EventHandler ColorPicked;

        public ColorPickerControl()
        {
            base.Cursor = Cursors.Hand;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);

            this.Size = new Size(200, 100);
            UpdateLinearGradientBrushes();
            UpdateGraphicsBuffer();
        }

        protected virtual void OnColorPicked()
        {
            if (ColorPicked != null)
                ColorPicked(this, EventArgs.Empty);
        }


        private void UpdateLinearGradientBrushes()
        {
            // Update spectrum gradient
            _spectrumGradient = new LinearGradientBrush(Point.Empty, new Point(this.Width, 0), Color.White, Color.White);
            ColorBlend blend = new ColorBlend();
            blend.Positions = new[] { 0, 1 / 7f, 2 / 7f, 3 / 7f, 4 / 7f, 5 / 7f, 6 / 7f, 1 };
            blend.Colors = new[] { Color.Gray, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
            _spectrumGradient.InterpolationColors = blend;
            // Update greyscale gradient
            RectangleF rect = new RectangleF(0, this.Height * 0.7f, this.Width, this.Height * 0.3F);
            _blackBottomGradient = new LinearGradientBrush(rect, Color.Transparent, Color.Black, 90f);
            rect = new RectangleF(Point.Empty, new SizeF(this.Width, this.Height * 0.3F));
            _whiteTopGradient = new LinearGradientBrush(rect, Color.White, Color.Transparent, 90f);
        }

        private void UpdateGraphicsBuffer()
        {
            if (this.Width > 0)
            {
                _canvas = new Bitmap(this.Width, this.Height);
                _graphicsBuffer = Graphics.FromImage(_canvas);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateLinearGradientBrushes();
            UpdateGraphicsBuffer();
        }

        #region MouseEvents
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (this.ClientRectangle.Contains(e.Location))
            {
                HoverColor = _canvas.GetPixel(e.X, e.Y);
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            SelectedColor = _canvas.GetPixel(e.X, e.Y);
            OnColorPicked();
        }
        #endregion
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            _graphicsBuffer.FillRectangle(_spectrumGradient, this.ClientRectangle);
            _graphicsBuffer.FillRectangle(_blackBottomGradient, 0, this.Height * 0.7f + 1, this.Width, this.Height * 0.3f);
            _graphicsBuffer.FillRectangle(_whiteTopGradient, 0, 0, this.Width, this.Height * 0.3f);

            e.Graphics.DrawImageUnscaled(_canvas, Point.Empty);
        }

        public Color SelectedColor { get; set; }
        public Color HoverColor { get; set; }
    }
}
