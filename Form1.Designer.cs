namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblConnectionId = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblConnectionIdValue = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnStream = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Snow;
            this.lblStatus.Location = new System.Drawing.Point(16, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(191, 29);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Kinect Status  : ";
            // 
            // lblConnectionId
            // 
            this.lblConnectionId.AutoSize = true;
            this.lblConnectionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionId.Location = new System.Drawing.Point(6, 42);
            this.lblConnectionId.Name = "lblConnectionId";
            this.lblConnectionId.Size = new System.Drawing.Size(189, 29);
            this.lblConnectionId.TabIndex = 1;
            this.lblConnectionId.Text = "Connection Id : ";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusValue.ForeColor = System.Drawing.Color.Snow;
            this.lblStatusValue.Location = new System.Drawing.Point(218, 7);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(21, 29);
            this.lblStatusValue.TabIndex = 2;
            this.lblStatusValue.Text = "-";
            // 
            // lblConnectionIdValue
            // 
            this.lblConnectionIdValue.AutoSize = true;
            this.lblConnectionIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionIdValue.Location = new System.Drawing.Point(209, 41);
            this.lblConnectionIdValue.Name = "lblConnectionIdValue";
            this.lblConnectionIdValue.Size = new System.Drawing.Size(21, 29);
            this.lblConnectionIdValue.TabIndex = 3;
            this.lblConnectionIdValue.Text = "-";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(474, 9);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(29, 29);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "--";
            // 
            // btnStream
            // 
            this.btnStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStream.Location = new System.Drawing.Point(1552, 8);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(222, 50);
            this.btnStream.TabIndex = 10;
            this.btnStream.Text = "Start";
            this.btnStream.UseVisualStyleBackColor = false;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1773, 713);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(1170, 12);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(147, 29);
            this.lblPort.TabIndex = 13;
            this.lblPort.Text = "COM PORT";
            // 
            // cboComPort
            // 
            this.cboComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(1336, 9);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 37);
            this.cboComPort.TabIndex = 12;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(875, 9);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(289, 52);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1788, 862);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cboComPort);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConnectionIdValue);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblConnectionId);
            this.Controls.Add(this.lblStatus);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblConnectionId;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblConnectionIdValue;
        private System.Windows.Forms.Label lblPosition;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cboComPort;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

