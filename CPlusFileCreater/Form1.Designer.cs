namespace CPlusFileCreater
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.PageController = new System.Windows.Forms.TabControl();
			this.MainPage = new System.Windows.Forms.TabPage();
			this.Btn_OpenBrows = new System.Windows.Forms.Button();
			this.Input_ConfigAddr = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.PageController.SuspendLayout();
			this.MainPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// PageController
			// 
			this.PageController.Controls.Add(this.MainPage);
			this.PageController.Controls.Add(this.tabPage2);
			this.PageController.Location = new System.Drawing.Point(-7, 0);
			this.PageController.Name = "PageController";
			this.PageController.SelectedIndex = 0;
			this.PageController.Size = new System.Drawing.Size(1227, 802);
			this.PageController.TabIndex = 0;
			// 
			// MainPage
			// 
			this.MainPage.Controls.Add(this.Btn_OpenBrows);
			this.MainPage.Controls.Add(this.Input_ConfigAddr);
			this.MainPage.Location = new System.Drawing.Point(4, 22);
			this.MainPage.Name = "MainPage";
			this.MainPage.Padding = new System.Windows.Forms.Padding(3);
			this.MainPage.Size = new System.Drawing.Size(1219, 776);
			this.MainPage.TabIndex = 0;
			this.MainPage.Text = "MainPage";
			this.MainPage.UseVisualStyleBackColor = true;
			this.MainPage.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// Btn_OpenBrows
			// 
			this.Btn_OpenBrows.Location = new System.Drawing.Point(792, 31);
			this.Btn_OpenBrows.Name = "Btn_OpenBrows";
			this.Btn_OpenBrows.Size = new System.Drawing.Size(75, 23);
			this.Btn_OpenBrows.TabIndex = 1;
			this.Btn_OpenBrows.Text = "浏  览";
			this.Btn_OpenBrows.UseVisualStyleBackColor = true;
			this.Btn_OpenBrows.Click += new System.EventHandler(this.Btn_OpenBrows_Click);
			// 
			// Input_ConfigAddr
			// 
			this.Input_ConfigAddr.Location = new System.Drawing.Point(15, 31);
			this.Input_ConfigAddr.Name = "Input_ConfigAddr";
			this.Input_ConfigAddr.Size = new System.Drawing.Size(723, 21);
			this.Input_ConfigAddr.TabIndex = 0;
			this.Input_ConfigAddr.Text = "请输入配置文件名";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1219, 776);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1212, 796);
			this.Controls.Add(this.PageController);
			this.Name = "Form1";
			this.Text = "ClassCreater";
			this.PageController.ResumeLayout(false);
			this.MainPage.ResumeLayout(false);
			this.MainPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl PageController;
		private System.Windows.Forms.TabPage MainPage;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox Input_ConfigAddr;
		private System.Windows.Forms.Button Btn_OpenBrows;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		//private System.Windows.Forms.TabPage tabPage3;
	}
}

