namespace WFA240718
{
    partial class FrmHelloWorld
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
            btnHello = new Button();
            lblText = new Label();
            tbName = new TextBox();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Enabled = false;
            btnHello.Font = new Font("Arial Black", 14F, FontStyle.Italic);
            btnHello.Location = new Point(12, 61);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(369, 66);
            btnHello.TabIndex = 0;
            btnHello.Text = "Köszönj!";
            btnHello.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 12F);
            lblText.Location = new Point(12, 15);
            lblText.Name = "lblText";
            lblText.Size = new Size(140, 28);
            lblText.TabIndex = 1;
            lblText.Text = "Írd be a neved:";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 12F);
            tbName.Location = new Point(165, 12);
            tbName.Name = "tbName";
            tbName.Size = new Size(216, 34);
            tbName.TabIndex = 2;
            // 
            // FrmHelloWorld
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(393, 139);
            Controls.Add(tbName);
            Controls.Add(lblText);
            Controls.Add(btnHello);
            Name = "FrmHelloWorld";
            Text = "Hello!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHello;
        private Label lblText;
        private TextBox tbName;
    }
}
