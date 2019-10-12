using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luskyle
{
    public class MsgInforBox
    {
        static int defaultHeight = 114;
        static int defaultShowTime = 2;
        static MsgInforBoxControl _control = null;

        public static void Show(IWin32Window owner, string message)
        {
            Show(owner, message, defaultHeight, InforType.Default, defaultShowTime);
        }

        public static void Show(IWin32Window owner, string message, InforType type)
        {
            Show(owner, message, defaultHeight, type, defaultShowTime);
        }

        public static void Show(IWin32Window owner, string message, InforType type, int showTime)
        {
            Show(owner, message, defaultHeight, type, showTime);
        }

        public static void Show(IWin32Window owner, string message, int height, InforType type, int showTime)
        {
            if (owner != null)
            {
                Form _owner = (owner as Form == null) ? ((UserControl)owner).ParentForm : (Form)owner;

                _control = new MsgInforBoxControl();
                _control.Properties.Message = message;
                _control.Padding = new Padding(0, 0, 0, 0);
                _control.ControlBox = false;
                _control.ShowInTaskbar = false;
                _control.TopMost = true;
                _control.Size = new Size(_owner.Size.Width, height);
                _control.Location = new Point(_owner.Location.X, _owner.Location.Y + (_owner.Height - _control.Height) / 2);

                _control.ArrangeApperance(type);
                _control.ArrangeVisible(showTime);
                _control.ShowDialog();
                _control.BringToFront();
            }
        }
    }
}
