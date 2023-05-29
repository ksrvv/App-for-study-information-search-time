using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class RoundCornerTextBox : UserControl
    {
        private Color borderColor = Color.FromArgb(170, 170, 170);
        private int borderSize = 1;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.FromArgb(0, 191, 255);
        private bool IsFocused=false;
        private int borderRadius = 0;
        private Color placeholderColor = Color.FromArgb(208, 208, 208);
        private string placeholderText = "";
        private bool IsPlaceholder = false;
        public RoundCornerTextBox()
        {
            InitializeComponent();
        }
        public event EventHandler _TextChanged;
        [Category("Advanse")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("Advanse")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("Advanse")]
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }
        [Category("Advanse")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; textBox1.BackColor = value; } }
        [Category("Advanse")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; textBox1.ForeColor = value; } }
       [Category("Advanse")]
       
        public override Font Font { get => base.Font; set { base.Font = value; textBox1.Font = value;
            if(this.DesignMode)
                    UpdateControlHeight();
            } }
       [Category("Advanse")]
        public  string Texts {
            get { 

               if(IsPlaceholder) return "";
               else return textBox1.Text;   
            }
            set { textBox1.Text = value;
                SetPlaceholder();
            }
        }
        [Category("Advanse")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set
            {
                borderFocusColor = value; 
            }
        }
        [Category("Advanse")]
        public int BorderRadius { get => borderRadius; set {
                if (value >= 0)
                {
 borderRadius = value;
                    this.Invalidate();
                }
               
            } }
        [Category("Advanse")]
        public Color PlaceholderColor { get => placeholderColor; set => placeholderColor = value; }
        [Category("Advanse")]
        public string PlaceholderText { get => placeholderText;
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            } 
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                IsPlaceholder= true;
                textBox1.Text= placeholderText;

                textBox1.ForeColor = placeholderColor;
                
            }
        }
        private void RemovePlaceholder()
        {
            if (IsPlaceholder && placeholderText != "")
            {
                IsPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;

            }
        }
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Width - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Width - curveSize, rect.Height - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Height - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothsize = borderSize>0? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius-borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothsize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) 
                        SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if (!IsFocused)
                    {


                        if (underlinedStyle)
                        {
                            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                            graph.SmoothingMode = SmoothingMode.None;

                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);

                        }

                        else
                        {
                            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                            graph.DrawPath(penBorder, pathBorder);
                        }
                    }
                }




            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, BorderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!IsFocused)
                    {


                        if (underlinedStyle)
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        else graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
                }

            using (Pen penBorder = new Pen(borderColor, BorderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!IsFocused)
                {

                
                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
            textBox1.Region = new Region(pathTxt);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
               UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();

        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;

                textBox1.MinimumSize = new Size(0, txtHeight+10);
               
                textBox1.Multiline = false;
                this.Height = textBox1.Height+this.Padding.Top+this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged!=null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            IsFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            IsFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
