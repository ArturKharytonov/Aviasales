namespace Aviasales
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.lbBalanceData = new System.Windows.Forms.Label();
            this.lbAgeData = new System.Windows.Forms.Label();
            this.lbSurnameData = new System.Windows.Forms.Label();
            this.lbNameData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanelCutomerMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFunctional = new System.Windows.Forms.Button();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanelCutomerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.lbBalanceData);
            this.groupBoxData.Controls.Add(this.lbAgeData);
            this.groupBoxData.Controls.Add(this.lbSurnameData);
            this.groupBoxData.Controls.Add(this.lbNameData);
            this.groupBoxData.Location = new System.Drawing.Point(491, 22);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(459, 230);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Client\'s data";
            // 
            // lbBalanceData
            // 
            this.lbBalanceData.AutoSize = true;
            this.lbBalanceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBalanceData.Location = new System.Drawing.Point(6, 184);
            this.lbBalanceData.Name = "lbBalanceData";
            this.lbBalanceData.Size = new System.Drawing.Size(79, 20);
            this.lbBalanceData.TabIndex = 3;
            this.lbBalanceData.Text = "Balance:";
            // 
            // lbAgeData
            // 
            this.lbAgeData.AutoSize = true;
            this.lbAgeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAgeData.Location = new System.Drawing.Point(6, 137);
            this.lbAgeData.Name = "lbAgeData";
            this.lbAgeData.Size = new System.Drawing.Size(51, 20);
            this.lbAgeData.TabIndex = 2;
            this.lbAgeData.Text = "Age: ";
            // 
            // lbSurnameData
            // 
            this.lbSurnameData.AutoSize = true;
            this.lbSurnameData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurnameData.Location = new System.Drawing.Point(6, 95);
            this.lbSurnameData.Name = "lbSurnameData";
            this.lbSurnameData.Size = new System.Drawing.Size(91, 20);
            this.lbSurnameData.TabIndex = 1;
            this.lbSurnameData.Text = "Surname: ";
            // 
            // lbNameData
            // 
            this.lbNameData.AutoSize = true;
            this.lbNameData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameData.Location = new System.Drawing.Point(6, 47);
            this.lbNameData.Name = "lbNameData";
            this.lbNameData.Size = new System.Drawing.Size(60, 20);
            this.lbNameData.TabIndex = 0;
            this.lbNameData.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AccessibleDescription = "";
            this.btnLogOut.AutoEllipsis = true;
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatAppearance.BorderSize = 15;
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogOut.Location = new System.Drawing.Point(70, 475);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(50, 250, 3, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(135, 38);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // flowLayoutPanelCutomerMenu
            // 
            this.flowLayoutPanelCutomerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(89)))));
            this.flowLayoutPanelCutomerMenu.Controls.Add(this.btnInfo);
            this.flowLayoutPanelCutomerMenu.Controls.Add(this.button1);
            this.flowLayoutPanelCutomerMenu.Controls.Add(this.btnFunctional);
            this.flowLayoutPanelCutomerMenu.Controls.Add(this.btnLogOut);
            this.flowLayoutPanelCutomerMenu.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelCutomerMenu.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanelCutomerMenu.Name = "flowLayoutPanelCutomerMenu";
            this.flowLayoutPanelCutomerMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowLayoutPanelCutomerMenu.Size = new System.Drawing.Size(205, 516);
            this.flowLayoutPanelCutomerMenu.TabIndex = 5;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInfo.Location = new System.Drawing.Point(23, 55);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 55, 3, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(144, 37);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Information";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(23, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFunctional
            // 
            this.btnFunctional.BackColor = System.Drawing.Color.White;
            this.btnFunctional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFunctional.Location = new System.Drawing.Point(23, 185);
            this.btnFunctional.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.btnFunctional.Name = "btnFunctional";
            this.btnFunctional.Size = new System.Drawing.Size(144, 37);
            this.btnFunctional.TabIndex = 1;
            this.btnFunctional.Text = "Functional";
            this.btnFunctional.UseVisualStyleBackColor = false;
            this.btnFunctional.Click += new System.EventHandler(this.btn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(962, 514);
            this.Controls.Add(this.flowLayoutPanelCutomerMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanelCutomerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label lbBalanceData;
        private System.Windows.Forms.Label lbAgeData;
        private System.Windows.Forms.Label lbSurnameData;
        private System.Windows.Forms.Label lbNameData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCutomerMenu;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFunctional;
    }
}