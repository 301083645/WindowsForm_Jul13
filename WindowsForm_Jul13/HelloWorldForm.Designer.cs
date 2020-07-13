namespace WindowsForm_Jul13
{
    partial class HelloWorldForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.EnterYourNameLabel = new System.Windows.Forms.Label();
            this.ClickMeBtn = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.WelcomeLabel.Location = new System.Drawing.Point(18, 214);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(776, 37);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Hello, World!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EnterYourNameLabel
            // 
            this.EnterYourNameLabel.AutoSize = true;
            this.EnterYourNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterYourNameLabel.ForeColor = System.Drawing.Color.Indigo;
            this.EnterYourNameLabel.Location = new System.Drawing.Point(327, 98);
            this.EnterYourNameLabel.Name = "EnterYourNameLabel";
            this.EnterYourNameLabel.Size = new System.Drawing.Size(158, 25);
            this.EnterYourNameLabel.TabIndex = 1;
            this.EnterYourNameLabel.Text = "Enter your Name";
            this.EnterYourNameLabel.Click += new System.EventHandler(this.CenterLabel_Click);
            // 
            // ClickMeBtn
            // 
            this.ClickMeBtn.AutoSize = true;
            this.ClickMeBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.ClickMeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ClickMeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClickMeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickMeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ClickMeBtn.Location = new System.Drawing.Point(338, 298);
            this.ClickMeBtn.Name = "ClickMeBtn";
            this.ClickMeBtn.Size = new System.Drawing.Size(136, 41);
            this.ClickMeBtn.TabIndex = 2;
            this.ClickMeBtn.Text = "Click Me!";
            this.ClickMeBtn.UseVisualStyleBackColor = false;
            this.ClickMeBtn.Click += new System.EventHandler(this.ClickMeBtn_Click);
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(292, 150);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(229, 38);
            this.NameText.TabIndex = 3;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ClickMeBtn);
            this.Controls.Add(this.EnterYourNameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label EnterYourNameLabel;
        private System.Windows.Forms.Button ClickMeBtn;
        private System.Windows.Forms.TextBox NameText;
    }
}

