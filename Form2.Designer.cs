﻿namespace _Quest
{
    partial class Game
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
            this.qStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qMainField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qHealth = new System.Windows.Forms.Label();
            this.qDamage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.qAction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qStatus
            // 
            this.qStatus.AutoSize = true;
            this.qStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.qStatus.Location = new System.Drawing.Point(210, 19);
            this.qStatus.Name = "qStatus";
            this.qStatus.Size = new System.Drawing.Size(135, 25);
            this.qStatus.TabIndex = 0;
            this.qStatus.Text = "Пока ничего";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя персонажа:";
            // 
            // qMainField
            // 
            this.qMainField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qMainField.Location = new System.Drawing.Point(53, 86);
            this.qMainField.Name = "qMainField";
            this.qMainField.Size = new System.Drawing.Size(538, 131);
            this.qMainField.TabIndex = 2;
            this.qMainField.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Здоровье персонажа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Урон персонажа";
            // 
            // qHealth
            // 
            this.qHealth.AutoSize = true;
            this.qHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qHealth.Location = new System.Drawing.Point(793, 9);
            this.qHealth.Name = "qHealth";
            this.qHealth.Size = new System.Drawing.Size(48, 25);
            this.qHealth.TabIndex = 5;
            this.qHealth.Text = "100";
            this.qHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qDamage
            // 
            this.qDamage.AutoSize = true;
            this.qDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qDamage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.qDamage.Location = new System.Drawing.Point(807, 35);
            this.qDamage.Name = "qDamage";
            this.qDamage.Size = new System.Drawing.Size(24, 25);
            this.qDamage.TabIndex = 6;
            this.qDamage.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(657, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Шагать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qAction
            // 
            this.qAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qAction.Location = new System.Drawing.Point(53, 226);
            this.qAction.Name = "qAction";
            this.qAction.Size = new System.Drawing.Size(538, 31);
            this.qAction.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(270, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ход игры";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qAction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qDamage);
            this.Controls.Add(this.qHealth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qMainField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qStatus);
            this.Name = "Game";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox qMainField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label qHealth;
        private System.Windows.Forms.Label qDamage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox qAction;
        private System.Windows.Forms.Label label4;
    }
}