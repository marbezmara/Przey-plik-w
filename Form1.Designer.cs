
namespace Client
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
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.wybierzPlik = new System.Windows.Forms.Button();
            this.wyślijPlik = new System.Windows.Forms.Button();
            this.NazwaPliku = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(123, 44);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 22);
            this.textIP.TabIndex = 0;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(350, 47);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 22);
            this.textPort.TabIndex = 1;
            // 
            // wybierzPlik
            // 
            this.wybierzPlik.Location = new System.Drawing.Point(93, 124);
            this.wybierzPlik.Name = "wybierzPlik";
            this.wybierzPlik.Size = new System.Drawing.Size(172, 23);
            this.wybierzPlik.TabIndex = 2;
            this.wybierzPlik.Text = "Wybierz Plik";
            this.wybierzPlik.UseVisualStyleBackColor = true;
            this.wybierzPlik.Click += new System.EventHandler(this.PrzyciskWybierzPlik_Click);
            // 
            // wyślijPlik
            // 
            this.wyślijPlik.Location = new System.Drawing.Point(350, 104);
            this.wyślijPlik.Name = "wyślijPlik";
            this.wyślijPlik.Size = new System.Drawing.Size(154, 80);
            this.wyślijPlik.TabIndex = 3;
            this.wyślijPlik.Text = "Wyślij";
            this.wyślijPlik.UseVisualStyleBackColor = true;
            this.wyślijPlik.Click += new System.EventHandler(this.PrzyciskWyślijPlik);
            // 
            // NazwaPliku
            // 
            this.NazwaPliku.AutoSize = true;
            this.NazwaPliku.Location = new System.Drawing.Point(139, 167);
            this.NazwaPliku.Name = "NazwaPliku";
            this.NazwaPliku.Size = new System.Drawing.Size(0, 17);
            this.NazwaPliku.TabIndex = 4;
            this.NazwaPliku.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP:";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazwaPliku);
            this.Controls.Add(this.wyślijPlik);
            this.Controls.Add(this.wybierzPlik);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textIP);
            this.Name = "Form1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button wybierzPlik;
        private System.Windows.Forms.Button wyślijPlik;
        private System.Windows.Forms.Label NazwaPliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}