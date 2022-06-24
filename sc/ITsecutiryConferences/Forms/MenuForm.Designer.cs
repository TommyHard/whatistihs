namespace ITsecutiryConferences.Forms
{
    partial class MenuForm
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.LabelEvents = new System.Windows.Forms.Label();
            this.GridEvents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DateFilter = new System.Windows.Forms.DateTimePicker();
            this.ButtonResetFilter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelHeader.Controls.Add(this.button1);
            this.PanelHeader.Controls.Add(this.ButtonResetFilter);
            this.PanelHeader.Controls.Add(this.PictureLogo);
            this.PanelHeader.Controls.Add(this.LabelEvents);
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Controls.Add(this.DateFilter);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(784, 100);
            this.PanelHeader.TabIndex = 0;
            // 
            // PictureLogo
            // 
            this.PictureLogo.BackgroundImage = global::ITsecutiryConferences.Properties.Resources.logo;
            this.PictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureLogo.Location = new System.Drawing.Point(15, 12);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(90, 85);
            this.PictureLogo.TabIndex = 1;
            this.PictureLogo.TabStop = false;
            // 
            // LabelEvents
            // 
            this.LabelEvents.AutoSize = true;
            this.LabelEvents.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEvents.Location = new System.Drawing.Point(111, 71);
            this.LabelEvents.Name = "LabelEvents";
            this.LabelEvents.Size = new System.Drawing.Size(205, 26);
            this.LabelEvents.TabIndex = 1;
            this.LabelEvents.Text = "Список мероприятий";
            // 
            // GridEvents
            // 
            this.GridEvents.BackgroundColor = System.Drawing.Color.White;
            this.GridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEvents.Location = new System.Drawing.Point(0, 100);
            this.GridEvents.Name = "GridEvents";
            this.GridEvents.ReadOnly = true;
            this.GridEvents.Size = new System.Drawing.Size(784, 461);
            this.GridEvents.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(372, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фильтр по дате";
            // 
            // DateFilter
            // 
            this.DateFilter.Location = new System.Drawing.Point(365, 71);
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Size = new System.Drawing.Size(150, 23);
            this.DateFilter.TabIndex = 3;
            this.DateFilter.ValueChanged += new System.EventHandler(this.DateFilter_ValueChanged);
            // 
            // ButtonResetFilter
            // 
            this.ButtonResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonResetFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.ButtonResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResetFilter.Location = new System.Drawing.Point(521, 71);
            this.ButtonResetFilter.Name = "ButtonResetFilter";
            this.ButtonResetFilter.Size = new System.Drawing.Size(75, 23);
            this.ButtonResetFilter.TabIndex = 4;
            this.ButtonResetFilter.Text = "Сброс";
            this.ButtonResetFilter.UseVisualStyleBackColor = true;
            this.ButtonResetFilter.Click += new System.EventHandler(this.ButtonResetFilter_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(638, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Авторизоваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GridEvents);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Label LabelEvents;
        private System.Windows.Forms.DataGridView GridEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateFilter;
        private System.Windows.Forms.Button ButtonResetFilter;
        private System.Windows.Forms.Button button1;
    }
}