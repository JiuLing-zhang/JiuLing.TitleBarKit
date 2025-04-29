namespace JiuLing.TitleBarKit.WinForms.Test
{
    partial class FmMain
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
            blazorWebView1 = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            panel1 = new Panel();
            BtnClose = new Button();
            BtnToggleMaximize = new Button();
            BtnMinimize = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // blazorWebView1
            // 
            blazorWebView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            blazorWebView1.Location = new Point(0, 41);
            blazorWebView1.Name = "blazorWebView1";
            blazorWebView1.Size = new Size(526, 283);
            blazorWebView1.TabIndex = 0;
            blazorWebView1.Text = "blazorWebView1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(BtnClose);
            panel1.Controls.Add(BtnToggleMaximize);
            panel1.Controls.Add(BtnMinimize);
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.SizeAll;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 38);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.FlatStyle = FlatStyle.Popup;
            BtnClose.Location = new Point(486, 9);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(28, 26);
            BtnClose.TabIndex = 3;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnToggleMaximize
            // 
            BtnToggleMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnToggleMaximize.FlatStyle = FlatStyle.Popup;
            BtnToggleMaximize.Location = new Point(452, 9);
            BtnToggleMaximize.Name = "BtnToggleMaximize";
            BtnToggleMaximize.Size = new Size(28, 26);
            BtnToggleMaximize.TabIndex = 2;
            BtnToggleMaximize.Text = "🗖";
            BtnToggleMaximize.UseVisualStyleBackColor = true;
            BtnToggleMaximize.Click += BtnToggleMaximize_Click;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimize.FlatStyle = FlatStyle.Popup;
            BtnMinimize.Location = new Point(418, 9);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(28, 26);
            BtnMinimize.TabIndex = 1;
            BtnMinimize.Text = "_";
            BtnMinimize.UseVisualStyleBackColor = true;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 0;
            label1.Text = "WinForms 原生控件";
            // 
            // FmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 324);
            Controls.Add(panel1);
            Controls.Add(blazorWebView1);
            Name = "FmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForms 原生标题栏";
            Load += FmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView1;
        private Panel panel1;
        private Label label1;
        private Button BtnMinimize;
        private Button BtnToggleMaximize;
        private Button BtnClose;
    }
}
