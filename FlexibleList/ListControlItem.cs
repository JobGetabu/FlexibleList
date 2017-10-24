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
    public partial class ListControlItem : UserControl
    {
        public string SongName { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public int Rating { get; set; }
        public ListControlItem()
        {
            InitializeComponent();

            //sName = SongName;
            //album = Album;
            //artist = Artist;
            //dur = Duration;
            //rating = Rating;
        }

        private void ListControlItem_Load(object sender, EventArgs e)
        {
            int pRating = Rating / 10 * 5;
            rating.Value = pRating;

            this.songName.Text = SongName;
            this.album.Text = Album;
            this.artist.Text = Artist;
            this.duration.Text = Duration.ToString();
        }
    }
}
