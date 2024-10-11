namespace SayiTahmin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            lblGirilen = new Label();
            txtGirilenSayi = new TextBox();
            btnTahmin = new Button();
            lblInfo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            lblBilgi = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(100, 37);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(494, 47);
            btnStart.TabIndex = 0;
            btnStart.Text = "Oyunu Başlat";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblGirilen
            // 
            lblGirilen.AutoSize = true;
            lblGirilen.Location = new Point(100, 114);
            lblGirilen.Name = "lblGirilen";
            lblGirilen.Size = new Size(207, 20);
            lblGirilen.TabIndex = 1;
            lblGirilen.Text = "1 -100 arasında bir sayi giriniz";
            lblGirilen.Click += lblGirilen_Click;
            // 
            // txtGirilenSayi
            // 
            txtGirilenSayi.Location = new Point(313, 111);
            txtGirilenSayi.Name = "txtGirilenSayi";
            txtGirilenSayi.Size = new Size(281, 27);
            txtGirilenSayi.TabIndex = 2;
            // 
            // btnTahmin
            // 
            btnTahmin.Location = new Point(100, 161);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(494, 42);
            btnTahmin.TabIndex = 3;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(25, 296);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 20);
            lblInfo.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(100, 224);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(494, 29);
            progressBar1.TabIndex = 6;
            progressBar1.Click += progressBar1_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Location = new Point(43, 362);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(50, 20);
            lblBilgi.TabIndex = 7;
            lblBilgi.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 392);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 435);
            Controls.Add(label2);
            Controls.Add(lblBilgi);
            Controls.Add(progressBar1);
            Controls.Add(lblInfo);
            Controls.Add(btnTahmin);
            Controls.Add(txtGirilenSayi);
            Controls.Add(lblGirilen);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label lblGirilen;
        private TextBox txtGirilenSayi;
        private Button btnTahmin;
        private Label lblInfo;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label lblBilgi;
        private Label label2;
    }
}
