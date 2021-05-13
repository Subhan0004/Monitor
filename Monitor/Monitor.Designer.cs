
namespace Monitor
{
    partial class textline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textline));
            this.button_click = new System.Windows.Forms.Button();
            this.button_enable = new System.Windows.Forms.Button();
            this.button_disable = new System.Windows.Forms.Button();
            this.tb_line = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.text_output = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_click
            // 
            this.button_click.BackColor = System.Drawing.Color.SpringGreen;
            this.button_click.FlatAppearance.BorderSize = 0;
            this.button_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_click.Location = new System.Drawing.Point(559, 61);
            this.button_click.Margin = new System.Windows.Forms.Padding(4);
            this.button_click.Name = "button_click";
            this.button_click.Size = new System.Drawing.Size(160, 44);
            this.button_click.TabIndex = 1;
            this.button_click.Text = "Click";
            this.button_click.UseVisualStyleBackColor = false;
            this.button_click.Click += new System.EventHandler(this.button_click_Click);
            // 
            // button_enable
            // 
            this.button_enable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_enable.FlatAppearance.BorderSize = 0;
            this.button_enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enable.Location = new System.Drawing.Point(559, 169);
            this.button_enable.Margin = new System.Windows.Forms.Padding(4);
            this.button_enable.Name = "button_enable";
            this.button_enable.Size = new System.Drawing.Size(160, 44);
            this.button_enable.TabIndex = 2;
            this.button_enable.Text = "Enable";
            this.button_enable.UseVisualStyleBackColor = false;
            this.button_enable.Click += new System.EventHandler(this.button_enable_Click);
            // 
            // button_disable
            // 
            this.button_disable.BackColor = System.Drawing.Color.Tomato;
            this.button_disable.FlatAppearance.BorderSize = 0;
            this.button_disable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_disable.Location = new System.Drawing.Point(559, 221);
            this.button_disable.Margin = new System.Windows.Forms.Padding(4);
            this.button_disable.Name = "button_disable";
            this.button_disable.Size = new System.Drawing.Size(160, 44);
            this.button_disable.TabIndex = 3;
            this.button_disable.Text = "Disable";
            this.button_disable.UseVisualStyleBackColor = false;
            this.button_disable.Click += new System.EventHandler(this.button_disable_Click);
            // 
            // tb_line
            // 
            this.tb_line.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_line.Location = new System.Drawing.Point(187, 61);
            this.tb_line.Margin = new System.Windows.Forms.Padding(4);
            this.tb_line.Multiline = true;
            this.tb_line.Name = "tb_line";
            this.tb_line.Size = new System.Drawing.Size(362, 67);
            this.tb_line.TabIndex = 4;
            this.tb_line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Full Name:";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output.Location = new System.Drawing.Point(304, 329);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(90, 27);
            this.label_output.TabIndex = 7;
            this.label_output.Text = "Monitor";
            // 
            // text_output
            // 
            this.text_output.BackColor = System.Drawing.SystemColors.MenuText;
            this.text_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text_output.Location = new System.Drawing.Point(17, 360);
            this.text_output.Margin = new System.Windows.Forms.Padding(4);
            this.text_output.Multiline = true;
            this.text_output.Name = "text_output";
            this.text_output.ReadOnly = true;
            this.text_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_output.Size = new System.Drawing.Size(702, 274);
            this.text_output.TabIndex = 6;
            this.text_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Info;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(559, 113);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(160, 44);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 647);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.text_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_line);
            this.Controls.Add(this.button_disable);
            this.Controls.Add(this.button_enable);
            this.Controls.Add(this.button_click);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "textline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_click;
        private System.Windows.Forms.Button button_enable;
        private System.Windows.Forms.Button button_disable;
        private System.Windows.Forms.TextBox tb_line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.TextBox text_output;
        private System.Windows.Forms.Button btn_clear;
    }
}

