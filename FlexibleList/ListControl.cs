using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexibleList
{
    public partial class ListControl : UserControl
    {
        public ListControl()
        {
            InitializeComponent();
        }


        public void Add(string sName, string album, string artist, TimeSpan dur, int rating)
        {
            ListControlItem c = new ListControlItem();

            c.SongName = sName;
            c.Album = album;
            c.Artist = artist;
            c.Duration = dur;
            c.Rating = rating;

            flpListBox.Controls.Add(c);
            SetupAnchors();
        }


        public void Remove(string name)
        {
            Control c = flpListBox.Controls[name];
            flpListBox.Controls.Remove(c);
            c.Dispose();
            SetupAnchors();
        }


        public void Clear()
        {
            do
            {
                if (flpListBox.Controls.Count == 0)
                {
                    break; // TODO: might not be correct. Was : Exit Do
                }
                Control c = flpListBox.Controls[0];
                flpListBox.Controls.Remove(c);
                c.Dispose();
            }
            while (true);
        }

        public int Count
        {
            get { return flpListBox.Controls.Count; }
        }
        private void SetupAnchors()
        {
            if (flpListBox.Controls.Count > 0)
            {
                for (int i = 0; i <= flpListBox.Controls.Count - 1; i++)
                {
                    Control c = flpListBox.Controls[i];
                    if (i == 0)
                    {
                        // Its the first control, all subsequent controls follow
                        // the anchor behavior of this control.
                        c.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                        c.Width = flpListBox.Width - SystemInformation.VerticalScrollBarWidth;
                    }
                    else
                    {
                        // It is not the first control. Set its anchor to
                        // copy the width of the first control in the list.
                        c.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                    }
                }
            }
        }

        private void ListControl_Layout(object sender, LayoutEventArgs e)
        {
            if (flpListBox.Controls.Count >= 0)
            {
                flpListBox.Controls[0].Width = flpListBox.Size.Width - SystemInformation.VerticalScrollBarWidth;
            }
        }
    }
}
