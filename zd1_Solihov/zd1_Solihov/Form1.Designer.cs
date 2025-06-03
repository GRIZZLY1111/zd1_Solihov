
namespace zd1_Solihov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.второеЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.третьеЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.второеЗаданиеToolStripMenuItem,
            this.третьеЗаданиеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // второеЗаданиеToolStripMenuItem
            // 
            this.второеЗаданиеToolStripMenuItem.Name = "второеЗаданиеToolStripMenuItem";
            this.второеЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.второеЗаданиеToolStripMenuItem.Text = "Второе задание";
            this.второеЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.второеЗаданиеToolStripMenuItem_Click);
            // 
            // третьеЗаданиеToolStripMenuItem
            // 
            this.третьеЗаданиеToolStripMenuItem.Name = "третьеЗаданиеToolStripMenuItem";
            this.третьеЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.третьеЗаданиеToolStripMenuItem.Text = "Третье задание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem второеЗаданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem третьеЗаданиеToolStripMenuItem;
    }
}

