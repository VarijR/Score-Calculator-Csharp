namespace ScoreCalculator
{
    partial class Form1
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
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_stotal = new System.Windows.Forms.Label();
            this.lbl_scount = new System.Windows.Forms.Label();
            this.lbl_avg = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.txt_stotal = new System.Windows.Forms.TextBox();
            this.txt_scount = new System.Windows.Forms.TextBox();
            this.txt_avg = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(67, 43);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(50, 17);
            this.lbl_score.TabIndex = 0;
            this.lbl_score.Text = "Score :";
            // 
            // lbl_stotal
            // 
            this.lbl_stotal.AutoSize = true;
            this.lbl_stotal.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stotal.Location = new System.Drawing.Point(67, 84);
            this.lbl_stotal.Name = "lbl_stotal";
            this.lbl_stotal.Size = new System.Drawing.Size(85, 17);
            this.lbl_stotal.TabIndex = 1;
            this.lbl_stotal.Text = "Score Total :";
            // 
            // lbl_scount
            // 
            this.lbl_scount.AutoSize = true;
            this.lbl_scount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scount.Location = new System.Drawing.Point(67, 124);
            this.lbl_scount.Name = "lbl_scount";
            this.lbl_scount.Size = new System.Drawing.Size(90, 17);
            this.lbl_scount.TabIndex = 2;
            this.lbl_scount.Text = "Score Count :";
            // 
            // lbl_avg
            // 
            this.lbl_avg.AutoSize = true;
            this.lbl_avg.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avg.Location = new System.Drawing.Point(67, 166);
            this.lbl_avg.Name = "lbl_avg";
            this.lbl_avg.Size = new System.Drawing.Size(65, 17);
            this.lbl_avg.TabIndex = 3;
            this.lbl_avg.Text = "Average :";
            // 
            // txt_score
            // 
            this.txt_score.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score.Location = new System.Drawing.Point(176, 43);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(74, 25);
            this.txt_score.TabIndex = 4;
            // 
            // txt_stotal
            // 
            this.txt_stotal.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stotal.Location = new System.Drawing.Point(176, 81);
            this.txt_stotal.Name = "txt_stotal";
            this.txt_stotal.ReadOnly = true;
            this.txt_stotal.Size = new System.Drawing.Size(74, 25);
            this.txt_stotal.TabIndex = 5;
            this.txt_stotal.TabStop = false;
            // 
            // txt_scount
            // 
            this.txt_scount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_scount.Location = new System.Drawing.Point(176, 121);
            this.txt_scount.Name = "txt_scount";
            this.txt_scount.ReadOnly = true;
            this.txt_scount.Size = new System.Drawing.Size(74, 25);
            this.txt_scount.TabIndex = 6;
            this.txt_scount.TabStop = false;
            // 
            // txt_avg
            // 
            this.txt_avg.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avg.Location = new System.Drawing.Point(176, 163);
            this.txt_avg.Name = "txt_avg";
            this.txt_avg.ReadOnly = true;
            this.txt_avg.Size = new System.Drawing.Size(74, 25);
            this.txt_avg.TabIndex = 7;
            this.txt_avg.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(315, 73);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 28);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(104, 224);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 28);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear Score";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(236, 224);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 28);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(448, 277);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_avg);
            this.Controls.Add(this.txt_scount);
            this.Controls.Add(this.txt_stotal);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.lbl_avg);
            this.Controls.Add(this.lbl_scount);
            this.Controls.Add(this.lbl_stotal);
            this.Controls.Add(this.lbl_score);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_stotal;
        private System.Windows.Forms.Label lbl_scount;
        private System.Windows.Forms.Label lbl_avg;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.TextBox txt_stotal;
        private System.Windows.Forms.TextBox txt_scount;
        private System.Windows.Forms.TextBox txt_avg;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}

