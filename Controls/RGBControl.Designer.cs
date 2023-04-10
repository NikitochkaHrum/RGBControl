
namespace Controls
{
    partial class RGBControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labRed = new System.Windows.Forms.Label();
            this.ntbRed = new Controls.NumberTextBox(this.components);
            this.labGreen = new System.Windows.Forms.Label();
            this.labBlue = new System.Windows.Forms.Label();
            this.ntbGreen = new Controls.NumberTextBox(this.components);
            this.ntbBlue = new Controls.NumberTextBox(this.components);
            this.rbutDec = new System.Windows.Forms.RadioButton();
            this.rbutHex = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labRed
            // 
            this.labRed.AutoSize = true;
            this.labRed.Location = new System.Drawing.Point(19, 27);
            this.labRed.Name = "labRed";
            this.labRed.Size = new System.Drawing.Size(71, 20);
            this.labRed.TabIndex = 0;
            this.labRed.Text = "Красный";
            // 
            // ntbRed
            // 
            this.ntbRed.Location = new System.Drawing.Point(117, 27);
            this.ntbRed.MaxLength = 3;
            this.ntbRed.Name = "ntbRed";
            this.ntbRed.Size = new System.Drawing.Size(114, 27);
            this.ntbRed.TabIndex = 1;
            this.ntbRed.TextMode = NumberTextBox.Mode.Dec;
            this.ntbRed.TextChanged += new System.EventHandler(this.ntbRed_TextChanged);
            // 
            // labGreen
            // 
            this.labGreen.AutoSize = true;
            this.labGreen.Location = new System.Drawing.Point(19, 78);
            this.labGreen.Name = "labGreen";
            this.labGreen.Size = new System.Drawing.Size(70, 20);
            this.labGreen.TabIndex = 2;
            this.labGreen.Text = "Зелёный";
            // 
            // labBlue
            // 
            this.labBlue.AutoSize = true;
            this.labBlue.Location = new System.Drawing.Point(19, 128);
            this.labBlue.Name = "labBlue";
            this.labBlue.Size = new System.Drawing.Size(54, 20);
            this.labBlue.TabIndex = 3;
            this.labBlue.Text = "Синий";
            // 
            // ntbGreen
            // 
            this.ntbGreen.Location = new System.Drawing.Point(117, 78);
            this.ntbGreen.MaxLength = 3;
            this.ntbGreen.Name = "ntbGreen";
            this.ntbGreen.Size = new System.Drawing.Size(113, 27);
            this.ntbGreen.TabIndex = 4;
            this.ntbGreen.TextMode = NumberTextBox.Mode.Dec;
            this.ntbGreen.TextChanged += new System.EventHandler(this.ntbGreen_TextChanged);
            // 
            // ntbBlue
            // 
            this.ntbBlue.Location = new System.Drawing.Point(117, 128);
            this.ntbBlue.MaxLength = 3;
            this.ntbBlue.Name = "ntbBlue";
            this.ntbBlue.Size = new System.Drawing.Size(114, 27);
            this.ntbBlue.TabIndex = 5;
            this.ntbBlue.TextMode = NumberTextBox.Mode.Dec;
            this.ntbBlue.TextChanged += new System.EventHandler(this.ntbBlue_TextChanged);
            // 
            // rbutDec
            // 
            this.rbutDec.AutoSize = true;
            this.rbutDec.Location = new System.Drawing.Point(34, 185);
            this.rbutDec.Name = "rbutDec";
            this.rbutDec.Size = new System.Drawing.Size(56, 24);
            this.rbutDec.TabIndex = 6;
            this.rbutDec.TabStop = true;
            this.rbutDec.Text = "Dec";
            this.rbutDec.UseVisualStyleBackColor = true;
            this.rbutDec.CheckedChanged += new System.EventHandler(this.rbutDec_CheckedChanged);
            // 
            // rbutHex
            // 
            this.rbutHex.AutoSize = true;
            this.rbutHex.Location = new System.Drawing.Point(147, 185);
            this.rbutHex.Name = "rbutHex";
            this.rbutHex.Size = new System.Drawing.Size(56, 24);
            this.rbutHex.TabIndex = 7;
            this.rbutHex.TabStop = true;
            this.rbutHex.Text = "Hex";
            this.rbutHex.UseVisualStyleBackColor = true;
            this.rbutHex.CheckedChanged += new System.EventHandler(this.rbutHex_CheckedChanged);
            // 
            // RGBControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbutHex);
            this.Controls.Add(this.rbutDec);
            this.Controls.Add(this.ntbBlue);
            this.Controls.Add(this.ntbGreen);
            this.Controls.Add(this.labBlue);
            this.Controls.Add(this.labGreen);
            this.Controls.Add(this.ntbRed);
            this.Controls.Add(this.labRed);
            this.Name = "RGBControl";
            this.Size = new System.Drawing.Size(337, 236);
            this.Load += new System.EventHandler(this.RGBControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRed;
        private NumberTextBox ntbRed;
        private System.Windows.Forms.Label labGreen;
        private System.Windows.Forms.Label labBlue;
        private NumberTextBox ntbGreen;
        private NumberTextBox ntbBlue;
        private System.Windows.Forms.RadioButton rbutDec;
        private System.Windows.Forms.RadioButton rbutHex;
    }
}
