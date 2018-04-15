namespace Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonBreakfast = new System.Windows.Forms.RadioButton();
            this.radioButtonLunch = new System.Windows.Forms.RadioButton();
            this.radioButtonDinner = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxBreakfast = new System.Windows.Forms.ListBox();
            this.listBoxLunch = new System.Windows.Forms.ListBox();
            this.listBoxDinner = new System.Windows.Forms.ListBox();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profileBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(209, 38);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(115, 33);
            this.textBoxInput.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(337, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(48, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.btnAddClick);
            // 
            // radioButtonBreakfast
            // 
            this.radioButtonBreakfast.AutoSize = true;
            this.radioButtonBreakfast.Location = new System.Drawing.Point(4, 35);
            this.radioButtonBreakfast.Name = "radioButtonBreakfast";
            this.radioButtonBreakfast.Size = new System.Drawing.Size(74, 20);
            this.radioButtonBreakfast.TabIndex = 3;
            this.radioButtonBreakfast.TabStop = true;
            this.radioButtonBreakfast.Text = "Breakfast";
            this.radioButtonBreakfast.UseVisualStyleBackColor = true;
            // 
            // radioButtonLunch
            // 
            this.radioButtonLunch.AutoSize = true;
            this.radioButtonLunch.Location = new System.Drawing.Point(99, 35);
            this.radioButtonLunch.Name = "radioButtonLunch";
            this.radioButtonLunch.Size = new System.Drawing.Size(56, 20);
            this.radioButtonLunch.TabIndex = 4;
            this.radioButtonLunch.TabStop = true;
            this.radioButtonLunch.Text = "Lunch";
            this.radioButtonLunch.UseVisualStyleBackColor = true;
            // 
            // radioButtonDinner
            // 
            this.radioButtonDinner.AutoSize = true;
            this.radioButtonDinner.Location = new System.Drawing.Point(174, 35);
            this.radioButtonDinner.Name = "radioButtonDinner";
            this.radioButtonDinner.Size = new System.Drawing.Size(60, 20);
            this.radioButtonDinner.TabIndex = 5;
            this.radioButtonDinner.TabStop = true;
            this.radioButtonDinner.Text = "Dinner";
            this.radioButtonDinner.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBreakfast);
            this.groupBox1.Controls.Add(this.radioButtonLunch);
            this.groupBox1.Controls.Add(this.radioButtonDinner);
            this.groupBox1.Location = new System.Drawing.Point(416, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose time";
            // 
            // listBoxBreakfast
            // 
            this.listBoxBreakfast.FormattingEnabled = true;
            this.listBoxBreakfast.ItemHeight = 16;
            this.listBoxBreakfast.Location = new System.Drawing.Point(416, 131);
            this.listBoxBreakfast.Name = "listBoxBreakfast";
            this.listBoxBreakfast.Size = new System.Drawing.Size(85, 100);
            this.listBoxBreakfast.TabIndex = 7;
            // 
            // listBoxLunch
            // 
            this.listBoxLunch.FormattingEnabled = true;
            this.listBoxLunch.ItemHeight = 16;
            this.listBoxLunch.Location = new System.Drawing.Point(505, 131);
            this.listBoxLunch.Name = "listBoxLunch";
            this.listBoxLunch.Size = new System.Drawing.Size(85, 100);
            this.listBoxLunch.TabIndex = 8;
            // 
            // listBoxDinner
            // 
            this.listBoxDinner.FormattingEnabled = true;
            this.listBoxDinner.ItemHeight = 16;
            this.listBoxDinner.Location = new System.Drawing.Point(595, 131);
            this.listBoxDinner.Name = "listBoxDinner";
            this.listBoxDinner.Size = new System.Drawing.Size(85, 100);
            this.listBoxDinner.TabIndex = 9;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalyze.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalyze.ForeColor = System.Drawing.Color.White;
            this.buttonAnalyze.Location = new System.Drawing.Point(416, 241);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(263, 51);
            this.buttonAnalyze.TabIndex = 10;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = false;
            this.buttonAnalyze.Click += new System.EventHandler(this.btnAnalyzeClick);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(209, 131);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(190, 100);
            this.listBoxResult.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.statBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(2, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(200, 418);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My Profile";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "sjdksmd";
            // 
            // statBtn
            // 
            this.statBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.statBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statBtn.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statBtn.ForeColor = System.Drawing.Color.White;
            this.statBtn.Location = new System.Drawing.Point(48, 317);
            this.statBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statBtn.Name = "statBtn";
            this.statBtn.Size = new System.Drawing.Size(88, 34);
            this.statBtn.TabIndex = 4;
            this.statBtn.Text = "Statistics";
            this.statBtn.UseVisualStyleBackColor = false;
            this.statBtn.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calories: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Location = new System.Drawing.Point(60, 38);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(54, 33);
            this.profileBtn.TabIndex = 13;
            this.profileBtn.Text = "More";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(934, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.listBoxDinner);
            this.Controls.Add(this.listBoxLunch);
            this.Controls.Add(this.listBoxBreakfast);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxInput);
            this.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonBreakfast;
        private System.Windows.Forms.RadioButton radioButtonLunch;
        private System.Windows.Forms.RadioButton radioButtonDinner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxBreakfast;
        private System.Windows.Forms.ListBox listBoxLunch;
        private System.Windows.Forms.ListBox listBoxDinner;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button statBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

