using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luskyle
{
    class MsgInforBoxProperties
    {
        /// <summary>
        /// Creates a new instance of MessageBoxOverlayProperties.
        /// </summary>
        /// <param name="owner"></param>
        public MsgInforBoxProperties(MsgInforBoxControl owner)
        { _owner = owner; }

        /// <summary>
        /// Gets or sets the message box overlay message contents.
        /// </summary>
        public string Message
        { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MsgInforBoxControl _owner = null;

        /// <summary>
        /// Gets the property owner.
        /// </summary>
        public MsgInforBoxControl Owner
        { get { return _owner; } }

        public int ShowTime { get; set; }

    }

    public enum InforType
    {
        Default,
        Error,
        Success,
        Warning
    }
}
