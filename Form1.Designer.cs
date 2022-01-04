
namespace WF_Autok_Adatbazis
{
    partial class Form_Autok_Nyito
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Kod = new System.Windows.Forms.TextBox();
            this.textBox_Rendszam = new System.Windows.Forms.TextBox();
            this.textBox_Gyartmany = new System.Windows.Forms.TextBox();
            this.textBox_Tipus = new System.Windows.Forms.TextBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.groupBox_Autok = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.listBox_Autok = new System.Windows.Forms.ListBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_Autok.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rendszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gyártmány:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Típus:";
            // 
            // textBox_Kod
            // 
            this.textBox_Kod.Location = new System.Drawing.Point(108, 26);
            this.textBox_Kod.Name = "textBox_Kod";
            this.textBox_Kod.Size = new System.Drawing.Size(123, 20);
            this.textBox_Kod.TabIndex = 0;
            // 
            // textBox_Rendszam
            // 
            this.textBox_Rendszam.Location = new System.Drawing.Point(108, 58);
            this.textBox_Rendszam.Name = "textBox_Rendszam";
            this.textBox_Rendszam.Size = new System.Drawing.Size(123, 20);
            this.textBox_Rendszam.TabIndex = 1;
            // 
            // textBox_Gyartmany
            // 
            this.textBox_Gyartmany.Location = new System.Drawing.Point(108, 90);
            this.textBox_Gyartmany.Name = "textBox_Gyartmany";
            this.textBox_Gyartmany.Size = new System.Drawing.Size(123, 20);
            this.textBox_Gyartmany.TabIndex = 2;
            // 
            // textBox_Tipus
            // 
            this.textBox_Tipus.Location = new System.Drawing.Point(108, 122);
            this.textBox_Tipus.Name = "textBox_Tipus";
            this.textBox_Tipus.Size = new System.Drawing.Size(123, 20);
            this.textBox_Tipus.TabIndex = 3;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(16, 157);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(142, 23);
            this.button_Insert.TabIndex = 5;
            this.button_Insert.Text = "Rögzít";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            this.button_Insert.MouseHover += new System.EventHandler(this.button_Insert_MouseHover);
            // 
            // button_Delete
            // 
            this.button_Delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Delete.Location = new System.Drawing.Point(16, 199);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(142, 23);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Töröl";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(16, 241);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(142, 23);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // groupBox_Autok
            // 
            this.groupBox_Autok.Controls.Add(this.button_Save);
            this.groupBox_Autok.Controls.Add(this.button_Close);
            this.groupBox_Autok.Controls.Add(this.button_Update);
            this.groupBox_Autok.Controls.Add(this.label1);
            this.groupBox_Autok.Controls.Add(this.button_Delete);
            this.groupBox_Autok.Controls.Add(this.label2);
            this.groupBox_Autok.Controls.Add(this.button_Insert);
            this.groupBox_Autok.Controls.Add(this.label3);
            this.groupBox_Autok.Controls.Add(this.textBox_Tipus);
            this.groupBox_Autok.Controls.Add(this.label4);
            this.groupBox_Autok.Controls.Add(this.textBox_Gyartmany);
            this.groupBox_Autok.Controls.Add(this.textBox_Kod);
            this.groupBox_Autok.Controls.Add(this.textBox_Rendszam);
            this.groupBox_Autok.Location = new System.Drawing.Point(13, 15);
            this.groupBox_Autok.Name = "groupBox_Autok";
            this.groupBox_Autok.Size = new System.Drawing.Size(247, 325);
            this.groupBox_Autok.TabIndex = 3;
            this.groupBox_Autok.TabStop = false;
            this.groupBox_Autok.Text = "Autók adatai";
            // 
            // button_Close
            // 
            this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Close.Location = new System.Drawing.Point(170, 157);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(61, 107);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "Mentés és bezárás";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // listBox_Autok
            // 
            this.listBox_Autok.FormattingEnabled = true;
            this.listBox_Autok.Location = new System.Drawing.Point(266, 22);
            this.listBox_Autok.Name = "listBox_Autok";
            this.listBox_Autok.Size = new System.Drawing.Size(193, 316);
            this.listBox_Autok.TabIndex = 4;
            // 
            // button_Save
            // 
            this.button_Save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Save.Location = new System.Drawing.Point(16, 283);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(215, 23);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Mentés";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.MouseHover += new System.EventHandler(this.button_Save_MouseHover);
            // 
            // Form_Autok_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Close;
            this.ClientSize = new System.Drawing.Size(471, 352);
            this.Controls.Add(this.listBox_Autok);
            this.Controls.Add(this.groupBox_Autok);
            this.Name = "Form_Autok_Nyito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autók";
            this.Load += new System.EventHandler(this.Form_Autok_Nyito_Load);
            this.groupBox_Autok.ResumeLayout(false);
            this.groupBox_Autok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Kod;
        private System.Windows.Forms.TextBox textBox_Rendszam;
        private System.Windows.Forms.TextBox textBox_Gyartmany;
        private System.Windows.Forms.TextBox textBox_Tipus;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.GroupBox groupBox_Autok;
        private System.Windows.Forms.ListBox listBox_Autok;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Save;
    }
}

