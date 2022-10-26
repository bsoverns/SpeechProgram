namespace Speech_Test
{
    partial class frmMain
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
            this.btnSpeak = new System.Windows.Forms.Button();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.txtAllSpeech = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(289, 260);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 0;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(13, 29);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(351, 60);
            this.txtWords.TabIndex = 1;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(12, 260);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnStopListening
            // 
            this.btnStopListening.Enabled = false;
            this.btnStopListening.Location = new System.Drawing.Point(93, 260);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(75, 23);
            this.btnStopListening.TabIndex = 3;
            this.btnStopListening.Text = "Stop";
            this.btnStopListening.UseVisualStyleBackColor = true;
            this.btnStopListening.Click += new System.EventHandler(this.btnStopListening_Click);
            // 
            // txtAllSpeech
            // 
            this.txtAllSpeech.Location = new System.Drawing.Point(13, 120);
            this.txtAllSpeech.Multiline = true;
            this.txtAllSpeech.Name = "txtAllSpeech";
            this.txtAllSpeech.Size = new System.Drawing.Size(351, 125);
            this.txtAllSpeech.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recognized Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Text Captured";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAllSpeech);
            this.Controls.Add(this.btnStopListening);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.btnSpeak);
            this.Name = "frmMain";
            this.Text = "Speech Recognition and Speaking";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnStopListening;
        private System.Windows.Forms.TextBox txtAllSpeech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

