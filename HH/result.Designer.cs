﻿
namespace HH
{
    partial class result
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.mID = new Guna.UI2.WinForms.Guna2TextBox();
            this.show = new Guna.UI2.WinForms.Guna2Button();
            this.matchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchid,
            this.club1,
            this.score1,
            this.score2,
            this.club2,
            this.stay,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(102, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(262, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "all match results";
            // 
            // add
            // 
            this.add.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.add.BorderThickness = 3;
            this.add.CheckedState.Parent = this.add;
            this.add.CustomImages.Parent = this.add;
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.DisabledState.Parent = this.add;
            this.add.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.Parent = this.add;
            this.add.Location = new System.Drawing.Point(55, 516);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(180, 45);
            this.add.TabIndex = 2;
            this.add.Text = "ADD RESULT";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button2.BorderThickness = 3;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button2.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(778, 516);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "exit";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // mID
            // 
            this.mID.BorderColor = System.Drawing.Color.Black;
            this.mID.BorderRadius = 13;
            this.mID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.mID.BorderThickness = 3;
            this.mID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mID.DefaultText = "";
            this.mID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mID.DisabledState.Parent = this.mID;
            this.mID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mID.FillColor = System.Drawing.Color.LightSeaGreen;
            this.mID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mID.FocusedState.Parent = this.mID;
            this.mID.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mID.ForeColor = System.Drawing.Color.Black;
            this.mID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mID.HoverState.Parent = this.mID;
            this.mID.Location = new System.Drawing.Point(769, 22);
            this.mID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mID.Name = "mID";
            this.mID.PasswordChar = '\0';
            this.mID.PlaceholderText = "";
            this.mID.SelectedText = "";
            this.mID.ShadowDecoration.Parent = this.mID;
            this.mID.Size = new System.Drawing.Size(189, 38);
            this.mID.TabIndex = 4;
            this.mID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // show
            // 
            this.show.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.show.BorderThickness = 3;
            this.show.CheckedState.Parent = this.show;
            this.show.CustomImages.Parent = this.show;
            this.show.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.show.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.show.DisabledState.Parent = this.show;
            this.show.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.HoverState.Parent = this.show;
            this.show.Location = new System.Drawing.Point(438, 516);
            this.show.Name = "show";
            this.show.ShadowDecoration.Parent = this.show;
            this.show.Size = new System.Drawing.Size(180, 45);
            this.show.TabIndex = 5;
            this.show.Text = "show match";
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // matchid
            // 
            this.matchid.DataPropertyName = "MATCHID";
            this.matchid.HeaderText = "Match ID";
            this.matchid.Name = "matchid";
            // 
            // club1
            // 
            this.club1.DataPropertyName = "CLB1";
            this.club1.HeaderText = "CLUB 1";
            this.club1.Name = "club1";
            // 
            // score1
            // 
            this.score1.DataPropertyName = "SCORED1";
            this.score1.HeaderText = "SCORE 1";
            this.score1.Name = "score1";
            // 
            // score2
            // 
            this.score2.DataPropertyName = "SCORED2";
            this.score2.HeaderText = "SCORE 2";
            this.score2.Name = "score2";
            // 
            // club2
            // 
            this.club2.DataPropertyName = "CLB2";
            this.club2.HeaderText = "CLUB 2";
            this.club2.Name = "club2";
            // 
            // stay
            // 
            this.stay.DataPropertyName = "STAYDIUM";
            this.stay.HeaderText = "Staydium";
            this.stay.Name = "stay";
            this.stay.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "DATE_TIME";
            this.date.HeaderText = "Datetime";
            this.date.Name = "date";
            // 
            // result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.show);
            this.Controls.Add(this.mID);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "result";
            this.Text = "result";
            this.Load += new System.EventHandler(this.result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox mID;
        private Guna.UI2.WinForms.Guna2Button show;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn club1;
        private System.Windows.Forms.DataGridViewTextBoxColumn score1;
        private System.Windows.Forms.DataGridViewTextBoxColumn score2;
        private System.Windows.Forms.DataGridViewTextBoxColumn club2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stay;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}