﻿namespace Music_Library
{
    partial class FrmAddGenre
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addAGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.GenreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnsaveGenre = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAGenreToolStripMenuItem,
            this.addAnArtistToolStripMenuItem,
            this.addAnAlbumToolStripMenuItem,
            this.libraryToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addAGenreToolStripMenuItem
            // 
            this.addAGenreToolStripMenuItem.Name = "addAGenreToolStripMenuItem";
            this.addAGenreToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addAGenreToolStripMenuItem.Text = "Add a Genre";
            this.addAGenreToolStripMenuItem.Click += new System.EventHandler(this.addAGenreToolStripMenuItem_Click);
            // 
            // addAnArtistToolStripMenuItem
            // 
            this.addAnArtistToolStripMenuItem.Name = "addAnArtistToolStripMenuItem";
            this.addAnArtistToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.addAnArtistToolStripMenuItem.Text = "Add an Artist";
            // 
            // addAnAlbumToolStripMenuItem
            // 
            this.addAnAlbumToolStripMenuItem.Name = "addAnAlbumToolStripMenuItem";
            this.addAnAlbumToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.addAnAlbumToolStripMenuItem.Text = "Add an Album";
            this.addAnAlbumToolStripMenuItem.Click += new System.EventHandler(this.addAnAlbumToolStripMenuItem_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(101, 112);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(36, 115);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type:";
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.AutoGenerateColumns = false;
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenreId,
            this.dataGridViewTextBoxColumn2});
            this.genreDataGridView.DataSource = this.genreBindingSource;
            this.genreDataGridView.Location = new System.Drawing.Point(415, 112);
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.Size = new System.Drawing.Size(300, 220);
            this.genreDataGridView.TabIndex = 5;
            this.genreDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genreDataGridView_CellContentClick);
            this.genreDataGridView.DoubleClick += new System.EventHandler(this.genreDataGridView_DoubleClick);
            // 
            // GenreId
            // 
            this.GenreId.DataPropertyName = "GenreId";
            this.GenreId.HeaderText = "GenreId";
            this.GenreId.Name = "GenreId";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(Music_Library.Genre);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(102, 198);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGenre.TabIndex = 6;
            this.btnDeleteGenre.Text = "Delete";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnsaveGenre
            // 
            this.btnsaveGenre.Location = new System.Drawing.Point(21, 198);
            this.btnsaveGenre.Name = "btnsaveGenre";
            this.btnsaveGenre.Size = new System.Drawing.Size(75, 23);
            this.btnsaveGenre.TabIndex = 7;
            this.btnsaveGenre.Text = "Save";
            this.btnsaveGenre.UseVisualStyleBackColor = true;
            this.btnsaveGenre.Click += new System.EventHandler(this.btnsaveGenre_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnsaveGenre);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.genreDataGridView);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmAddGenre";
            this.Text = "Add a Genre";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addAGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridView genreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnsaveGenre;
        private System.Windows.Forms.Button btnCancel;
    }
}
