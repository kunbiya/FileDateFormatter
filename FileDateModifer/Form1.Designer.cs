using System.ComponentModel;

namespace FileDateFormat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.Label();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.ChangeCollectiveTime = new System.Windows.Forms.DateTimePicker();
            this.ModifyDateBtn = new System.Windows.Forms.Button();
            this.ChangeCollectiveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreationTime = new System.Windows.Forms.DateTimePicker();
            this.LastWriteTime = new System.Windows.Forms.DateTimePicker();
            this.LastAccessTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.beforeCreationTime = new System.Windows.Forms.Label();
            this.beforeLastWriteTime = new System.Windows.Forms.Label();
            this.beforeLastAccessTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "파일정보";
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePath.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilePath.Location = new System.Drawing.Point(87, 79);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(403, 45);
            this.FilePath.TabIndex = 2;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OpenFileBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFileBtn.Location = new System.Drawing.Point(26, 43);
            this.OpenFileBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(100, 22);
            this.OpenFileBtn.TabIndex = 3;
            this.OpenFileBtn.Text = "파일 선택";
            this.OpenFileBtn.UseVisualStyleBackColor = false;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // ChangeCollectiveTime
            // 
            this.ChangeCollectiveTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.ChangeCollectiveTime.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeCollectiveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ChangeCollectiveTime.Location = new System.Drawing.Point(29, 346);
            this.ChangeCollectiveTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeCollectiveTime.Name = "ChangeCollectiveTime";
            this.ChangeCollectiveTime.Size = new System.Drawing.Size(238, 22);
            this.ChangeCollectiveTime.TabIndex = 11;
            // 
            // ModifyDateBtn
            // 
            this.ModifyDateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModifyDateBtn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifyDateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModifyDateBtn.Location = new System.Drawing.Point(372, 379);
            this.ModifyDateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModifyDateBtn.Name = "ModifyDateBtn";
            this.ModifyDateBtn.Size = new System.Drawing.Size(118, 31);
            this.ModifyDateBtn.TabIndex = 12;
            this.ModifyDateBtn.Text = "파일 수정하기";
            this.ModifyDateBtn.UseVisualStyleBackColor = false;
            this.ModifyDateBtn.Click += new System.EventHandler(this.ModifyDateBtn_Click);
            // 
            // ChangeCollectiveBtn
            // 
            this.ChangeCollectiveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangeCollectiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChangeCollectiveBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeCollectiveBtn.Location = new System.Drawing.Point(344, 346);
            this.ChangeCollectiveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeCollectiveBtn.Name = "ChangeCollectiveBtn";
            this.ChangeCollectiveBtn.Size = new System.Drawing.Size(146, 22);
            this.ChangeCollectiveBtn.TabIndex = 13;
            this.ChangeCollectiveBtn.Text = "날짜 일괄변경";
            this.ChangeCollectiveBtn.UseVisualStyleBackColor = false;
            this.ChangeCollectiveBtn.Click += new System.EventHandler(this.ChangeCollectiveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "파일 생성일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "파일 수정일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "파일 접근일자";
            // 
            // CreationTime
            // 
            this.CreationTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.CreationTime.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreationTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreationTime.Location = new System.Drawing.Point(340, 197);
            this.CreationTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreationTime.Name = "CreationTime";
            this.CreationTime.Size = new System.Drawing.Size(150, 22);
            this.CreationTime.TabIndex = 7;
            // 
            // LastWriteTime
            // 
            this.LastWriteTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.LastWriteTime.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastWriteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastWriteTime.Location = new System.Drawing.Point(340, 227);
            this.LastWriteTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastWriteTime.Name = "LastWriteTime";
            this.LastWriteTime.Size = new System.Drawing.Size(150, 22);
            this.LastWriteTime.TabIndex = 8;
            // 
            // LastAccessTime
            // 
            this.LastAccessTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.LastAccessTime.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastAccessTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastAccessTime.Location = new System.Drawing.Point(340, 257);
            this.LastAccessTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastAccessTime.Name = "LastAccessTime";
            this.LastAccessTime.Size = new System.Drawing.Size(150, 22);
            this.LastAccessTime.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(145, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 2);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(154, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "수정 전";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(337, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "수정 후";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Step 1. 파일 선택하기";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Step 2-1. 파일 접근날짜 선택";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(187, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 2);
            this.label11.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(13, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Step 2-2. 파일 접근날짜 일괄선택";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(209, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(281, 2);
            this.label13.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(26, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(413, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "날짜를 선택하고 \'날짜 일괄변경\' 버튼을 클릭 시 모든 일자를 선택 한 날짜로 변경";
            // 
            // beforeCreationTime
            // 
            this.beforeCreationTime.AutoSize = true;
            this.beforeCreationTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beforeCreationTime.Location = new System.Drawing.Point(154, 198);
            this.beforeCreationTime.Name = "beforeCreationTime";
            this.beforeCreationTime.Size = new System.Drawing.Size(0, 15);
            this.beforeCreationTime.TabIndex = 24;
            // 
            // beforeLastWriteTime
            // 
            this.beforeLastWriteTime.AutoSize = true;
            this.beforeLastWriteTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beforeLastWriteTime.Location = new System.Drawing.Point(154, 228);
            this.beforeLastWriteTime.Name = "beforeLastWriteTime";
            this.beforeLastWriteTime.Size = new System.Drawing.Size(0, 15);
            this.beforeLastWriteTime.TabIndex = 25;
            // 
            // beforeLastAccessTime
            // 
            this.beforeLastAccessTime.AutoSize = true;
            this.beforeLastAccessTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beforeLastAccessTime.Location = new System.Drawing.Point(154, 258);
            this.beforeLastAccessTime.Name = "beforeLastAccessTime";
            this.beforeLastAccessTime.Size = new System.Drawing.Size(0, 15);
            this.beforeLastAccessTime.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(503, 423);
            this.Controls.Add(this.beforeLastAccessTime);
            this.Controls.Add(this.beforeLastWriteTime);
            this.Controls.Add(this.beforeCreationTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeCollectiveBtn);
            this.Controls.Add(this.CreationTime);
            this.Controls.Add(this.ModifyDateBtn);
            this.Controls.Add(this.LastAccessTime);
            this.Controls.Add(this.ChangeCollectiveTime);
            this.Controls.Add(this.LastWriteTime);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "파일 접근날짜 관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button ChangeCollectiveBtn;

        private System.Windows.Forms.Button ModifyDateBtn;

        private System.Windows.Forms.DateTimePicker ChangeCollectiveTime;

        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Label FilePath;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CreationTime;
        private System.Windows.Forms.DateTimePicker LastWriteTime;
        private System.Windows.Forms.DateTimePicker LastAccessTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label beforeCreationTime;
        private System.Windows.Forms.Label beforeLastWriteTime;
        private System.Windows.Forms.Label beforeLastAccessTime;
    }
}