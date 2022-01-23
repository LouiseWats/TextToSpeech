namespace TextToSpeech
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
            this.speechBox = new System.Windows.Forms.RichTextBox();
            this.speech = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speechBox
            // 
            this.speechBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.speechBox.BackColor = System.Drawing.Color.AliceBlue;
            this.speechBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speechBox.Location = new System.Drawing.Point(33, 178);
            this.speechBox.Name = "speechBox";
            this.speechBox.Size = new System.Drawing.Size(730, 241);
            this.speechBox.TabIndex = 0;
            this.speechBox.Text = "";
            // 
            // speech
            // 
            this.speech.BackColor = System.Drawing.Color.AliceBlue;
            this.speech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speech.Location = new System.Drawing.Point(33, 120);
            this.speech.Name = "speech";
            this.speech.Size = new System.Drawing.Size(133, 52);
            this.speech.TabIndex = 1;
            this.speech.Text = "Speech";
            this.speech.UseVisualStyleBackColor = false;
            this.speech.Click += new System.EventHandler(this.speech_Click);
            this.speech.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.AliceBlue;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.Location = new System.Drawing.Point(182, 120);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(133, 52);
            this.pause.TabIndex = 1;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            this.pause.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.AliceBlue;
            this.resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume.Location = new System.Drawing.Point(330, 120);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(133, 52);
            this.resume.TabIndex = 1;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            this.resume.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(211, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text to Speech";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.AliceBlue;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(630, 120);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(133, 52);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.AliceBlue;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(479, 120);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(133, 52);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            this.Clear.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextToSpeech.Properties.Resources.spacebackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.speech);
            this.Controls.Add(this.speechBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_mousedown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_mousemove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_mouseup);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox speechBox;
        private System.Windows.Forms.Button speech;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
    }
}

