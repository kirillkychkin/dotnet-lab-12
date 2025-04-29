using System.Drawing;
using System.Windows.Forms;

namespace dotnet_lab_12
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            btnApply = new Button();
            txtBrightness = new TextBox();
            txtContrast = new TextBox();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtThreshold = new TextBox();
            btnSave = new Button();
            btnLoad = new Button();
            pictureBox = new PictureBox();
            chkSharpen = new CheckBox();
            chkSmooth = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(chkSmooth);
            splitContainer1.Panel1.Controls.Add(chkSharpen);
            splitContainer1.Panel1.Controls.Add(btnApply);
            splitContainer1.Panel1.Controls.Add(txtBrightness);
            splitContainer1.Panel1.Controls.Add(txtContrast);
            splitContainer1.Panel1.Controls.Add(txtWidth);
            splitContainer1.Panel1.Controls.Add(txtHeight);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtThreshold);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(btnLoad);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 284;
            splitContainer1.TabIndex = 0;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(12, 343);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(89, 23);
            btnApply.TabIndex = 12;
            btnApply.Text = "Применить";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // txtBrightness
            // 
            txtBrightness.Location = new Point(160, 98);
            txtBrightness.Name = "txtBrightness";
            txtBrightness.Size = new Size(118, 23);
            txtBrightness.TabIndex = 11;
            // 
            // txtContrast
            // 
            txtContrast.Location = new Point(157, 136);
            txtContrast.Name = "txtContrast";
            txtContrast.Size = new Size(121, 23);
            txtContrast.TabIndex = 10;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(160, 176);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(118, 23);
            txtWidth.TabIndex = 9;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(160, 218);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(118, 23);
            txtHeight.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 267);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 7;
            label5.Text = "Пороговая бинаризация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Высота";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Ширина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Контраст";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Яркость";
            // 
            // txtThreshold
            // 
            txtThreshold.Location = new Point(160, 264);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(118, 23);
            txtThreshold.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(122, 23);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Загрузить фото";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(512, 450);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // chkSharpen
            // 
            chkSharpen.AutoSize = true;
            chkSharpen.Location = new Point(17, 294);
            chkSharpen.Name = "chkSharpen";
            chkSharpen.Size = new Size(74, 19);
            chkSharpen.TabIndex = 13;
            chkSharpen.Text = "Резкость";
            chkSharpen.UseVisualStyleBackColor = true;
            // 
            // chkSmooth
            // 
            chkSmooth.AutoSize = true;
            chkSmooth.Location = new Point(17, 319);
            chkSmooth.Name = "chkSmooth";
            chkSmooth.Size = new Size(76, 19);
            chkSmooth.TabIndex = 14;
            chkSmooth.Text = "Сгладить";
            chkSmooth.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private TextBox txtThreshold;
        private Button btnSave;
        private Button btnLoad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnApply;
        private TextBox txtBrightness;
        private TextBox txtContrast;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private PictureBox pictureBox;
        private CheckBox chkSmooth;
        private CheckBox chkSharpen;
    }
}
