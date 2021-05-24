
namespace Lerning_English
{
    partial class FormAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.lbWord = new System.Windows.Forms.Label();
            this.lbTranslate = new System.Windows.Forms.Label();
            this.tbTranslate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(192, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 65);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(551, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 65);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbWord
            // 
            this.tbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWord.Location = new System.Drawing.Point(192, 12);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(420, 30);
            this.tbWord.TabIndex = 1;
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWord.Location = new System.Drawing.Point(12, 17);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(154, 25);
            this.lbWord.TabIndex = 2;
            this.lbWord.Text = "Слово/Фраза:";
            // 
            // lbTranslate
            // 
            this.lbTranslate.AutoSize = true;
            this.lbTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTranslate.Location = new System.Drawing.Point(12, 76);
            this.lbTranslate.Name = "lbTranslate";
            this.lbTranslate.Size = new System.Drawing.Size(106, 25);
            this.lbTranslate.TabIndex = 2;
            this.lbTranslate.Text = "Перевод:";
            // 
            // tbTranslate
            // 
            this.tbTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTranslate.Location = new System.Drawing.Point(192, 76);
            this.tbTranslate.Name = "tbTranslate";
            this.tbTranslate.Size = new System.Drawing.Size(420, 30);
            this.tbTranslate.TabIndex = 2;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.lbTranslate);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.tbTranslate);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbTranslate;
        private System.Windows.Forms.TextBox tbTranslate;
    }
}