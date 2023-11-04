namespace VBProphail
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
            this.btn_Switch = new System.Windows.Forms.Button();
            this.text_First = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Last = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtCont2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Switch
            // 
            this.btn_Switch.Font = new System.Drawing.Font("Comic Sans MS", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Switch.Location = new System.Drawing.Point(403, 435);
            this.btn_Switch.Name = "btn_Switch";
            this.btn_Switch.Size = new System.Drawing.Size(268, 107);
            this.btn_Switch.TabIndex = 0;
            this.btn_Switch.Text = "Switch";
            this.btn_Switch.UseVisualStyleBackColor = true;
            this.btn_Switch.Click += new System.EventHandler(this.btn_Switch_Click);
            // 
            // text_First
            // 
            this.text_First.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_First.Location = new System.Drawing.Point(523, 126);
            this.text_First.Name = "text_First";
            this.text_First.Size = new System.Drawing.Size(341, 74);
            this.text_First.TabIndex = 1;
            this.text_First.TextChanged += new System.EventHandler(this.text_First_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 67);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // text_Last
            // 
            this.text_Last.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Last.Location = new System.Drawing.Point(523, 225);
            this.text_Last.Name = "text_Last";
            this.text_Last.Size = new System.Drawing.Size(341, 74);
            this.text_Last.TabIndex = 4;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(847, 398);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(100, 31);
            this.txtCont.TabIndex = 5;
            // 
            // txtCont2
            // 
            this.txtCont2.Location = new System.Drawing.Point(847, 453);
            this.txtCont2.Name = "txtCont2";
            this.txtCont2.Size = new System.Drawing.Size(100, 31);
            this.txtCont2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 623);
            this.Controls.Add(this.txtCont2);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.text_Last);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_First);
            this.Controls.Add(this.btn_Switch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Switch;
        private System.Windows.Forms.TextBox text_First;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Last;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.TextBox txtCont2;
    }
}

