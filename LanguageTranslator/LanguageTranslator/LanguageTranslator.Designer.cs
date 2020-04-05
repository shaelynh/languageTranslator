namespace LanguageTranslator
{
    partial class LangTranslatorForm
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.btnItailan = new System.Windows.Forms.Button();
            this.btnSpanish = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(46, 32);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(340, 16);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select a language and I will say good morning";
            // 
            // lblTranslation
            // 
            this.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTranslation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslation.Location = new System.Drawing.Point(49, 66);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(324, 23);
            this.lblTranslation.TabIndex = 1;
            this.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnItailan
            // 
            this.btnItailan.Location = new System.Drawing.Point(49, 133);
            this.btnItailan.Name = "btnItailan";
            this.btnItailan.Size = new System.Drawing.Size(75, 23);
            this.btnItailan.TabIndex = 2;
            this.btnItailan.Text = "Italian";
            this.btnItailan.UseVisualStyleBackColor = true;
            this.btnItailan.Click += new System.EventHandler(this.btnItailan_Click);
            // 
            // btnSpanish
            // 
            this.btnSpanish.Location = new System.Drawing.Point(180, 133);
            this.btnSpanish.Name = "btnSpanish";
            this.btnSpanish.Size = new System.Drawing.Size(75, 23);
            this.btnSpanish.TabIndex = 3;
            this.btnSpanish.Text = "Spanish";
            this.btnSpanish.UseVisualStyleBackColor = true;
            this.btnSpanish.Click += new System.EventHandler(this.btnSpanish_Click_1);
            // 
            // btnGerman
            // 
            this.btnGerman.Location = new System.Drawing.Point(311, 133);
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.Size = new System.Drawing.Size(75, 23);
            this.btnGerman.TabIndex = 4;
            this.btnGerman.Text = "German";
            this.btnGerman.UseVisualStyleBackColor = true;
            this.btnGerman.Click += new System.EventHandler(this.btnGerman_Click_1);
            // 
            // LangTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 205);
            this.Controls.Add(this.btnGerman);
            this.Controls.Add(this.btnSpanish);
            this.Controls.Add(this.btnItailan);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblSelect);
            this.Name = "LangTranslatorForm";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Button btnItailan;
        private System.Windows.Forms.Button btnSpanish;
        private System.Windows.Forms.Button btnGerman;
    }
}

