namespace FlexibleList
{
    partial class ListControlItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListControlItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.art = new System.Windows.Forms.PictureBox();
            this.songName = new System.Windows.Forms.Label();
            this.artist = new System.Windows.Forms.Label();
            this.album = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.rating = new Bunifu.Framework.UI.BunifuRating();
            this.prBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.art)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.art);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 81);
            this.panel1.TabIndex = 0;
            // 
            // art
            // 
            this.art.Dock = System.Windows.Forms.DockStyle.Fill;
            this.art.Image = ((System.Drawing.Image)(resources.GetObject("art.Image")));
            this.art.Location = new System.Drawing.Point(0, 0);
            this.art.Name = "art";
            this.art.Size = new System.Drawing.Size(98, 81);
            this.art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.art.TabIndex = 0;
            this.art.TabStop = false;
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.Location = new System.Drawing.Point(104, 12);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(248, 20);
            this.songName.TabIndex = 1;
            this.songName.Text = "Moving Like The Speed Of Sound";
            // 
            // artist
            // 
            this.artist.AutoSize = true;
            this.artist.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artist.Location = new System.Drawing.Point(104, 52);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(94, 16);
            this.artist.TabIndex = 2;
            this.artist.Text = "Stephan Swartz";
            // 
            // album
            // 
            this.album.AutoSize = true;
            this.album.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.album.Location = new System.Drawing.Point(105, 34);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(64, 16);
            this.album.TabIndex = 3;
            this.album.Text = "Bullet Train";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.duration.Location = new System.Drawing.Point(470, 48);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(32, 17);
            this.duration.TabIndex = 4;
            this.duration.Text = "4:16";
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.ForeColor = System.Drawing.Color.SeaGreen;
            this.rating.Location = new System.Drawing.Point(399, 12);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(116, 20);
            this.rating.TabIndex = 5;
            this.rating.Value = 0;
            // 
            // prBar
            // 
            this.prBar.BackColor = System.Drawing.Color.Silver;
            this.prBar.BorderRadius = 7;
            this.prBar.Location = new System.Drawing.Point(108, 71);
            this.prBar.MaximumValue = 100;
            this.prBar.Name = "prBar";
            this.prBar.ProgressColor = System.Drawing.Color.Teal;
            this.prBar.Size = new System.Drawing.Size(407, 7);
            this.prBar.TabIndex = 6;
            this.prBar.Value = 0;
            // 
            // ListControlItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.prBar);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.album);
            this.Controls.Add(this.artist);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.panel1);
            this.Name = "ListControlItem";
            this.Size = new System.Drawing.Size(535, 81);
            this.Load += new System.EventHandler(this.ListControlItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.art)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox art;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label artist;
        private System.Windows.Forms.Label album;
        private System.Windows.Forms.Label duration;
        private Bunifu.Framework.UI.BunifuRating rating;
        private Bunifu.Framework.UI.BunifuProgressBar prBar;
    }
}
