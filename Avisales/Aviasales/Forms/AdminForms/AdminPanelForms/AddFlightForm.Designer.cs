namespace Aviasales.Forms.AdminForms.AdminPanelForms
{
    partial class AddFlightForm
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
            this.gbFlight = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownIdFlight = new System.Windows.Forms.NumericUpDown();
            this.labelFlightID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbTickets = new System.Windows.Forms.GroupBox();
            this.numericPriceBusiness = new System.Windows.Forms.NumericUpDown();
            this.numericPricePremiumEc = new System.Windows.Forms.NumericUpDown();
            this.numericPriceEconom = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericBusiness = new System.Windows.Forms.NumericUpDown();
            this.numericPremiumEconomy = new System.Windows.Forms.NumericUpDown();
            this.numericEconomy = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownIndex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gbFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdFlight)).BeginInit();
            this.gbTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPricePremiumEc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceEconom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPremiumEconomy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEconomy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFlight
            // 
            this.gbFlight.Controls.Add(this.dateTimePicker2);
            this.gbFlight.Controls.Add(this.dateTimePicker1);
            this.gbFlight.Controls.Add(this.label11);
            this.gbFlight.Controls.Add(this.numericUpDownIdFlight);
            this.gbFlight.Controls.Add(this.labelFlightID);
            this.gbFlight.Controls.Add(this.btnAdd);
            this.gbFlight.Controls.Add(this.textBox2);
            this.gbFlight.Controls.Add(this.textBox1);
            this.gbFlight.Controls.Add(this.gbTickets);
            this.gbFlight.Controls.Add(this.numericUpDownIndex);
            this.gbFlight.Controls.Add(this.label4);
            this.gbFlight.Controls.Add(this.label3);
            this.gbFlight.Controls.Add(this.label2);
            this.gbFlight.Controls.Add(this.label1);
            this.gbFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFlight.Location = new System.Drawing.Point(108, 49);
            this.gbFlight.Name = "gbFlight";
            this.gbFlight.Size = new System.Drawing.Size(634, 521);
            this.gbFlight.TabIndex = 0;
            this.gbFlight.TabStop = false;
            this.gbFlight.Text = "Flight";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 27);
            this.label11.TabIndex = 15;
            this.label11.Text = "Arriving date:";
            // 
            // numericUpDownIdFlight
            // 
            this.numericUpDownIdFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numericUpDownIdFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIdFlight.Location = new System.Drawing.Point(491, 37);
            this.numericUpDownIdFlight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownIdFlight.Name = "numericUpDownIdFlight";
            this.numericUpDownIdFlight.Size = new System.Drawing.Size(135, 38);
            this.numericUpDownIdFlight.TabIndex = 14;
            // 
            // labelFlightID
            // 
            this.labelFlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFlightID.Location = new System.Drawing.Point(330, 45);
            this.labelFlightID.Name = "labelFlightID";
            this.labelFlightID.Size = new System.Drawing.Size(143, 27);
            this.labelFlightID.TabIndex = 13;
            this.labelFlightID.Text = "Flight\'s ID: ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(467, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(171, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 35);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(171, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 35);
            this.textBox1.TabIndex = 9;
            // 
            // gbTickets
            // 
            this.gbTickets.Controls.Add(this.numericPriceBusiness);
            this.gbTickets.Controls.Add(this.numericPricePremiumEc);
            this.gbTickets.Controls.Add(this.numericPriceEconom);
            this.gbTickets.Controls.Add(this.label10);
            this.gbTickets.Controls.Add(this.label9);
            this.gbTickets.Controls.Add(this.label8);
            this.gbTickets.Controls.Add(this.numericBusiness);
            this.gbTickets.Controls.Add(this.numericPremiumEconomy);
            this.gbTickets.Controls.Add(this.numericEconomy);
            this.gbTickets.Controls.Add(this.label7);
            this.gbTickets.Controls.Add(this.label6);
            this.gbTickets.Controls.Add(this.label5);
            this.gbTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTickets.Location = new System.Drawing.Point(27, 280);
            this.gbTickets.Name = "gbTickets";
            this.gbTickets.Size = new System.Drawing.Size(599, 165);
            this.gbTickets.TabIndex = 8;
            this.gbTickets.TabStop = false;
            this.gbTickets.Text = "Tickets";
            // 
            // numericPriceBusiness
            // 
            this.numericPriceBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numericPriceBusiness.DecimalPlaces = 1;
            this.numericPriceBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPriceBusiness.Location = new System.Drawing.Point(440, 115);
            this.numericPriceBusiness.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPriceBusiness.Name = "numericPriceBusiness";
            this.numericPriceBusiness.Size = new System.Drawing.Size(135, 29);
            this.numericPriceBusiness.TabIndex = 17;
            // 
            // numericPricePremiumEc
            // 
            this.numericPricePremiumEc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numericPricePremiumEc.DecimalPlaces = 1;
            this.numericPricePremiumEc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPricePremiumEc.Location = new System.Drawing.Point(440, 73);
            this.numericPricePremiumEc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPricePremiumEc.Name = "numericPricePremiumEc";
            this.numericPricePremiumEc.Size = new System.Drawing.Size(135, 29);
            this.numericPricePremiumEc.TabIndex = 16;
            // 
            // numericPriceEconom
            // 
            this.numericPriceEconom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numericPriceEconom.DecimalPlaces = 1;
            this.numericPriceEconom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPriceEconom.Location = new System.Drawing.Point(440, 30);
            this.numericPriceEconom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPriceEconom.Name = "numericPriceEconom";
            this.numericPriceEconom.Size = new System.Drawing.Size(135, 29);
            this.numericPriceEconom.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(389, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Price: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(389, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Price: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(389, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Price: ";
            // 
            // numericBusiness
            // 
            this.numericBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numericBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericBusiness.Location = new System.Drawing.Point(237, 115);
            this.numericBusiness.Name = "numericBusiness";
            this.numericBusiness.Size = new System.Drawing.Size(135, 29);
            this.numericBusiness.TabIndex = 11;
            // 
            // numericPremiumEconomy
            // 
            this.numericPremiumEconomy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numericPremiumEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPremiumEconomy.Location = new System.Drawing.Point(237, 73);
            this.numericPremiumEconomy.Name = "numericPremiumEconomy";
            this.numericPremiumEconomy.Size = new System.Drawing.Size(135, 29);
            this.numericPremiumEconomy.TabIndex = 10;
            // 
            // numericEconomy
            // 
            this.numericEconomy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numericEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericEconomy.Location = new System.Drawing.Point(237, 29);
            this.numericEconomy.Name = "numericEconomy";
            this.numericEconomy.Size = new System.Drawing.Size(135, 29);
            this.numericEconomy.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Business count: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Premium economy count: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Economy count: ";
            // 
            // numericUpDownIndex
            // 
            this.numericUpDownIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numericUpDownIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIndex.Location = new System.Drawing.Point(176, 40);
            this.numericUpDownIndex.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownIndex.Name = "numericUpDownIndex";
            this.numericUpDownIndex.Size = new System.Drawing.Size(135, 38);
            this.numericUpDownIndex.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plane\'s ID: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(371, 38);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(171, 225);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(371, 38);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(834, 594);
            this.Controls.Add(this.gbFlight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddFlightForm";
            this.Text = "AddFlightForm";
            this.gbFlight.ResumeLayout(false);
            this.gbFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdFlight)).EndInit();
            this.gbTickets.ResumeLayout(false);
            this.gbTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPricePremiumEc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceEconom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPremiumEconomy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEconomy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFlight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTickets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericBusiness;
        private System.Windows.Forms.NumericUpDown numericPremiumEconomy;
        private System.Windows.Forms.NumericUpDown numericEconomy;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownIdFlight;
        private System.Windows.Forms.Label labelFlightID;
        private System.Windows.Forms.NumericUpDown numericPriceBusiness;
        private System.Windows.Forms.NumericUpDown numericPricePremiumEc;
        private System.Windows.Forms.NumericUpDown numericPriceEconom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}