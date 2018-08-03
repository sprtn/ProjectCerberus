namespace Spellcraft
{
    partial class SpellcraftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellcraftForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.actionLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.durationAndCastingTitleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.somaticCheckbox = new System.Windows.Forms.CheckBox();
            this.materialCheckbox = new System.Windows.Forms.CheckBox();
            this.cerbalCheckbox = new System.Windows.Forms.CheckBox();
            this.componentsTitleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.spellschoolDropdown = new System.Windows.Forms.ComboBox();
            this.descriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.spellnameTitleLabel = new System.Windows.Forms.Label();
            this.descriptionButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 473);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.actionLabel);
            this.panel4.Controls.Add(this.durationLabel);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.durationAndCastingTitleLabel);
            this.panel4.Location = new System.Drawing.Point(557, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 75);
            this.panel4.TabIndex = 2;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(62, 51);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(77, 13);
            this.actionLabel.TabIndex = 13;
            this.actionLabel.Text = "1 bonus action";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(62, 34);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 12;
            this.durationLabel.Text = "1 minute";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Casting:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Duration:";
            // 
            // durationAndCastingTitleLabel
            // 
            this.durationAndCastingTitleLabel.AutoSize = true;
            this.durationAndCastingTitleLabel.Location = new System.Drawing.Point(43, 9);
            this.durationAndCastingTitleLabel.Name = "durationAndCastingTitleLabel";
            this.durationAndCastingTitleLabel.Size = new System.Drawing.Size(106, 13);
            this.durationAndCastingTitleLabel.TabIndex = 9;
            this.durationAndCastingTitleLabel.Text = "Duration and Casting";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.somaticCheckbox);
            this.panel3.Controls.Add(this.materialCheckbox);
            this.panel3.Controls.Add(this.cerbalCheckbox);
            this.panel3.Controls.Add(this.componentsTitleLabel);
            this.panel3.Location = new System.Drawing.Point(325, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 75);
            this.panel3.TabIndex = 2;
            // 
            // somaticCheckbox
            // 
            this.somaticCheckbox.AutoSize = true;
            this.somaticCheckbox.Location = new System.Drawing.Point(80, 42);
            this.somaticCheckbox.Name = "somaticCheckbox";
            this.somaticCheckbox.Size = new System.Drawing.Size(64, 17);
            this.somaticCheckbox.TabIndex = 8;
            this.somaticCheckbox.Text = "Somatic";
            this.somaticCheckbox.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox
            // 
            this.materialCheckbox.AutoSize = true;
            this.materialCheckbox.Location = new System.Drawing.Point(148, 42);
            this.materialCheckbox.Name = "materialCheckbox";
            this.materialCheckbox.Size = new System.Drawing.Size(63, 17);
            this.materialCheckbox.TabIndex = 7;
            this.materialCheckbox.Text = "Material";
            this.materialCheckbox.UseVisualStyleBackColor = true;
            // 
            // cerbalCheckbox
            // 
            this.cerbalCheckbox.AutoSize = true;
            this.cerbalCheckbox.Location = new System.Drawing.Point(13, 42);
            this.cerbalCheckbox.Name = "cerbalCheckbox";
            this.cerbalCheckbox.Size = new System.Drawing.Size(56, 17);
            this.cerbalCheckbox.TabIndex = 6;
            this.cerbalCheckbox.Text = "Verbal";
            this.cerbalCheckbox.UseVisualStyleBackColor = true;
            // 
            // componentsTitleLabel
            // 
            this.componentsTitleLabel.AutoSize = true;
            this.componentsTitleLabel.Location = new System.Drawing.Point(81, 9);
            this.componentsTitleLabel.Name = "componentsTitleLabel";
            this.componentsTitleLabel.Size = new System.Drawing.Size(66, 13);
            this.componentsTitleLabel.TabIndex = 6;
            this.componentsTitleLabel.Text = "Components";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.spellschoolDropdown);
            this.panel2.Controls.Add(this.descriptionCheckBox);
            this.panel2.Controls.Add(this.spellnameTitleLabel);
            this.panel2.Controls.Add(this.descriptionButton);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 75);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Available to 0 Races";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // spellschoolDropdown
            // 
            this.spellschoolDropdown.FormattingEnabled = true;
            this.spellschoolDropdown.Location = new System.Drawing.Point(207, 40);
            this.spellschoolDropdown.Name = "spellschoolDropdown";
            this.spellschoolDropdown.Size = new System.Drawing.Size(96, 21);
            this.spellschoolDropdown.TabIndex = 6;
            this.spellschoolDropdown.Text = "School";
            // 
            // descriptionCheckBox
            // 
            this.descriptionCheckBox.AutoSize = true;
            this.descriptionCheckBox.Location = new System.Drawing.Point(16, 43);
            this.descriptionCheckBox.Name = "descriptionCheckBox";
            this.descriptionCheckBox.Size = new System.Drawing.Size(15, 14);
            this.descriptionCheckBox.TabIndex = 3;
            this.descriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // spellnameTitleLabel
            // 
            this.spellnameTitleLabel.AutoSize = true;
            this.spellnameTitleLabel.Location = new System.Drawing.Point(112, 9);
            this.spellnameTitleLabel.Name = "spellnameTitleLabel";
            this.spellnameTitleLabel.Size = new System.Drawing.Size(77, 13);
            this.spellnameTitleLabel.TabIndex = 0;
            this.spellnameTitleLabel.Text = "Unnamed spell";
            // 
            // descriptionButton
            // 
            this.descriptionButton.Location = new System.Drawing.Point(11, 38);
            this.descriptionButton.Name = "descriptionButton";
            this.descriptionButton.Size = new System.Drawing.Size(85, 23);
            this.descriptionButton.TabIndex = 7;
            this.descriptionButton.Text = "--- Description";
            this.descriptionButton.UseVisualStyleBackColor = true;
            // 
            // SpellcraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpellcraftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spellcraft";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox somaticCheckbox;
        private System.Windows.Forms.CheckBox materialCheckbox;
        private System.Windows.Forms.CheckBox cerbalCheckbox;
        private System.Windows.Forms.Label componentsTitleLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox descriptionCheckBox;
        private System.Windows.Forms.Label spellnameTitleLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label durationAndCastingTitleLabel;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.ComboBox spellschoolDropdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button descriptionButton;
    }
}

