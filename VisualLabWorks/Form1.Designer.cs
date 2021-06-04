
namespace VisualLabWorks
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
            this.crazyPanel = new System.Windows.Forms.Panel();
            this.impossibleLabel = new System.Windows.Forms.Label();
            this.fakeButton = new System.Windows.Forms.Button();
            this.advertisementLabel = new System.Windows.Forms.Label();
            this.ArgBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.crazyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // crazyPanel
            // 
            this.crazyPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.crazyPanel.Controls.Add(this.impossibleLabel);
            this.crazyPanel.Location = new System.Drawing.Point(116, 66);
            this.crazyPanel.Name = "crazyPanel";
            this.crazyPanel.Size = new System.Drawing.Size(512, 124);
            this.crazyPanel.TabIndex = 0;
            this.crazyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.crazyPanel_Paint);
            // 
            // impossibleLabel
            // 
            this.impossibleLabel.AutoSize = true;
            this.impossibleLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.impossibleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impossibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.impossibleLabel.Location = new System.Drawing.Point(106, 51);
            this.impossibleLabel.Name = "impossibleLabel";
            this.impossibleLabel.Size = new System.Drawing.Size(187, 16);
            this.impossibleLabel.TabIndex = 0;
            this.impossibleLabel.Text = "Здесь будет ваша реклама!";
            this.impossibleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fakeButton
            // 
            this.fakeButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.fakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fakeButton.Location = new System.Drawing.Point(334, 376);
            this.fakeButton.Name = "fakeButton";
            this.fakeButton.Size = new System.Drawing.Size(75, 23);
            this.fakeButton.TabIndex = 1;
            this.fakeButton.Text = "Поехали!";
            this.fakeButton.UseVisualStyleBackColor = true;
            this.fakeButton.Click += new System.EventHandler(this.fakeButton_Click);
            // 
            // advertisementLabel
            // 
            this.advertisementLabel.AutoSize = true;
            this.advertisementLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertisementLabel.Location = new System.Drawing.Point(201, 28);
            this.advertisementLabel.Name = "advertisementLabel";
            this.advertisementLabel.Size = new System.Drawing.Size(308, 22);
            this.advertisementLabel.TabIndex = 2;
            this.advertisementLabel.Text = "Здесь могла быть ваша реклама...";
            this.advertisementLabel.Click += new System.EventHandler(this.advertisementLabel_Click);
            // 
            // ArgBox
            // 
            this.ArgBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ArgBox.Location = new System.Drawing.Point(409, 285);
            this.ArgBox.Name = "ArgBox";
            this.ArgBox.Size = new System.Drawing.Size(100, 20);
            this.ArgBox.TabIndex = 3;
            this.ArgBox.Text = "            Туть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(127, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите значение аргумента x:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.submitButton.Location = new System.Drawing.Point(455, 376);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(137, 34);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Подтвердить";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            this.submitButton.MouseEnter += new System.EventHandler(this.submitButton_MouseEnter);
            this.submitButton.MouseLeave += new System.EventHandler(this.submitButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArgBox);
            this.Controls.Add(this.advertisementLabel);
            this.Controls.Add(this.fakeButton);
            this.Controls.Add(this.crazyPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.crazyPanel.ResumeLayout(false);
            this.crazyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel crazyPanel;
        private System.Windows.Forms.Label impossibleLabel;
        private System.Windows.Forms.Button fakeButton;
        private System.Windows.Forms.Label advertisementLabel;
        private System.Windows.Forms.TextBox ArgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
    }
}