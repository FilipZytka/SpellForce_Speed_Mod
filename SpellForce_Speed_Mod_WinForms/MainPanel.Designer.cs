namespace SpellForce_Speed_Mod_WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pause_button = new Button();
            button_speed_x1 = new Button();
            button_speed_x2 = new Button();
            button_speed_x5 = new Button();
            button_speed_x10 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // pause_button
            // 
            pause_button.Font = new Font("Arial Rounded MT Bold", 16F);
            pause_button.Location = new Point(33, 68);
            pause_button.Name = "pause_button";
            pause_button.Size = new Size(115, 41);
            pause_button.TabIndex = 0;
            pause_button.Text = "Pauza";
            pause_button.UseVisualStyleBackColor = true;
            pause_button.Click += pause_button_Click;
            // 
            // button_speed_x1
            // 
            button_speed_x1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 16);
            button_speed_x1.Location = new Point(33, 127);
            button_speed_x1.Name = "button_speed_x1";
            button_speed_x1.Size = new Size(115, 41);
            button_speed_x1.TabIndex = 1;
            button_speed_x1.Text = "x1";
            button_speed_x1.UseVisualStyleBackColor = true;
            button_speed_x1.Click += button_speed_x1_Click;
            // 
            // button_speed_x2
            // 
            button_speed_x2.Font = new Font("Arial Rounded MT Bold", 16F);
            button_speed_x2.Location = new Point(33, 188);
            button_speed_x2.Name = "button_speed_x2";
            button_speed_x2.Size = new Size(115, 41);
            button_speed_x2.TabIndex = 2;
            button_speed_x2.Text = "x2";
            button_speed_x2.UseVisualStyleBackColor = true;
            button_speed_x2.Click += button_speed_x2_Click;
            // 
            // button_speed_x5
            // 
            button_speed_x5.Font = new Font("Arial Rounded MT Bold", 16F);
            button_speed_x5.Location = new Point(33, 246);
            button_speed_x5.Name = "button_speed_x5";
            button_speed_x5.Size = new Size(115, 41);
            button_speed_x5.TabIndex = 3;
            button_speed_x5.Text = "x5";
            button_speed_x5.UseVisualStyleBackColor = true;
            button_speed_x5.Click += button_speed_x5_Click;
            // 
            // button_speed_x10
            // 
            button_speed_x10.Font = new Font("Arial Rounded MT Bold", 16F);
            button_speed_x10.Location = new Point(33, 303);
            button_speed_x10.Name = "button_speed_x10";
            button_speed_x10.Size = new Size(115, 36);
            button_speed_x10.TabIndex = 4;
            button_speed_x10.Text = "x10";
            button_speed_x10.UseVisualStyleBackColor = true;
            button_speed_x10.Click += button_speed_x10_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 30F);
            label1.Location = new Point(175, 68);
            label1.Name = "label1";
            label1.Size = new Size(50, 46);
            label1.TabIndex = 5;
            label1.Text = "H";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 30F);
            label2.Location = new Point(175, 117);
            label2.Name = "label2";
            label2.Size = new Size(33, 46);
            label2.TabIndex = 6;
            label2.Text = ",";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 30F);
            label3.Location = new Point(175, 178);
            label3.Name = "label3";
            label3.Size = new Size(33, 46);
            label3.TabIndex = 7;
            label3.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 30F);
            label4.Location = new Point(177, 246);
            label4.Name = "label4";
            label4.Size = new Size(31, 46);
            label4.TabIndex = 8;
            label4.Text = "/";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 30F);
            label5.Location = new Point(175, 303);
            label5.Name = "label5";
            label5.Size = new Size(33, 46);
            label5.TabIndex = 9;
            label5.Text = ";";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 400);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_speed_x10);
            Controls.Add(button_speed_x5);
            Controls.Add(button_speed_x2);
            Controls.Add(button_speed_x1);
            Controls.Add(pause_button);
            Font = new Font("Arial Rounded MT Bold", 9F);
            Name = "MainForm";
            ShowIcon = false;
            Text = "SpellForce Speed Mod";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pause_button;
        private Button button_speed_x1;
        private Button button_speed_x2;
        private Button button_speed_x5;
        private Button button_speed_x10;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
