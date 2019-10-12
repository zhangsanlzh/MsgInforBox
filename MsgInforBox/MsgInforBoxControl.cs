using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luskyle
{
    partial class MsgInforBoxControl : Form
    {
        System.Timers.Timer timer1s = new System.Timers.Timer(1000);
        int count = 0;

        public MsgInforBoxControl()
        {
            InitializeComponent();

            _properties = new MsgInforBoxProperties(this);

            // 居中文字
            lblText.TextChanged += (s, e) =>
            {
                var g = (s as Label).CreateGraphics();
                var size = g.MeasureString(lblText.Text, lblText.Font);

                Width = (int)size.Width + 150;
                float x = (Width - size.Width) / 2;
                float y = (Height - size.Height) / 2;
                lblText.Location = new Point((int)x, (int)y);
            };
        }

        protected override void OnShown(EventArgs e)
        {
            timer1s.Elapsed += delegate
            {
                BeginInvoke((EventHandler)delegate
                {
                    count++;
                    if (count >= _properties.ShowTime)
                    {
                        timer1s.Stop();
                        count = 0;
                        Close();
                    }
                });
            };
        }

        protected override void OnClosed(EventArgs e)
        {
            timer1s.Stop();
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Color _defaultColor = Color.FromArgb(73, 151, 171);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Color _errorColor = Color.FromArgb(210, 50, 45);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Color _warningColor = Color.FromArgb(237, 156, 40);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Color _success = Color.FromArgb(71, 164, 71);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MsgInforBoxProperties _properties = null;

        /// <summary>
        /// Gets the message box display properties.
        /// </summary>
        public MsgInforBoxProperties Properties
        { get { return _properties; } }

        /// <summary>
        /// Arranges the apperance of the message box overlay.
        /// </summary>
        public void ArrangeApperance(InforType type)
        {
            lblText.Text = _properties.Message;

            switch (type)
            {
                case InforType.Default:
                    BackColor = _defaultColor;
                    break;
                case InforType.Error:
                    BackColor = _errorColor;
                    break;
                case InforType.Success:
                    BackColor = _success;
                    break;
                case InforType.Warning:
                    BackColor = _warningColor;
                    break;
                default:
                    break;
            }
        }

        public void ArrangeVisible(int showTime)
        {
            _properties.ShowTime = showTime;
            timer1s.Start();
        }
    }

}
