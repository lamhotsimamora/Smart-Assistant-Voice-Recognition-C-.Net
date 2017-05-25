namespace VoiceRecognition
{
    partial class frmUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtama));
            this.rt_echo = new System.Windows.Forms.RichTextBox();
            this.btn_enable_voice = new System.Windows.Forms.Button();
            this.btn_disable_voice = new System.Windows.Forms.Button();
            this.btn_talk = new System.Windows.Forms.Button();
            this.btn_print_command = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rt_echo
            // 
            this.rt_echo.BackColor = System.Drawing.Color.Black;
            this.rt_echo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rt_echo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_echo.ForeColor = System.Drawing.Color.IndianRed;
            this.rt_echo.Location = new System.Drawing.Point(23, 63);
            this.rt_echo.Name = "rt_echo";
            this.rt_echo.Size = new System.Drawing.Size(704, 69);
            this.rt_echo.TabIndex = 0;
            this.rt_echo.Text = "";
            // 
            // btn_enable_voice
            // 
            this.btn_enable_voice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enable_voice.ForeColor = System.Drawing.Color.White;
            this.btn_enable_voice.Location = new System.Drawing.Point(23, 143);
            this.btn_enable_voice.Name = "btn_enable_voice";
            this.btn_enable_voice.Size = new System.Drawing.Size(91, 30);
            this.btn_enable_voice.TabIndex = 1;
            this.btn_enable_voice.Text = "Start";
            this.btn_enable_voice.UseVisualStyleBackColor = true;
            this.btn_enable_voice.Click += new System.EventHandler(this.btn_enable_voice_Click);
            // 
            // btn_disable_voice
            // 
            this.btn_disable_voice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disable_voice.ForeColor = System.Drawing.Color.White;
            this.btn_disable_voice.Location = new System.Drawing.Point(120, 143);
            this.btn_disable_voice.Name = "btn_disable_voice";
            this.btn_disable_voice.Size = new System.Drawing.Size(91, 30);
            this.btn_disable_voice.TabIndex = 2;
            this.btn_disable_voice.Text = "STOP";
            this.btn_disable_voice.UseVisualStyleBackColor = true;
            this.btn_disable_voice.Click += new System.EventHandler(this.btn_disable_voice_Click);
            // 
            // btn_talk
            // 
            this.btn_talk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_talk.ForeColor = System.Drawing.Color.White;
            this.btn_talk.Image = ((System.Drawing.Image)(resources.GetObject("btn_talk.Image")));
            this.btn_talk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_talk.Location = new System.Drawing.Point(642, 138);
            this.btn_talk.Name = "btn_talk";
            this.btn_talk.Size = new System.Drawing.Size(85, 40);
            this.btn_talk.TabIndex = 3;
            this.btn_talk.Text = "TALK";
            this.btn_talk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_talk.UseVisualStyleBackColor = true;
            this.btn_talk.Click += new System.EventHandler(this.btn_talk_Click);
            // 
            // btn_print_command
            // 
            this.btn_print_command.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_command.ForeColor = System.Drawing.Color.White;
            this.btn_print_command.Image = ((System.Drawing.Image)(resources.GetObject("btn_print_command.Image")));
            this.btn_print_command.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print_command.Location = new System.Drawing.Point(510, 138);
            this.btn_print_command.Name = "btn_print_command";
            this.btn_print_command.Size = new System.Drawing.Size(126, 40);
            this.btn_print_command.TabIndex = 5;
            this.btn_print_command.Text = "Print Command";
            this.btn_print_command.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print_command.UseVisualStyleBackColor = true;
            this.btn_print_command.Click += new System.EventHandler(this.btn_print_command_Click);
            // 
            // frmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 192);
            this.Controls.Add(this.btn_print_command);
            this.Controls.Add(this.btn_talk);
            this.Controls.Add(this.btn_disable_voice);
            this.Controls.Add(this.btn_enable_voice);
            this.Controls.Add(this.rt_echo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUtama";
            this.Resizable = false;
            this.Text = "goSmart || LamhotSimamora.com";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            this.Load += new System.EventHandler(this.frmUtama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_echo;
        private System.Windows.Forms.Button btn_enable_voice;
        private System.Windows.Forms.Button btn_disable_voice;
        private System.Windows.Forms.Button btn_talk;
        private System.Windows.Forms.Button btn_print_command;
    }
}