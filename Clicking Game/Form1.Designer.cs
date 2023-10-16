namespace Clicking_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_ten = new System.Windows.Forms.Button();
            this.btn_fifteen = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_click = new System.Windows.Forms.Button();
            this.lbl_time_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_five
            // 
            this.btn_five.BackColor = System.Drawing.Color.White;
            this.btn_five.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_five.FlatAppearance.BorderSize = 0;
            this.btn_five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_five.Font = new System.Drawing.Font("Keep Calm Med", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_five.Location = new System.Drawing.Point(68, 114);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(118, 43);
            this.btn_five.TabIndex = 0;
            this.btn_five.Text = "5s";
            this.btn_five.UseVisualStyleBackColor = false;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_ten
            // 
            this.btn_ten.BackColor = System.Drawing.Color.White;
            this.btn_ten.FlatAppearance.BorderSize = 0;
            this.btn_ten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ten.Font = new System.Drawing.Font("Keep Calm Med", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ten.Location = new System.Drawing.Point(260, 114);
            this.btn_ten.Name = "btn_ten";
            this.btn_ten.Size = new System.Drawing.Size(118, 43);
            this.btn_ten.TabIndex = 1;
            this.btn_ten.Text = "10s";
            this.btn_ten.UseVisualStyleBackColor = false;
            this.btn_ten.Click += new System.EventHandler(this.btn_ten_Click);
            // 
            // btn_fifteen
            // 
            this.btn_fifteen.BackColor = System.Drawing.Color.White;
            this.btn_fifteen.FlatAppearance.BorderSize = 0;
            this.btn_fifteen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fifteen.Font = new System.Drawing.Font("Keep Calm Med", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fifteen.Location = new System.Drawing.Point(454, 114);
            this.btn_fifteen.Name = "btn_fifteen";
            this.btn_fifteen.Size = new System.Drawing.Size(118, 43);
            this.btn_fifteen.TabIndex = 2;
            this.btn_fifteen.Text = "15s";
            this.btn_fifteen.UseVisualStyleBackColor = false;
            this.btn_fifteen.Click += new System.EventHandler(this.btn_fifteen_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.White;
            this.lbl_score.Location = new System.Drawing.Point(296, 226);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(39, 42);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "0";
            // 
            // btn_click
            // 
            this.btn_click.BackColor = System.Drawing.Color.White;
            this.btn_click.FlatAppearance.BorderSize = 0;
            this.btn_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_click.Font = new System.Drawing.Font("Keep Calm Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_click.ForeColor = System.Drawing.Color.Black;
            this.btn_click.Location = new System.Drawing.Point(146, 309);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(349, 74);
            this.btn_click.TabIndex = 4;
            this.btn_click.Text = "Click me as fast as you can!";
            this.btn_click.UseVisualStyleBackColor = false;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // lbl_time_count
            // 
            this.lbl_time_count.AutoSize = true;
            this.lbl_time_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time_count.Font = new System.Drawing.Font("Keep Calm Med", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_count.ForeColor = System.Drawing.Color.White;
            this.lbl_time_count.Location = new System.Drawing.Point(507, 173);
            this.lbl_time_count.Name = "lbl_time_count";
            this.lbl_time_count.Size = new System.Drawing.Size(47, 15);
            this.lbl_time_count.TabIndex = 5;
            this.lbl_time_count.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Keep Calm Med", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(82, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "CLICKING GAME";
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructions.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_instructions.Location = new System.Drawing.Point(190, 71);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(41, 13);
            this.lbl_instructions.TabIndex = 7;
            this.lbl_instructions.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(634, 406);
            this.Controls.Add(this.lbl_instructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_time_count);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_fifteen);
            this.Controls.Add(this.btn_ten);
            this.Controls.Add(this.btn_five);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicking Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_ten;
        private System.Windows.Forms.Button btn_fifteen;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Label lbl_time_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_instructions;
    }
}

