﻿namespace POV_OneCherry
{
    partial class Form5
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 20);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 12;
            label2.Text = "Inicia sesión como:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(50, 90);
            button1.Name = "button1";
            button1.Size = new Size(115, 50);
            button1.TabIndex = 13;
            button1.Text = "Administrador";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(215, 90);
            button2.Name = "button2";
            button2.Size = new Size(115, 50);
            button2.TabIndex = 14;
            button2.Text = "Empleado";
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCoral;
            button5.Font = new Font("Goudy Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(139, 166);
            button5.Name = "button5";
            button5.Size = new Size(100, 25);
            button5.TabIndex = 17;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(384, 211);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            Text = "First log in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        protected internal Button button1;
        protected internal Button button2;
        protected internal Button button5;
    }
}