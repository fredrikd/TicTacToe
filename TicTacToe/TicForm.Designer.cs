namespace TicTacToe
{
    partial class TicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicForm));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.player1Box = new System.Windows.Forms.ComboBox();
            this.player2Box = new System.Windows.Forms.ComboBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ticPanel = new TicTacToe.TicPanel();
            this.player2IconBox = new System.Windows.Forms.PictureBox();
            this.player1IconBox = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2IconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1IconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(327, 65);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(145, 13);
            this.copyrightLabel.TabIndex = 7;
            this.copyrightLabel.Text = "Copyright (C) MMXIII Grupp 1";
            // 
            // player1Box
            // 
            this.player1Box.AccessibleDescription = "dfgertert";
            this.player1Box.FormattingEnabled = true;
            this.player1Box.Location = new System.Drawing.Point(323, 117);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(150, 21);
            this.player1Box.TabIndex = 8;
            this.player1Box.Text = "Enter player or choose AI";
            // 
            // player2Box
            // 
            this.player2Box.AccessibleDescription = "dfgertert";
            this.player2Box.FormattingEnabled = true;
            this.player2Box.Location = new System.Drawing.Point(323, 160);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(150, 21);
            this.player2Box.TabIndex = 10;
            this.player2Box.Text = "Enter player or choose AI";
            // 
            // abortButton
            // 
            this.abortButton.Enabled = false;
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.abortButton.Location = new System.Drawing.Point(405, 290);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(68, 23);
            this.abortButton.TabIndex = 12;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Location = new System.Drawing.Point(323, 290);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(68, 23);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(339, 102);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(48, 13);
            this.player1Label.TabIndex = 15;
            this.player1Label.Text = "Player 1:";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(339, 145);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(48, 13);
            this.player2Label.TabIndex = 17;
            this.player2Label.Text = "Player 2:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.White;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.messageLabel.Location = new System.Drawing.Point(324, 248);
            this.messageLabel.MaximumSize = new System.Drawing.Size(150, 50);
            this.messageLabel.MinimumSize = new System.Drawing.Size(150, 2);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(150, 22);
            this.messageLabel.TabIndex = 19;
            this.messageLabel.Text = "Welcome!";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(323, 232);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.Text = "Status:";
            // 
            // ticPanel
            // 
            this.ticPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ticPanel.CurrentBoard = null;
            this.ticPanel.Location = new System.Drawing.Point(12, 12);
            this.ticPanel.Name = "ticPanel";
            this.ticPanel.Size = new System.Drawing.Size(301, 301);
            this.ticPanel.TabIndex = 2;
            // 
            // player2IconBox
            // 
            this.player2IconBox.Image = ((System.Drawing.Image)(resources.GetObject("player2IconBox.Image")));
            this.player2IconBox.Location = new System.Drawing.Point(324, 144);
            this.player2IconBox.Name = "player2IconBox";
            this.player2IconBox.Size = new System.Drawing.Size(14, 14);
            this.player2IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2IconBox.TabIndex = 18;
            this.player2IconBox.TabStop = false;
            // 
            // player1IconBox
            // 
            this.player1IconBox.Image = ((System.Drawing.Image)(resources.GetObject("player1IconBox.Image")));
            this.player1IconBox.Location = new System.Drawing.Point(324, 101);
            this.player1IconBox.Name = "player1IconBox";
            this.player1IconBox.Size = new System.Drawing.Size(14, 14);
            this.player1IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1IconBox.TabIndex = 16;
            this.player1IconBox.TabStop = false;
            // 
            // logoBox
            // 
            this.logoBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logoBox.ErrorImage")));
            this.logoBox.Image = global::TicTacToe.Properties.Resources.tic_logo_png;
            this.logoBox.InitialImage = null;
            this.logoBox.Location = new System.Drawing.Point(323, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(150, 50);
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // TicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 326);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.player2IconBox);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1IconBox);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.ticPanel);
            this.Controls.Add(this.logoBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TicForm";
            this.Text = "Tic Tac Toe .NET";
            this.Load += new System.EventHandler(this.TicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player2IconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1IconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private TicPanel ticPanel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.ComboBox player1Box;
        private System.Windows.Forms.ComboBox player2Box;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox player1IconBox;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.PictureBox player2IconBox;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}

