namespace SDT621_FA1_SectionB_Q2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelValid = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            cbCitizen = new ComboBox();
            btnValidate = new Button();
            lbOutput = new ListBox();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(387, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 0;
            label1.Text = "Home Affairs Digital Identity Processor";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(355, 77);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(377, 120);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 2;
            label3.Text = "Enter Your ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 165);
            label4.Name = "label4";
            label4.Size = new Size(135, 17);
            label4.TabIndex = 3;
            label4.Text = "Choose Your Citizen:";
            // 
            // labelValid
            // 
            labelValid.AutoSize = true;
            labelValid.Location = new Point(480, 267);
            labelValid.Name = "labelValid";
            labelValid.Size = new Size(0, 15);
            labelValid.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(480, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 23);
            txtName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(480, 119);
            txtID.Name = "txtID";
            txtID.Size = new Size(185, 23);
            txtID.TabIndex = 6;
            // 
            // cbCitizen
            // 
            cbCitizen.FormattingEnabled = true;
            cbCitizen.Items.AddRange(new object[] { "South African", "Permanent Resident", "Visitor" });
            cbCitizen.Location = new Point(480, 164);
            cbCitizen.Name = "cbCitizen";
            cbCitizen.Size = new Size(185, 23);
            cbCitizen.TabIndex = 7;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.FromArgb(0, 192, 0);
            btnValidate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidate.ForeColor = Color.Black;
            btnValidate.Location = new Point(525, 210);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(91, 27);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.Location = new Point(462, 319);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(223, 139);
            lbOutput.TabIndex = 9;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(0, 192, 0);
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(514, 473);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(113, 29);
            btnGenerate.TabIndex = 10;
            btnGenerate.Text = "Generate Profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(825, 514);
            Controls.Add(btnGenerate);
            Controls.Add(lbOutput);
            Controls.Add(btnValidate);
            Controls.Add(cbCitizen);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(labelValid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelValid;
        private TextBox txtName;
        private TextBox txtID;
        private ComboBox cbCitizen;
        private Button btnValidate;
        private ListBox lbOutput;
        private Button btnGenerate;
    }
}
