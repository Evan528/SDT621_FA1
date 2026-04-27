namespace SDT621_FA1_Q3
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
            label1 = new Label();
            lbOutput = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            txtInput = new TextBox();
            Label_removed = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 19);
            label1.Name = "label1";
            label1.Size = new Size(359, 25);
            label1.TabIndex = 0;
            label1.Text = "My Favourite Programming Languages";
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.Location = new Point(126, 64);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(391, 184);
            lbOutput.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(126, 283);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.IndianRed;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(239, 283);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(115, 35);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(126, 254);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(391, 23);
            txtInput.TabIndex = 4;
            // 
            // Label_removed
            // 
            Label_removed.AutoSize = true;
            Label_removed.ForeColor = SystemColors.ControlDark;
            Label_removed.Location = new Point(126, 341);
            Label_removed.Name = "Label_removed";
            Label_removed.Size = new Size(0, 15);
            Label_removed.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 365);
            Controls.Add(Label_removed);
            Controls.Add(txtInput);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lbOutput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbOutput;
        private Button btnAdd;
        private Button btnRemove;
        private TextBox txtInput;
        private Label Label_removed;
    }
}
