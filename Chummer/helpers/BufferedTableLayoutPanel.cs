/*  This file is part of Chummer5a.
 *
 *  Chummer5a is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Chummer5a is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Chummer5a.  If not, see <http://www.gnu.org/licenses/>.
 *
 *  You can obtain the full source code for Chummer5a at
 *  https://github.com/chummer5a/chummer5a
 */

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Chummer
{
    public partial class BufferedTableLayoutPanel : TableLayoutPanel
    {
        public BufferedTableLayoutPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.UserPaint
                     | ControlStyles.CacheText,
                true);
            InitializeComponent();
        }

        public BufferedTableLayoutPanel(IContainer container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));
            container.Add(this);
            SetStyle(ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.UserPaint
                     | ControlStyles.CacheText,
                true);
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams eParams = base.CreateParams;
                eParams.ExStyle |= NativeMethods.WS_EX_COMPOSITED;
                return eParams;
            }
        }

        public void BeginUpdate()
        {
            NativeMethods.SendMessage(Handle, NativeMethods.WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
        }

        public void EndUpdate()
        {
            NativeMethods.SendMessage(Handle, NativeMethods.WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
            Parent.Invalidate(true);
        }
    }


    public static class NativeMethods
    {
        public static readonly int WM_SETREDRAW = 0x000B; //uint WM_SETREDRAW
        public static readonly int WS_EX_COMPOSITED = 0x02000000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam); //UInt32 Msg
    }
}
