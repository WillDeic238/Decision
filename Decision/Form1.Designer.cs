namespace Decision
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
            this.option1Button = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.positionLabel = new System.Windows.Forms.Label();
            this.hamBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // option1Button
            // 
            this.option1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Button.Location = new System.Drawing.Point(98, 269);
            this.option1Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(175, 35);
            this.option1Button.TabIndex = 0;
            this.option1Button.Text = "Pass";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(78, 57);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(679, 89);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "You are Lewis Hamilton and it is race Sunday. Due to an unfourtunate crash in Q1 " +
    "you are P20 on the grid. \r\n\r\n";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(212, 121);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(436, 91);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "You See P19 ahead do you pass him or stay where you are?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option2Button
            // 
            this.option2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Button.Location = new System.Drawing.Point(520, 269);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(175, 35);
            this.option2Button.TabIndex = 3;
            this.option2Button.Text = "Stay put";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Button.Location = new System.Drawing.Point(318, 269);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(153, 35);
            this.option3Button.TabIndex = 4;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(13, 13);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(118, 23);
            this.positionLabel.TabIndex = 5;
            this.positionLabel.Text = "Position: 20/20";
            // 
            // hamBox
            // 
            this.hamBox.Cursor = System.Windows.Forms.Cursors.No;
            this.hamBox.Image = ((System.Drawing.Image)(resources.GetObject("hamBox.Image")));
            this.hamBox.Location = new System.Drawing.Point(12, 100);
            this.hamBox.Name = "hamBox";
            this.hamBox.Size = new System.Drawing.Size(206, 121);
            this.hamBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hamBox.TabIndex = 6;
            this.hamBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 343);
            this.Controls.Add(this.hamBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.option1Button);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "F1 Race";
            ((System.ComponentModel.ISupportInitialize)(this.hamBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.PictureBox hamBox;
    }
}

