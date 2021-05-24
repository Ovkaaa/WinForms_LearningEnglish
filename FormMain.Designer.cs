
namespace Lerning_English
{
    partial class English
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
            this.lbWord = new System.Windows.Forms.Label();
            this.lbSpace = new System.Windows.Forms.Label();
            this.lbTranslate = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWord
            // 
            this.lbWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWord.Location = new System.Drawing.Point(0, 0);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(784, 70);
            this.lbWord.TabIndex = 0;
            this.lbWord.Text = "Учим англисские слова!";
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSpace
            // 
            this.lbSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSpace.Location = new System.Drawing.Point(0, 70);
            this.lbSpace.Name = "lbSpace";
            this.lbSpace.Size = new System.Drawing.Size(784, 70);
            this.lbSpace.TabIndex = 0;
            this.lbSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTranslate
            // 
            this.lbTranslate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTranslate.Location = new System.Drawing.Point(0, 140);
            this.lbTranslate.Name = "lbTranslate";
            this.lbTranslate.Size = new System.Drawing.Size(784, 70);
            this.lbTranslate.TabIndex = 0;
            this.lbTranslate.Text = "\"Next\" - что бы продолжить";
            this.lbTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(0, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(784, 65);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(0, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(784, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(0, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 71);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // English
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbTranslate);
            this.Controls.Add(this.lbSpace);
            this.Controls.Add(this.lbWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "English";
            this.Text = "English";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbSpace;
        private System.Windows.Forms.Label lbTranslate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
    }
}

