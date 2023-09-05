namespace APU
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslSalon = new System.Windows.Forms.ToolStripLabel();
            this.tsbSalonAll = new System.Windows.Forms.ToolStripButton();
            this.tsbSalonNone = new System.Windows.Forms.ToolStripButton();
            this.tslAuction = new System.Windows.Forms.ToolStripLabel();
            this.tsbAuctionAll = new System.Windows.Forms.ToolStripButton();
            this.tsbAuctionNone = new System.Windows.Forms.ToolStripButton();
            this.tslJunkyard = new System.Windows.Forms.ToolStripLabel();
            this.tsbJunkyardAll = new System.Windows.Forms.ToolStripButton();
            this.tsbJunkyardNone = new System.Windows.Forms.ToolStripButton();
            this.tslBarns = new System.Windows.Forms.ToolStripLabel();
            this.tsbBarnsAll = new System.Windows.Forms.ToolStripButton();
            this.tsbBarnsNone = new System.Windows.Forms.ToolStripButton();
            this.lvwCars = new System.Windows.Forms.ListView();
            this.gbxPlaces = new System.Windows.Forms.GroupBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.tbxNameFilter = new System.Windows.Forms.TextBox();
            this.cmbNameFilter = new System.Windows.Forms.ComboBox();
            this.lblFileTypeFilter = new System.Windows.Forms.Label();
            this.lblPlacesFilter = new System.Windows.Forms.Label();
            this.lblNameFilter = new System.Windows.Forms.Label();
            this.lblUnique = new System.Windows.Forms.Label();
            this.nudUnique = new System.Windows.Forms.NumericUpDown();
            this.chkShed = new System.Windows.Forms.CheckBox();
            this.chkJunk = new System.Windows.Forms.CheckBox();
            this.chkSalon = new System.Windows.Forms.CheckBox();
            this.chkAuction = new System.Windows.Forms.CheckBox();
            this.lblCarName = new System.Windows.Forms.Label();
            this.rbFTFAll = new System.Windows.Forms.RadioButton();
            this.panelFileTypeFilter = new System.Windows.Forms.Panel();
            this.rbFTFVanilla = new System.Windows.Forms.RadioButton();
            this.rbFTFMod = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.gbxPlaces.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnique)).BeginInit();
            this.panelFileTypeFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSalon,
            this.tsbSalonAll,
            this.tsbSalonNone,
            this.tslAuction,
            this.tsbAuctionAll,
            this.tsbAuctionNone,
            this.tslJunkyard,
            this.tsbJunkyardAll,
            this.tsbJunkyardNone,
            this.tslBarns,
            this.tsbBarnsAll,
            this.tsbBarnsNone});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(518, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslSalon
            // 
            this.tslSalon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslSalon.Name = "tslSalon";
            this.tslSalon.Size = new System.Drawing.Size(37, 22);
            this.tslSalon.Text = "Salon";
            // 
            // tsbSalonAll
            // 
            this.tsbSalonAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSalonAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalonAll.Image")));
            this.tsbSalonAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalonAll.Name = "tsbSalonAll";
            this.tsbSalonAll.Size = new System.Drawing.Size(25, 22);
            this.tsbSalonAll.Text = "All";
            this.tsbSalonAll.Click += new System.EventHandler(this.tsbSalonAll_Click);
            // 
            // tsbSalonNone
            // 
            this.tsbSalonNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSalonNone.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalonNone.Image")));
            this.tsbSalonNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalonNone.Name = "tsbSalonNone";
            this.tsbSalonNone.Size = new System.Drawing.Size(40, 22);
            this.tsbSalonNone.Text = "None";
            this.tsbSalonNone.Click += new System.EventHandler(this.tsbSalonNone_Click);
            // 
            // tslAuction
            // 
            this.tslAuction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslAuction.Name = "tslAuction";
            this.tslAuction.Size = new System.Drawing.Size(50, 22);
            this.tslAuction.Text = "Auction";
            // 
            // tsbAuctionAll
            // 
            this.tsbAuctionAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAuctionAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbAuctionAll.Image")));
            this.tsbAuctionAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAuctionAll.Name = "tsbAuctionAll";
            this.tsbAuctionAll.Size = new System.Drawing.Size(25, 22);
            this.tsbAuctionAll.Text = "All";
            this.tsbAuctionAll.Click += new System.EventHandler(this.tsbAuctionAll_Click);
            // 
            // tsbAuctionNone
            // 
            this.tsbAuctionNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAuctionNone.Image = ((System.Drawing.Image)(resources.GetObject("tsbAuctionNone.Image")));
            this.tsbAuctionNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAuctionNone.Name = "tsbAuctionNone";
            this.tsbAuctionNone.Size = new System.Drawing.Size(40, 22);
            this.tsbAuctionNone.Text = "None";
            this.tsbAuctionNone.Click += new System.EventHandler(this.tsbAuctionNone_Click);
            // 
            // tslJunkyard
            // 
            this.tslJunkyard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslJunkyard.Name = "tslJunkyard";
            this.tslJunkyard.Size = new System.Drawing.Size(57, 22);
            this.tslJunkyard.Text = "Junkyard";
            // 
            // tsbJunkyardAll
            // 
            this.tsbJunkyardAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbJunkyardAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbJunkyardAll.Image")));
            this.tsbJunkyardAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJunkyardAll.Name = "tsbJunkyardAll";
            this.tsbJunkyardAll.Size = new System.Drawing.Size(25, 22);
            this.tsbJunkyardAll.Text = "All";
            this.tsbJunkyardAll.Click += new System.EventHandler(this.tsbJunkyardAll_Click);
            // 
            // tsbJunkyardNone
            // 
            this.tsbJunkyardNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbJunkyardNone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbJunkyardNone.Image = ((System.Drawing.Image)(resources.GetObject("tsbJunkyardNone.Image")));
            this.tsbJunkyardNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJunkyardNone.Name = "tsbJunkyardNone";
            this.tsbJunkyardNone.Size = new System.Drawing.Size(40, 22);
            this.tsbJunkyardNone.Text = "None";
            this.tsbJunkyardNone.Click += new System.EventHandler(this.tsbJunkyardNone_Click);
            // 
            // tslBarns
            // 
            this.tslBarns.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslBarns.Name = "tslBarns";
            this.tslBarns.Size = new System.Drawing.Size(38, 22);
            this.tslBarns.Text = "Barns";
            // 
            // tsbBarnsAll
            // 
            this.tsbBarnsAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBarnsAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbBarnsAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbBarnsAll.Image")));
            this.tsbBarnsAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBarnsAll.Name = "tsbBarnsAll";
            this.tsbBarnsAll.Size = new System.Drawing.Size(25, 22);
            this.tsbBarnsAll.Text = "All";
            this.tsbBarnsAll.Click += new System.EventHandler(this.tsbBarnsAll_Click);
            // 
            // tsbBarnsNone
            // 
            this.tsbBarnsNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBarnsNone.Image = ((System.Drawing.Image)(resources.GetObject("tsbBarnsNone.Image")));
            this.tsbBarnsNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBarnsNone.Name = "tsbBarnsNone";
            this.tsbBarnsNone.Size = new System.Drawing.Size(40, 22);
            this.tsbBarnsNone.Text = "None";
            this.tsbBarnsNone.Click += new System.EventHandler(this.tsbBarnsNone_Click);
            // 
            // lvwCars
            // 
            this.lvwCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwCars.HideSelection = false;
            this.lvwCars.Location = new System.Drawing.Point(0, 25);
            this.lvwCars.Name = "lvwCars";
            this.lvwCars.Size = new System.Drawing.Size(518, 92);
            this.lvwCars.TabIndex = 10;
            this.lvwCars.UseCompatibleStateImageBehavior = false;
            this.lvwCars.View = System.Windows.Forms.View.List;
            this.lvwCars.SelectedIndexChanged += new System.EventHandler(this.lvwCars_SelectedIndexChanged);
            // 
            // gbxPlaces
            // 
            this.gbxPlaces.Controls.Add(this.gbxFilter);
            this.gbxPlaces.Controls.Add(this.lblUnique);
            this.gbxPlaces.Controls.Add(this.nudUnique);
            this.gbxPlaces.Controls.Add(this.chkShed);
            this.gbxPlaces.Controls.Add(this.chkJunk);
            this.gbxPlaces.Controls.Add(this.chkSalon);
            this.gbxPlaces.Controls.Add(this.chkAuction);
            this.gbxPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPlaces.Location = new System.Drawing.Point(0, 117);
            this.gbxPlaces.Name = "gbxPlaces";
            this.gbxPlaces.Size = new System.Drawing.Size(518, 173);
            this.gbxPlaces.TabIndex = 12;
            this.gbxPlaces.TabStop = false;
            this.gbxPlaces.Text = "Allowed Places";
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.panelFileTypeFilter);
            this.gbxFilter.Controls.Add(this.tbxNameFilter);
            this.gbxFilter.Controls.Add(this.cmbNameFilter);
            this.gbxFilter.Controls.Add(this.lblFileTypeFilter);
            this.gbxFilter.Controls.Add(this.lblPlacesFilter);
            this.gbxFilter.Controls.Add(this.lblNameFilter);
            this.gbxFilter.Location = new System.Drawing.Point(207, 0);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(311, 129);
            this.gbxFilter.TabIndex = 12;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // tbxNameFilter
            // 
            this.tbxNameFilter.Location = new System.Drawing.Point(59, 19);
            this.tbxNameFilter.Name = "tbxNameFilter";
            this.tbxNameFilter.Size = new System.Drawing.Size(100, 20);
            this.tbxNameFilter.TabIndex = 4;
            this.tbxNameFilter.TextChanged += new System.EventHandler(this.tbxNameFilter_TextChanged);
            // 
            // cmbNameFilter
            // 
            this.cmbNameFilter.FormattingEnabled = true;
            this.cmbNameFilter.Location = new System.Drawing.Point(168, 19);
            this.cmbNameFilter.Name = "cmbNameFilter";
            this.cmbNameFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbNameFilter.TabIndex = 3;
            this.cmbNameFilter.SelectedIndexChanged += new System.EventHandler(this.cmbNameFilter_SelectedIndexChanged);
            // 
            // lblFileTypeFilter
            // 
            this.lblFileTypeFilter.AutoSize = true;
            this.lblFileTypeFilter.Location = new System.Drawing.Point(7, 67);
            this.lblFileTypeFilter.Name = "lblFileTypeFilter";
            this.lblFileTypeFilter.Size = new System.Drawing.Size(46, 13);
            this.lblFileTypeFilter.TabIndex = 2;
            this.lblFileTypeFilter.Text = "File type";
            // 
            // lblPlacesFilter
            // 
            this.lblPlacesFilter.AutoSize = true;
            this.lblPlacesFilter.Location = new System.Drawing.Point(7, 43);
            this.lblPlacesFilter.Name = "lblPlacesFilter";
            this.lblPlacesFilter.Size = new System.Drawing.Size(39, 13);
            this.lblPlacesFilter.TabIndex = 1;
            this.lblPlacesFilter.Text = "Places";
            // 
            // lblNameFilter
            // 
            this.lblNameFilter.AutoSize = true;
            this.lblNameFilter.Location = new System.Drawing.Point(7, 20);
            this.lblNameFilter.Name = "lblNameFilter";
            this.lblNameFilter.Size = new System.Drawing.Size(35, 13);
            this.lblNameFilter.TabIndex = 0;
            this.lblNameFilter.Text = "Name";
            // 
            // lblUnique
            // 
            this.lblUnique.AutoSize = true;
            this.lblUnique.Location = new System.Drawing.Point(20, 80);
            this.lblUnique.Name = "lblUnique";
            this.lblUnique.Size = new System.Drawing.Size(62, 13);
            this.lblUnique.TabIndex = 11;
            this.lblUnique.Text = "UniqueMod";
            // 
            // nudUnique
            // 
            this.nudUnique.DecimalPlaces = 2;
            this.nudUnique.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudUnique.Location = new System.Drawing.Point(109, 78);
            this.nudUnique.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudUnique.Name = "nudUnique";
            this.nudUnique.Size = new System.Drawing.Size(58, 20);
            this.nudUnique.TabIndex = 10;
            this.nudUnique.ValueChanged += new System.EventHandler(this.nudUnique_ValueChanged);
            // 
            // chkShed
            // 
            this.chkShed.AutoSize = true;
            this.chkShed.Location = new System.Drawing.Point(109, 30);
            this.chkShed.Name = "chkShed";
            this.chkShed.Size = new System.Drawing.Size(53, 17);
            this.chkShed.TabIndex = 9;
            this.chkShed.Text = "Barns";
            this.chkShed.UseVisualStyleBackColor = true;
            this.chkShed.CheckedChanged += new System.EventHandler(this.chkShed_CheckedChanged);
            // 
            // chkJunk
            // 
            this.chkJunk.AutoSize = true;
            this.chkJunk.Location = new System.Drawing.Point(109, 53);
            this.chkJunk.Name = "chkJunk";
            this.chkJunk.Size = new System.Drawing.Size(69, 17);
            this.chkJunk.TabIndex = 8;
            this.chkJunk.Text = "Junkyard";
            this.chkJunk.UseVisualStyleBackColor = true;
            this.chkJunk.CheckedChanged += new System.EventHandler(this.chkJunk_CheckedChanged);
            // 
            // chkSalon
            // 
            this.chkSalon.AutoSize = true;
            this.chkSalon.Location = new System.Drawing.Point(23, 53);
            this.chkSalon.Name = "chkSalon";
            this.chkSalon.Size = new System.Drawing.Size(53, 17);
            this.chkSalon.TabIndex = 7;
            this.chkSalon.Text = "Salon";
            this.chkSalon.UseVisualStyleBackColor = true;
            this.chkSalon.CheckedChanged += new System.EventHandler(this.chkSalon_CheckedChanged);
            // 
            // chkAuction
            // 
            this.chkAuction.AutoSize = true;
            this.chkAuction.Location = new System.Drawing.Point(23, 30);
            this.chkAuction.Name = "chkAuction";
            this.chkAuction.Size = new System.Drawing.Size(62, 17);
            this.chkAuction.TabIndex = 6;
            this.chkAuction.Text = "Auction";
            this.chkAuction.UseVisualStyleBackColor = true;
            this.chkAuction.CheckedChanged += new System.EventHandler(this.chkAuction_CheckedChanged);
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.BackColor = System.Drawing.Color.Black;
            this.lblCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.White;
            this.lblCarName.Location = new System.Drawing.Point(12, 261);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(0, 20);
            this.lblCarName.TabIndex = 13;
            // 
            // rbFTFAll
            // 
            this.rbFTFAll.AutoSize = true;
            this.rbFTFAll.Location = new System.Drawing.Point(0, 0);
            this.rbFTFAll.Name = "rbFTFAll";
            this.rbFTFAll.Size = new System.Drawing.Size(36, 17);
            this.rbFTFAll.TabIndex = 5;
            this.rbFTFAll.TabStop = true;
            this.rbFTFAll.Text = "All";
            this.rbFTFAll.UseVisualStyleBackColor = true;
            this.rbFTFAll.CheckedChanged += new System.EventHandler(this.rbFTFAll_CheckedChanged);
            // 
            // panelFileTypeFilter
            // 
            this.panelFileTypeFilter.Controls.Add(this.rbFTFMod);
            this.panelFileTypeFilter.Controls.Add(this.rbFTFVanilla);
            this.panelFileTypeFilter.Controls.Add(this.rbFTFAll);
            this.panelFileTypeFilter.Location = new System.Drawing.Point(59, 65);
            this.panelFileTypeFilter.Name = "panelFileTypeFilter";
            this.panelFileTypeFilter.Size = new System.Drawing.Size(158, 15);
            this.panelFileTypeFilter.TabIndex = 6;
            // 
            // rbFTFVanilla
            // 
            this.rbFTFVanilla.AutoSize = true;
            this.rbFTFVanilla.Location = new System.Drawing.Point(42, 0);
            this.rbFTFVanilla.Name = "rbFTFVanilla";
            this.rbFTFVanilla.Size = new System.Drawing.Size(56, 17);
            this.rbFTFVanilla.TabIndex = 6;
            this.rbFTFVanilla.TabStop = true;
            this.rbFTFVanilla.Text = "Vanilla";
            this.rbFTFVanilla.UseVisualStyleBackColor = true;
            this.rbFTFVanilla.CheckedChanged += new System.EventHandler(this.rbFTFVanilla_CheckedChanged);
            // 
            // rbFTFMod
            // 
            this.rbFTFMod.AutoSize = true;
            this.rbFTFMod.Location = new System.Drawing.Point(104, 0);
            this.rbFTFMod.Name = "rbFTFMod";
            this.rbFTFMod.Size = new System.Drawing.Size(46, 17);
            this.rbFTFMod.TabIndex = 7;
            this.rbFTFMod.TabStop = true;
            this.rbFTFMod.Text = "Mod";
            this.rbFTFMod.UseVisualStyleBackColor = true;
            this.rbFTFMod.CheckedChanged += new System.EventHandler(this.rbFTFMod_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 290);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.gbxPlaces);
            this.Controls.Add(this.lvwCars);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AllowedPlaces Utility For CMS2021";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbxPlaces.ResumeLayout(false);
            this.gbxPlaces.PerformLayout();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnique)).EndInit();
            this.panelFileTypeFilter.ResumeLayout(false);
            this.panelFileTypeFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslSalon;
        private System.Windows.Forms.ToolStripButton tsbSalonAll;
        private System.Windows.Forms.ToolStripButton tsbSalonNone;
        private System.Windows.Forms.ToolStripLabel tslAuction;
        private System.Windows.Forms.ToolStripButton tsbAuctionAll;
        private System.Windows.Forms.ToolStripButton tsbAuctionNone;
        private System.Windows.Forms.ToolStripLabel tslJunkyard;
        private System.Windows.Forms.ToolStripButton tsbJunkyardAll;
        private System.Windows.Forms.ToolStripButton tsbJunkyardNone;
        private System.Windows.Forms.ToolStripLabel tslBarns;
        private System.Windows.Forms.ToolStripButton tsbBarnsAll;
        private System.Windows.Forms.ToolStripButton tsbBarnsNone;
        private System.Windows.Forms.ListView lvwCars;
        private System.Windows.Forms.GroupBox gbxPlaces;
        private System.Windows.Forms.CheckBox chkShed;
        private System.Windows.Forms.CheckBox chkJunk;
        private System.Windows.Forms.CheckBox chkSalon;
        private System.Windows.Forms.CheckBox chkAuction;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblUnique;
        private System.Windows.Forms.NumericUpDown nudUnique;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.Label lblPlacesFilter;
        private System.Windows.Forms.Label lblNameFilter;
        private System.Windows.Forms.Label lblFileTypeFilter;
        private System.Windows.Forms.ComboBox cmbNameFilter;
        private System.Windows.Forms.TextBox tbxNameFilter;
        private System.Windows.Forms.RadioButton rbFTFAll;
        private System.Windows.Forms.Panel panelFileTypeFilter;
        private System.Windows.Forms.RadioButton rbFTFVanilla;
        private System.Windows.Forms.RadioButton rbFTFMod;
    }
}

