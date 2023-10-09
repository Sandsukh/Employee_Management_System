
namespace EMS
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentpwd = new System.Windows.Forms.TextBox();
            this.txtNewpwd = new System.Windows.Forms.TextBox();
            this.txtConfirmpwd = new System.Windows.Forms.TextBox();
            this.btnChangepwd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // txtEmpid
            // 
            this.txtEmpid.Location = new System.Drawing.Point(234, 44);
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.Size = new System.Drawing.Size(106, 20);
            this.txtEmpid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password";
            // 
            // txtCurrentpwd
            // 
            this.txtCurrentpwd.Location = new System.Drawing.Point(197, 28);
            this.txtCurrentpwd.Name = "txtCurrentpwd";
            this.txtCurrentpwd.Size = new System.Drawing.Size(106, 20);
            this.txtCurrentpwd.TabIndex = 5;
            // 
            // txtNewpwd
            // 
            this.txtNewpwd.Location = new System.Drawing.Point(197, 72);
            this.txtNewpwd.Name = "txtNewpwd";
            this.txtNewpwd.Size = new System.Drawing.Size(106, 20);
            this.txtNewpwd.TabIndex = 6;
            // 
            // txtConfirmpwd
            // 
            this.txtConfirmpwd.Location = new System.Drawing.Point(197, 119);
            this.txtConfirmpwd.Name = "txtConfirmpwd";
            this.txtConfirmpwd.Size = new System.Drawing.Size(106, 20);
            this.txtConfirmpwd.TabIndex = 7;
            // 
            // btnChangepwd
            // 
            this.btnChangepwd.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangepwd.Location = new System.Drawing.Point(117, 274);
            this.btnChangepwd.Name = "btnChangepwd";
            this.btnChangepwd.Size = new System.Drawing.Size(152, 33);
            this.btnChangepwd.TabIndex = 8;
            this.btnChangepwd.Text = "Change Password";
            this.btnChangepwd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.txtCurrentpwd);
            this.panel1.Controls.Add(this.txtNewpwd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtConfirmpwd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(37, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 161);
            this.panel1.TabIndex = 9;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangepwd);
            this.Controls.Add(this.txtEmpid);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Change Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentpwd;
        private System.Windows.Forms.TextBox txtNewpwd;
        private System.Windows.Forms.TextBox txtConfirmpwd;
        private System.Windows.Forms.Button btnChangepwd;
        private System.Windows.Forms.Panel panel1;
    }
}