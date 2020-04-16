namespace Blocknot
{
    partial class MainForm
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
            this.butOpenFile = new System.Windows.Forms.Button();
            this.fldFilePath = new System.Windows.Forms.TextBox();
            this.butSelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numeFont = new System.Windows.Forms.NumericUpDown();
            this.fileContent = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numeFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butOpenFile
            // 
            this.butOpenFile.Location = new System.Drawing.Point(12, 12);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(93, 48);
            this.butOpenFile.TabIndex = 0;
            this.butOpenFile.Text = "OpenFile";
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // fldFilePath
            // 
            this.fldFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldFilePath.Location = new System.Drawing.Point(111, 27);
            this.fldFilePath.Name = "fldFilePath";
            this.fldFilePath.Size = new System.Drawing.Size(567, 20);
            this.fldFilePath.TabIndex = 1;
            // 
            // butSelectFile
            // 
            this.butSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectFile.Location = new System.Drawing.Point(692, 12);
            this.butSelectFile.Name = "butSelectFile";
            this.butSelectFile.Size = new System.Drawing.Size(96, 48);
            this.butSelectFile.TabIndex = 2;
            this.butSelectFile.Text = "Выбор файла";
            this.butSelectFile.UseVisualStyleBackColor = true;
            this.butSelectFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Шрифт";
            // 
            // numeFont
            // 
            this.numeFont.Location = new System.Drawing.Point(92, 65);
            this.numeFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numeFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numeFont.Name = "numeFont";
            this.numeFont.Size = new System.Drawing.Size(120, 20);
            this.numeFont.TabIndex = 4;
            this.numeFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // fileContent
            // 
            this.fileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileContent.Location = new System.Drawing.Point(12, 105);
            this.fileContent.Multiline = true;
            this.fileContent.Name = "fileContent";
            this.fileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileContent.Size = new System.Drawing.Size(776, 280);
            this.fileContent.TabIndex = 5;
            // 
            // butSave
            // 
            this.butSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butSave.Location = new System.Drawing.Point(710, 391);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(78, 34);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSymbolCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "Количество смволов ";
            // 
            // lblSymbolCount
            // 
            this.lblSymbolCount.Name = "lblSymbolCount";
            this.lblSymbolCount.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.fileContent);
            this.Controls.Add(this.numeFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSelectFile);
            this.Controls.Add(this.fldFilePath);
            this.Controls.Add(this.butOpenFile);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.TextBox fldFilePath;
        private System.Windows.Forms.Button butSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeFont;
        private System.Windows.Forms.TextBox fileContent;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSymbolCount;
    }
}

