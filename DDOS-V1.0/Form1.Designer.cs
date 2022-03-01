
namespace DDOS_V1._0
{
    partial class mainDDOS
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.attackButton = new FontAwesome.Sharp.IconButton();
            this.targetBox = new System.Windows.Forms.TextBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.stopButton = new FontAwesome.Sharp.IconButton();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.limitBox = new System.Windows.Forms.TextBox();
            this.limitLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.Color.Green;
            this.infoLabel.Location = new System.Drawing.Point(240, 30);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(203, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "DDoS V1.0 Attack program created by Ju";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.X);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(701, 27);
            this.topPanel.TabIndex = 1;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Black;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.FlatAppearance.BorderSize = 0;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.X.ForeColor = System.Drawing.Color.DarkGreen;
            this.X.Location = new System.Drawing.Point(661, 3);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(37, 23);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // attackButton
            // 
            this.attackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.attackButton.IconColor = System.Drawing.Color.Black;
            this.attackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.attackButton.IconSize = 30;
            this.attackButton.Location = new System.Drawing.Point(243, 131);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(78, 35);
            this.attackButton.TabIndex = 2;
            this.attackButton.Text = "Attack";
            this.attackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // targetBox
            // 
            this.targetBox.Location = new System.Drawing.Point(257, 69);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(165, 20);
            this.targetBox.TabIndex = 3;
            // 
            // targetLabel
            // 
            this.targetLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.targetLabel.AutoSize = true;
            this.targetLabel.ForeColor = System.Drawing.Color.Green;
            this.targetLabel.Location = new System.Drawing.Point(146, 72);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(105, 13);
            this.targetLabel.TabIndex = 4;
            this.targetLabel.Text = "Write Target website";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.stopButton.IconColor = System.Drawing.Color.Black;
            this.stopButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stopButton.IconSize = 30;
            this.stopButton.Location = new System.Drawing.Point(406, 131);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(78, 35);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.Black;
            this.infoBox.ForeColor = System.Drawing.Color.Green;
            this.infoBox.Location = new System.Drawing.Point(220, 219);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(289, 85);
            this.infoBox.TabIndex = 6;
            this.infoBox.Text = "Attacking";
            // 
            // limitBox
            // 
            this.limitBox.Location = new System.Drawing.Point(506, 69);
            this.limitBox.Name = "limitBox";
            this.limitBox.Size = new System.Drawing.Size(71, 20);
            this.limitBox.TabIndex = 7;
            // 
            // limitLabel
            // 
            this.limitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.limitLabel.AutoSize = true;
            this.limitLabel.ForeColor = System.Drawing.Color.Green;
            this.limitLabel.Location = new System.Drawing.Point(428, 72);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(72, 13);
            this.limitLabel.TabIndex = 8;
            this.limitLabel.Text = "Thread Count";
            // 
            // mainDDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(701, 395);
            this.Controls.Add(this.limitLabel);
            this.Controls.Add(this.limitBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.targetBox);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.infoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainDDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDOS V1.0 by Juuu";
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button X;
        private FontAwesome.Sharp.IconButton attackButton;
        private System.Windows.Forms.TextBox targetBox;
        private System.Windows.Forms.Label targetLabel;
        private FontAwesome.Sharp.IconButton stopButton;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.TextBox limitBox;
        private System.Windows.Forms.Label limitLabel;
    }
}

