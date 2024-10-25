namespace FirstProjectWithForms
{
    partial class frmPizza
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
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rdbLarg = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.grbCrustType = new System.Windows.Forms.GroupBox();
            this.rdbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rdbThinCrust = new System.Windows.Forms.RadioButton();
            this.grbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdbTakeOut = new System.Windows.Forms.RadioButton();
            this.rdbEatin = new System.Windows.Forms.RadioButton();
            this.grbTotalPrice = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grbTopping = new System.Windows.Forms.GroupBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbExtraChees = new System.Windows.Forms.CheckBox();
            this.grbOrderSummaty = new System.Windows.Forms.GroupBox();
            this.txtToEat = new System.Windows.Forms.TextBox();
            this.txtTopping = new System.Windows.Forms.TextBox();
            this.txtCrustType = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbSize.SuspendLayout();
            this.grbCrustType.SuspendLayout();
            this.grbWhereToEat.SuspendLayout();
            this.grbTotalPrice.SuspendLayout();
            this.grbTopping.SuspendLayout();
            this.grbOrderSummaty.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.rdbLarg);
            this.grbSize.Controls.Add(this.rdbMedium);
            this.grbSize.Controls.Add(this.rdbSmall);
            this.grbSize.Location = new System.Drawing.Point(35, 183);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(200, 170);
            this.grbSize.TabIndex = 0;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // rdbLarg
            // 
            this.rdbLarg.AutoSize = true;
            this.rdbLarg.Location = new System.Drawing.Point(16, 134);
            this.rdbLarg.Name = "rdbLarg";
            this.rdbLarg.Size = new System.Drawing.Size(55, 20);
            this.rdbLarg.TabIndex = 2;
            this.rdbLarg.TabStop = true;
            this.rdbLarg.Tag = "60";
            this.rdbLarg.Text = "Larg";
            this.rdbLarg.UseVisualStyleBackColor = true;
            this.rdbLarg.CheckedChanged += new System.EventHandler(this.rdbLarg_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(16, 81);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(76, 20);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Tag = "40";
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(16, 28);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(62, 20);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.Tag = "20";
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // grbCrustType
            // 
            this.grbCrustType.Controls.Add(this.rdbThinkCrust);
            this.grbCrustType.Controls.Add(this.rdbThinCrust);
            this.grbCrustType.Location = new System.Drawing.Point(35, 499);
            this.grbCrustType.Name = "grbCrustType";
            this.grbCrustType.Size = new System.Drawing.Size(200, 100);
            this.grbCrustType.TabIndex = 1;
            this.grbCrustType.TabStop = false;
            this.grbCrustType.Text = "Crust Type";
            // 
            // rdbThinkCrust
            // 
            this.rdbThinkCrust.AutoSize = true;
            this.rdbThinkCrust.Location = new System.Drawing.Point(16, 74);
            this.rdbThinkCrust.Name = "rdbThinkCrust";
            this.rdbThinkCrust.Size = new System.Drawing.Size(94, 20);
            this.rdbThinkCrust.TabIndex = 3;
            this.rdbThinkCrust.TabStop = true;
            this.rdbThinkCrust.Tag = "10";
            this.rdbThinkCrust.Text = "Think Crust";
            this.rdbThinkCrust.UseVisualStyleBackColor = true;
            this.rdbThinkCrust.CheckedChanged += new System.EventHandler(this.rdbThinkCrust_CheckedChanged);
            // 
            // rdbThinCrust
            // 
            this.rdbThinCrust.AutoSize = true;
            this.rdbThinCrust.Location = new System.Drawing.Point(16, 41);
            this.rdbThinCrust.Name = "rdbThinCrust";
            this.rdbThinCrust.Size = new System.Drawing.Size(87, 20);
            this.rdbThinCrust.TabIndex = 4;
            this.rdbThinCrust.Tag = "0";
            this.rdbThinCrust.Text = "Thin Crust";
            this.rdbThinCrust.UseVisualStyleBackColor = true;
            this.rdbThinCrust.CheckedChanged += new System.EventHandler(this.rdbThinCrust_CheckedChanged);
            // 
            // grbWhereToEat
            // 
            this.grbWhereToEat.Controls.Add(this.rdbTakeOut);
            this.grbWhereToEat.Controls.Add(this.rdbEatin);
            this.grbWhereToEat.Location = new System.Drawing.Point(435, 499);
            this.grbWhereToEat.Name = "grbWhereToEat";
            this.grbWhereToEat.Size = new System.Drawing.Size(200, 100);
            this.grbWhereToEat.TabIndex = 1;
            this.grbWhereToEat.TabStop = false;
            this.grbWhereToEat.Text = "Where To Eat";
            // 
            // rdbTakeOut
            // 
            this.rdbTakeOut.AutoSize = true;
            this.rdbTakeOut.Location = new System.Drawing.Point(6, 74);
            this.rdbTakeOut.Name = "rdbTakeOut";
            this.rdbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rdbTakeOut.TabIndex = 5;
            this.rdbTakeOut.Text = "Take Out";
            this.rdbTakeOut.UseVisualStyleBackColor = true;
            this.rdbTakeOut.CheckedChanged += new System.EventHandler(this.rdbTakeOut_CheckedChanged);
            // 
            // rdbEatin
            // 
            this.rdbEatin.AutoSize = true;
            this.rdbEatin.Location = new System.Drawing.Point(6, 41);
            this.rdbEatin.Name = "rdbEatin";
            this.rdbEatin.Size = new System.Drawing.Size(61, 20);
            this.rdbEatin.TabIndex = 6;
            this.rdbEatin.TabStop = true;
            this.rdbEatin.Text = "Eat in";
            this.rdbEatin.UseVisualStyleBackColor = true;
            this.rdbEatin.CheckedChanged += new System.EventHandler(this.rdbEatin_CheckedChanged);
            // 
            // grbTotalPrice
            // 
            this.grbTotalPrice.Controls.Add(this.lblTotalPrice);
            this.grbTotalPrice.Location = new System.Drawing.Point(835, 499);
            this.grbTotalPrice.Name = "grbTotalPrice";
            this.grbTotalPrice.Size = new System.Drawing.Size(200, 100);
            this.grbTotalPrice.TabIndex = 1;
            this.grbTotalPrice.TabStop = false;
            this.grbTotalPrice.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(64, 45);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(56, 51);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Tag = "0";
            this.lblTotalPrice.Text = "0";
            // 
            // grbTopping
            // 
            this.grbTopping.Controls.Add(this.chbMushrooms);
            this.grbTopping.Controls.Add(this.chbOnion);
            this.grbTopping.Controls.Add(this.chbOlives);
            this.grbTopping.Controls.Add(this.chbGreenPeppers);
            this.grbTopping.Controls.Add(this.chbTomatoes);
            this.grbTopping.Controls.Add(this.chbExtraChees);
            this.grbTopping.Location = new System.Drawing.Point(349, 183);
            this.grbTopping.Name = "grbTopping";
            this.grbTopping.Size = new System.Drawing.Size(297, 191);
            this.grbTopping.TabIndex = 1;
            this.grbTopping.TabStop = false;
            this.grbTopping.Text = "Topping";
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Location = new System.Drawing.Point(7, 81);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chbMushrooms.TabIndex = 5;
            this.chbMushrooms.Tag = "5";
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.chbMushrooms_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(162, 28);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(64, 20);
            this.chbOnion.TabIndex = 4;
            this.chbOnion.Tag = "5";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(162, 81);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(67, 20);
            this.chbOlives.TabIndex = 3;
            this.chbOlives.Tag = "5";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbGreenPeppers
            // 
            this.chbGreenPeppers.AutoSize = true;
            this.chbGreenPeppers.Location = new System.Drawing.Point(162, 134);
            this.chbGreenPeppers.Name = "chbGreenPeppers";
            this.chbGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chbGreenPeppers.TabIndex = 2;
            this.chbGreenPeppers.Tag = "5";
            this.chbGreenPeppers.Text = "Green Peppers";
            this.chbGreenPeppers.UseVisualStyleBackColor = true;
            this.chbGreenPeppers.CheckedChanged += new System.EventHandler(this.chbGreenPeppers_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(7, 134);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chbTomatoes.TabIndex = 1;
            this.chbTomatoes.Tag = "5";
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbExtraChees
            // 
            this.chbExtraChees.AutoSize = true;
            this.chbExtraChees.Location = new System.Drawing.Point(7, 28);
            this.chbExtraChees.Name = "chbExtraChees";
            this.chbExtraChees.Size = new System.Drawing.Size(101, 20);
            this.chbExtraChees.TabIndex = 0;
            this.chbExtraChees.Tag = "5";
            this.chbExtraChees.Text = "Extra Chees";
            this.chbExtraChees.UseVisualStyleBackColor = true;
            this.chbExtraChees.CheckedChanged += new System.EventHandler(this.chbExtraChees_CheckedChanged);
            // 
            // grbOrderSummaty
            // 
            this.grbOrderSummaty.Controls.Add(this.txtToEat);
            this.grbOrderSummaty.Controls.Add(this.txtTopping);
            this.grbOrderSummaty.Controls.Add(this.txtCrustType);
            this.grbOrderSummaty.Controls.Add(this.txtSize);
            this.grbOrderSummaty.Controls.Add(this.lblWhereToEat);
            this.grbOrderSummaty.Controls.Add(this.lblCrustType);
            this.grbOrderSummaty.Controls.Add(this.lblTopping);
            this.grbOrderSummaty.Controls.Add(this.lblSize);
            this.grbOrderSummaty.Location = new System.Drawing.Point(707, 183);
            this.grbOrderSummaty.Name = "grbOrderSummaty";
            this.grbOrderSummaty.Size = new System.Drawing.Size(328, 273);
            this.grbOrderSummaty.TabIndex = 1;
            this.grbOrderSummaty.TabStop = false;
            this.grbOrderSummaty.Text = "Order Summary";
            // 
            // txtToEat
            // 
            this.txtToEat.Enabled = false;
            this.txtToEat.Location = new System.Drawing.Point(123, 229);
            this.txtToEat.Name = "txtToEat";
            this.txtToEat.Size = new System.Drawing.Size(176, 22);
            this.txtToEat.TabIndex = 12;
            // 
            // txtTopping
            // 
            this.txtTopping.Enabled = false;
            this.txtTopping.Location = new System.Drawing.Point(123, 105);
            this.txtTopping.Multiline = true;
            this.txtTopping.Name = "txtTopping";
            this.txtTopping.Size = new System.Drawing.Size(176, 61);
            this.txtTopping.TabIndex = 11;
            // 
            // txtCrustType
            // 
            this.txtCrustType.Enabled = false;
            this.txtCrustType.Location = new System.Drawing.Point(123, 187);
            this.txtCrustType.Name = "txtCrustType";
            this.txtCrustType.Size = new System.Drawing.Size(176, 22);
            this.txtCrustType.TabIndex = 10;
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(123, 40);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(176, 22);
            this.txtSize.TabIndex = 5;
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(21, 229);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(96, 16);
            this.lblWhereToEat.TabIndex = 6;
            this.lblWhereToEat.Text = "Where To Eat :";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point(21, 187);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(78, 16);
            this.lblCrustType.TabIndex = 7;
            this.lblCrustType.Text = "Crust Type :";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Location = new System.Drawing.Point(21, 105);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(64, 16);
            this.lblTopping.TabIndex = 8;
            this.lblTopping.Text = "Topping :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(21, 40);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 16);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size :";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(331, 630);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(148, 46);
            this.btnOrderPizza.TabIndex = 2;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(517, 630);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(148, 46);
            this.btnResetForm.TabIndex = 3;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(185, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "Makw Your Pizza";
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grbCrustType);
            this.Controls.Add(this.grbWhereToEat);
            this.Controls.Add(this.grbTotalPrice);
            this.Controls.Add(this.grbTopping);
            this.Controls.Add(this.grbOrderSummaty);
            this.Controls.Add(this.grbSize);
            this.Name = "frmPizza";
            this.Text = "frmPizza";
            this.Load += new System.EventHandler(this.frmPizza_Load);
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbCrustType.ResumeLayout(false);
            this.grbCrustType.PerformLayout();
            this.grbWhereToEat.ResumeLayout(false);
            this.grbWhereToEat.PerformLayout();
            this.grbTotalPrice.ResumeLayout(false);
            this.grbTotalPrice.PerformLayout();
            this.grbTopping.ResumeLayout(false);
            this.grbTopping.PerformLayout();
            this.grbOrderSummaty.ResumeLayout(false);
            this.grbOrderSummaty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.GroupBox grbCrustType;
        private System.Windows.Forms.GroupBox grbWhereToEat;
        private System.Windows.Forms.GroupBox grbTotalPrice;
        private System.Windows.Forms.GroupBox grbTopping;
        private System.Windows.Forms.GroupBox grbOrderSummaty;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbGreenPeppers;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbExtraChees;
        private System.Windows.Forms.RadioButton rdbLarg;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbThinkCrust;
        private System.Windows.Forms.RadioButton rdbThinCrust;
        private System.Windows.Forms.RadioButton rdbTakeOut;
        private System.Windows.Forms.RadioButton rdbEatin;
        private System.Windows.Forms.TextBox txtToEat;
        private System.Windows.Forms.TextBox txtTopping;
        private System.Windows.Forms.TextBox txtCrustType;
        private System.Windows.Forms.TextBox txtSize;
    }
}