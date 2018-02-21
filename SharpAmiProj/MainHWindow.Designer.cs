namespace HelloCShaprWorld
{
    partial class MainHWindow
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
            this.button_hello = new System.Windows.Forms.Button();
            this.button_goodby = new System.Windows.Forms.Button();
            this.button_talk = new System.Windows.Forms.Button();
            this.textBox_dialog = new System.Windows.Forms.TextBox();
            this.label_dialog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_hello
            // 
            this.button_hello.Location = new System.Drawing.Point(73, 203);
            this.button_hello.Name = "button_hello";
            this.button_hello.Size = new System.Drawing.Size(75, 23);
            this.button_hello.TabIndex = 0;
            this.button_hello.Text = "Hello";
            this.button_hello.UseVisualStyleBackColor = true;
            this.button_hello.Click += new System.EventHandler(this.button_hello_Click);
            // 
            // button_goodby
            // 
            this.button_goodby.Location = new System.Drawing.Point(289, 203);
            this.button_goodby.Name = "button_goodby";
            this.button_goodby.Size = new System.Drawing.Size(75, 23);
            this.button_goodby.TabIndex = 1;
            this.button_goodby.Text = "Goodby";
            this.button_goodby.UseVisualStyleBackColor = true;
            this.button_goodby.Click += new System.EventHandler(this.button_goodby_Click);
            // 
            // button_talk
            // 
            this.button_talk.Location = new System.Drawing.Point(181, 203);
            this.button_talk.Name = "button_talk";
            this.button_talk.Size = new System.Drawing.Size(75, 23);
            this.button_talk.TabIndex = 2;
            this.button_talk.Text = "Let\'s talk";
            this.button_talk.UseVisualStyleBackColor = true;
            this.button_talk.Click += new System.EventHandler(this.button_talk_Click);
            // 
            // textBox_dialog
            // 
            this.textBox_dialog.Location = new System.Drawing.Point(73, 44);
            this.textBox_dialog.Multiline = true;
            this.textBox_dialog.Name = "textBox_dialog";
            this.textBox_dialog.Size = new System.Drawing.Size(291, 136);
            this.textBox_dialog.TabIndex = 3;
            this.textBox_dialog.Visible = false;
            this.textBox_dialog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_dialog_KeyPress);
            // 
            // label_dialog
            // 
            this.label_dialog.AutoSize = true;
            this.label_dialog.Location = new System.Drawing.Point(73, 25);
            this.label_dialog.Name = "label_dialog";
            this.label_dialog.Size = new System.Drawing.Size(221, 13);
            this.label_dialog.TabIndex = 4;
            this.label_dialog.Text = "Пишите ниже всё, что хотите мне сказать";
            this.label_dialog.Visible = false;
            // 
            // MainHWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 259);
            this.Controls.Add(this.label_dialog);
            this.Controls.Add(this.textBox_dialog);
            this.Controls.Add(this.button_talk);
            this.Controls.Add(this.button_goodby);
            this.Controls.Add(this.button_hello);
            this.Name = "MainHWindow";
            this.Text = "Hello you, С# World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hello;
        private System.Windows.Forms.Button button_goodby;
        private System.Windows.Forms.Button button_talk;
        private System.Windows.Forms.TextBox textBox_dialog;
        private System.Windows.Forms.Label label_dialog;
    }
}

