namespace RSv1CS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.onClickBtn = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.authorLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // onClickBtn
            // 
            this.onClickBtn.Location = new System.Drawing.Point(86, 41);
            this.onClickBtn.Name = "onClickBtn";
            this.onClickBtn.Size = new System.Drawing.Size(75, 23);
            this.onClickBtn.TabIndex = 0;
            this.onClickBtn.Text = "Submit";
            this.onClickBtn.UseVisualStyleBackColor = true;
            this.onClickBtn.Click += new System.EventHandler(this.onClickBtn_Click);
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultText.Location = new System.Drawing.Point(12, 80);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 21);
            this.resultText.TabIndex = 1;
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(12, 12);
            this.userInput.Name = "userInput";
            this.userInput.PlaceholderText = "Enter name";
            this.userInput.Size = new System.Drawing.Size(227, 23);
            this.userInput.TabIndex = 2;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged_1);
            // 
            // authorLink
            // 
            this.authorLink.AutoSize = true;
            this.authorLink.Location = new System.Drawing.Point(141, 92);
            this.authorLink.Name = "authorLink";
            this.authorLink.Size = new System.Drawing.Size(107, 15);
            this.authorLink.TabIndex = 3;
            this.authorLink.TabStop = true;
            this.authorLink.Text = "Created by Joshboi";
            this.authorLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.authorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 110);
            this.Controls.Add(this.authorLink);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.onClickBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(267, 149);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JARS V1.0 demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button onClickBtn;
        private Label resultText;
        private TextBox userInput;
        private EventHandler resultText_Click;
        private EventHandler userInput_TextChanged;
        private LinkLabel authorLink;
    }
}