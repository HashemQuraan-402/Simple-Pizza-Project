namespace PizzaProject
{
    partial class frmMain
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
            this.lbHead = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomiatos = new System.Windows.Forms.CheckBox();
            this.chkMashrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbGreenPeppers = new System.Windows.Forms.Label();
            this.lbOlives = new System.Windows.Forms.Label();
            this.lbOnion = new System.Windows.Forms.Label();
            this.lbTomatos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMashrooms = new System.Windows.Forms.Label();
            this.lbExtraChees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbHead.Location = new System.Drawing.Point(238, 9);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(273, 38);
            this.lbHead.TabIndex = 0;
            this.lbHead.Text = "Make your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(21, 62);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(150, 142);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(41, 102);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(60, 20);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(41, 70);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(73, 20);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(41, 38);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(59, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCrustType.Controls.Add(this.rbThinkCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(21, 213);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(150, 152);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinkCrust.Location = new System.Drawing.Point(34, 104);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(91, 20);
            this.rbThinkCrust.TabIndex = 4;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Tag = "10";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(34, 51);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(84, 20);
            this.rbThinCrust.TabIndex = 3;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "5";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomiatos);
            this.gbToppings.Controls.Add(this.chkMashrooms);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(230, 62);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(276, 142);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(148, 110);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(118, 20);
            this.chkGreenPeppers.TabIndex = 10;
            this.chkGreenPeppers.Tag = "1";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(148, 74);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(64, 20);
            this.chkOlives.TabIndex = 9;
            this.chkOlives.Tag = "2";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(148, 38);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(61, 20);
            this.chkOnion.TabIndex = 8;
            this.chkOnion.Tag = "3";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomiatos
            // 
            this.chkTomiatos.AutoSize = true;
            this.chkTomiatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomiatos.Location = new System.Drawing.Point(15, 110);
            this.chkTomiatos.Name = "chkTomiatos";
            this.chkTomiatos.Size = new System.Drawing.Size(83, 20);
            this.chkTomiatos.TabIndex = 7;
            this.chkTomiatos.Tag = "4";
            this.chkTomiatos.Text = "Tomiatos";
            this.chkTomiatos.UseVisualStyleBackColor = true;
            this.chkTomiatos.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkMashrooms
            // 
            this.chkMashrooms.AutoSize = true;
            this.chkMashrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMashrooms.Location = new System.Drawing.Point(15, 74);
            this.chkMashrooms.Name = "chkMashrooms";
            this.chkMashrooms.Size = new System.Drawing.Size(97, 20);
            this.chkMashrooms.TabIndex = 6;
            this.chkMashrooms.Tag = "5";
            this.chkMashrooms.Text = "Mashrooms";
            this.chkMashrooms.UseVisualStyleBackColor = true;
            this.chkMashrooms.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.Location = new System.Drawing.Point(15, 38);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(98, 20);
            this.chkExtraChees.TabIndex = 5;
            this.chkExtraChees.Tag = "6";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(230, 210);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(276, 71);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(133, 38);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(80, 20);
            this.rbTakeOut.TabIndex = 12;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(29, 38);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 11;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "5";
            this.rbEatIn.Text = "Eat IN";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.White;
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOrderPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(230, 369);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(110, 48);
            this.btnOrderPizza.TabIndex = 15;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            this.btnOrderPizza.MouseEnter += new System.EventHandler(this.btnOrderPizza_MouseEnter_1);
            this.btnOrderPizza.MouseLeave += new System.EventHandler(this.btnOrderPizza_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(396, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 48);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbWhereToEat);
            this.groupBox1.Controls.Add(this.lbCrustType);
            this.groupBox1.Controls.Add(this.lbGreenPeppers);
            this.groupBox1.Controls.Add(this.lbOlives);
            this.groupBox1.Controls.Add(this.lbOnion);
            this.groupBox1.Controls.Add(this.lbTomatos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbMashrooms);
            this.groupBox1.Controls.Add(this.lbExtraChees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(533, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 326);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Crust Type :";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Lime;
            this.lbPrice.Location = new System.Drawing.Point(138, 253);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 50);
            this.lbPrice.TabIndex = 14;
            this.lbPrice.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Total Price : ";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Location = new System.Drawing.Point(167, 212);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(51, 20);
            this.lbWhereToEat.TabIndex = 12;
            this.lbWhereToEat.Text = "label2";
            this.lbWhereToEat.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Location = new System.Drawing.Point(131, 174);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(51, 20);
            this.lbCrustType.TabIndex = 11;
            this.lbCrustType.Text = "label2";
            // 
            // lbGreenPeppers
            // 
            this.lbGreenPeppers.AutoSize = true;
            this.lbGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreenPeppers.Location = new System.Drawing.Point(155, 142);
            this.lbGreenPeppers.Name = "lbGreenPeppers";
            this.lbGreenPeppers.Size = new System.Drawing.Size(78, 13);
            this.lbGreenPeppers.TabIndex = 10;
            this.lbGreenPeppers.Text = "Green Peppers";
            this.lbGreenPeppers.Visible = false;
            this.lbGreenPeppers.Click += new System.EventHandler(this.lbGreenPeppers_Click);
            // 
            // lbOlives
            // 
            this.lbOlives.AutoSize = true;
            this.lbOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOlives.Location = new System.Drawing.Point(96, 142);
            this.lbOlives.Name = "lbOlives";
            this.lbOlives.Size = new System.Drawing.Size(36, 13);
            this.lbOlives.TabIndex = 9;
            this.lbOlives.Text = "Olives";
            this.lbOlives.Visible = false;
            this.lbOlives.Click += new System.EventHandler(this.lbOlives_Click);
            // 
            // lbOnion
            // 
            this.lbOnion.AutoSize = true;
            this.lbOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnion.Location = new System.Drawing.Point(31, 142);
            this.lbOnion.Name = "lbOnion";
            this.lbOnion.Size = new System.Drawing.Size(35, 13);
            this.lbOnion.TabIndex = 8;
            this.lbOnion.Text = "Onion";
            this.lbOnion.Visible = false;
            this.lbOnion.Click += new System.EventHandler(this.lbOnion_Click);
            // 
            // lbTomatos
            // 
            this.lbTomatos.AutoSize = true;
            this.lbTomatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTomatos.Location = new System.Drawing.Point(183, 106);
            this.lbTomatos.Name = "lbTomatos";
            this.lbTomatos.Size = new System.Drawing.Size(50, 13);
            this.lbTomatos.TabIndex = 7;
            this.lbTomatos.Text = "Tomiatos";
            this.lbTomatos.Visible = false;
            this.lbTomatos.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Where to Eat :";
            // 
            // lbMashrooms
            // 
            this.lbMashrooms.AutoSize = true;
            this.lbMashrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMashrooms.Location = new System.Drawing.Point(101, 106);
            this.lbMashrooms.Name = "lbMashrooms";
            this.lbMashrooms.Size = new System.Drawing.Size(61, 13);
            this.lbMashrooms.TabIndex = 5;
            this.lbMashrooms.Text = "Mashrooms";
            this.lbMashrooms.Visible = false;
            this.lbMashrooms.Click += new System.EventHandler(this.lbMashrooms_Click);
            // 
            // lbExtraChees
            // 
            this.lbExtraChees.AutoSize = true;
            this.lbExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtraChees.Location = new System.Drawing.Point(31, 106);
            this.lbExtraChees.Name = "lbExtraChees";
            this.lbExtraChees.Size = new System.Drawing.Size(64, 13);
            this.lbExtraChees.TabIndex = 3;
            this.lbExtraChees.Text = "Extra Chees";
            this.lbExtraChees.Visible = false;
            this.lbExtraChees.Click += new System.EventHandler(this.lbExtraChees_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(85, 38);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(51, 20);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = "label2";
            this.lbSize.TextChanged += new System.EventHandler(this.lbSize_TextChanged);
            this.lbSize.Click += new System.EventHandler(this.lbSize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size : ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(230, 307);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(276, 31);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lbHead);
            this.Name = "frmMain";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomiatos;
        private System.Windows.Forms.CheckBox chkMashrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbGreenPeppers;
        private System.Windows.Forms.Label lbOlives;
        private System.Windows.Forms.Label lbOnion;
        private System.Windows.Forms.Label lbTomatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMashrooms;
        private System.Windows.Forms.Label lbExtraChees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

