﻿namespace Quanlysanbong
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtSânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtSânToolStripMenuItem,
            this.thanhToánToolStripMenuItem,
            this.quảnLýSânToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // đặtSânToolStripMenuItem
            // 
            this.đặtSânToolStripMenuItem.Name = "đặtSânToolStripMenuItem";
            this.đặtSânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đặtSânToolStripMenuItem.Text = "Đặt sân";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // quảnLýSânToolStripMenuItem
            // 
            this.quảnLýSânToolStripMenuItem.Name = "quảnLýSânToolStripMenuItem";
            this.quảnLýSânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýSânToolStripMenuItem.Text = "Quản lý sân";
            this.quảnLýSânToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSânToolStripMenuItem_Click);
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 683);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Hệ thống quản lý sân bóng đá";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem đặtSânToolStripMenuItem;
        private ToolStripMenuItem thanhToánToolStripMenuItem;
        private ToolStripMenuItem quảnLýSânToolStripMenuItem;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}