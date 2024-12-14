namespace Calculator
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
            this.txtDisplay = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn7 = new Guna.UI2.WinForms.Guna2Button();
            this.btn9 = new Guna.UI2.WinForms.Guna2Button();
            this.btn6 = new Guna.UI2.WinForms.Guna2Button();
            this.btn3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn8 = new Guna.UI2.WinForms.Guna2Button();
            this.btn5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnDot = new Guna.UI2.WinForms.Guna2Button();
            this.btnEqual = new Guna.UI2.WinForms.Guna2Button();
            this.btn0 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubs = new Guna.UI2.WinForms.Guna2Button();
            this.btnMulti = new Guna.UI2.WinForms.Guna2Button();
            this.btnDivision = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackspace = new Guna.UI2.WinForms.Guna2Button();
            this.btnC = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplay.DefaultText = "0";
            this.txtDisplay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDisplay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDisplay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisplay.DisabledState.Parent = this.txtDisplay;
            this.txtDisplay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisplay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisplay.FocusedState.Parent = this.txtDisplay;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Black;
            this.txtDisplay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisplay.HoverState.Parent = this.txtDisplay;
            this.txtDisplay.Location = new System.Drawing.Point(16, 33);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.PasswordChar = '\0';
            this.txtDisplay.PlaceholderText = "";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.SelectedText = "";
            this.txtDisplay.SelectionStart = 1;
            this.txtDisplay.ShadowDecoration.Parent = this.txtDisplay;
            this.txtDisplay.Size = new System.Drawing.Size(305, 56);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // btn1
            // 
            this.btn1.BorderRadius = 6;
            this.btn1.CheckedState.Parent = this.btn1;
            this.btn1.CustomImages.Parent = this.btn1;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.HoverState.Parent = this.btn1;
            this.btn1.Location = new System.Drawing.Point(12, 326);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1.Name = "btn1";
            this.btn1.ShadowDecoration.Parent = this.btn1;
            this.btn1.Size = new System.Drawing.Size(71, 51);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BorderRadius = 6;
            this.btn4.CheckedState.Parent = this.btn4;
            this.btn4.CustomImages.Parent = this.btn4;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.HoverState.Parent = this.btn4;
            this.btn4.Location = new System.Drawing.Point(12, 265);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn4.Name = "btn4";
            this.btn4.ShadowDecoration.Parent = this.btn4;
            this.btn4.Size = new System.Drawing.Size(71, 51);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.BorderRadius = 6;
            this.btn7.CheckedState.Parent = this.btn7;
            this.btn7.CustomImages.Parent = this.btn7;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.HoverState.Parent = this.btn7;
            this.btn7.Location = new System.Drawing.Point(12, 204);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn7.Name = "btn7";
            this.btn7.ShadowDecoration.Parent = this.btn7;
            this.btn7.Size = new System.Drawing.Size(71, 51);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.BorderRadius = 6;
            this.btn9.CheckedState.Parent = this.btn9;
            this.btn9.CustomImages.Parent = this.btn9;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.HoverState.Parent = this.btn9;
            this.btn9.Location = new System.Drawing.Point(170, 204);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn9.Name = "btn9";
            this.btn9.ShadowDecoration.Parent = this.btn9;
            this.btn9.Size = new System.Drawing.Size(71, 51);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BorderRadius = 6;
            this.btn6.CheckedState.Parent = this.btn6;
            this.btn6.CustomImages.Parent = this.btn6;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.HoverState.Parent = this.btn6;
            this.btn6.Location = new System.Drawing.Point(170, 265);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn6.Name = "btn6";
            this.btn6.ShadowDecoration.Parent = this.btn6;
            this.btn6.Size = new System.Drawing.Size(71, 51);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BorderRadius = 6;
            this.btn3.CheckedState.Parent = this.btn3;
            this.btn3.CustomImages.Parent = this.btn3;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.HoverState.Parent = this.btn3;
            this.btn3.Location = new System.Drawing.Point(170, 326);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn3.Name = "btn3";
            this.btn3.ShadowDecoration.Parent = this.btn3;
            this.btn3.Size = new System.Drawing.Size(71, 51);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn8
            // 
            this.btn8.BorderRadius = 6;
            this.btn8.CheckedState.Parent = this.btn8;
            this.btn8.CustomImages.Parent = this.btn8;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.HoverState.Parent = this.btn8;
            this.btn8.Location = new System.Drawing.Point(91, 204);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn8.Name = "btn8";
            this.btn8.ShadowDecoration.Parent = this.btn8;
            this.btn8.Size = new System.Drawing.Size(71, 51);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.BorderRadius = 6;
            this.btn5.CheckedState.Parent = this.btn5;
            this.btn5.CustomImages.Parent = this.btn5;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.HoverState.Parent = this.btn5;
            this.btn5.Location = new System.Drawing.Point(91, 265);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn5.Name = "btn5";
            this.btn5.ShadowDecoration.Parent = this.btn5;
            this.btn5.Size = new System.Drawing.Size(71, 51);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.BorderRadius = 6;
            this.btn2.CheckedState.Parent = this.btn2;
            this.btn2.CustomImages.Parent = this.btn2;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.HoverState.Parent = this.btn2;
            this.btn2.Location = new System.Drawing.Point(91, 326);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2.Name = "btn2";
            this.btn2.ShadowDecoration.Parent = this.btn2;
            this.btn2.Size = new System.Drawing.Size(71, 51);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnDot
            // 
            this.btnDot.BorderRadius = 6;
            this.btnDot.CheckedState.Parent = this.btnDot;
            this.btnDot.CustomImages.Parent = this.btnDot;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.HoverState.Parent = this.btnDot;
            this.btnDot.Location = new System.Drawing.Point(92, 387);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDot.Name = "btnDot";
            this.btnDot.ShadowDecoration.Parent = this.btnDot;
            this.btnDot.Size = new System.Drawing.Size(71, 51);
            this.btnDot.TabIndex = 13;
            this.btnDot.Text = ".";
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BorderRadius = 6;
            this.btnEqual.CheckedState.Parent = this.btnEqual;
            this.btnEqual.CustomImages.Parent = this.btnEqual;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.HoverState.Parent = this.btnEqual;
            this.btnEqual.Location = new System.Drawing.Point(171, 387);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.ShadowDecoration.Parent = this.btnEqual;
            this.btnEqual.Size = new System.Drawing.Size(149, 51);
            this.btnEqual.TabIndex = 14;
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn0
            // 
            this.btn0.BorderRadius = 6;
            this.btn0.CheckedState.Parent = this.btn0;
            this.btn0.CustomImages.Parent = this.btn0;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.HoverState.Parent = this.btn0;
            this.btn0.Location = new System.Drawing.Point(13, 387);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn0.Name = "btn0";
            this.btn0.ShadowDecoration.Parent = this.btn0;
            this.btn0.Size = new System.Drawing.Size(71, 51);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(250, 326);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(71, 51);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubs
            // 
            this.btnSubs.BorderRadius = 6;
            this.btnSubs.CheckedState.Parent = this.btnSubs;
            this.btnSubs.CustomImages.Parent = this.btnSubs;
            this.btnSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubs.ForeColor = System.Drawing.Color.White;
            this.btnSubs.HoverState.Parent = this.btnSubs;
            this.btnSubs.Location = new System.Drawing.Point(249, 265);
            this.btnSubs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubs.Name = "btnSubs";
            this.btnSubs.ShadowDecoration.Parent = this.btnSubs;
            this.btnSubs.Size = new System.Drawing.Size(71, 51);
            this.btnSubs.TabIndex = 19;
            this.btnSubs.Text = "-";
            this.btnSubs.Click += new System.EventHandler(this.btnSubs_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BorderRadius = 6;
            this.btnMulti.CheckedState.Parent = this.btnMulti;
            this.btnMulti.CustomImages.Parent = this.btnMulti;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.HoverState.Parent = this.btnMulti;
            this.btnMulti.Location = new System.Drawing.Point(249, 204);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.ShadowDecoration.Parent = this.btnMulti;
            this.btnMulti.Size = new System.Drawing.Size(71, 51);
            this.btnMulti.TabIndex = 18;
            this.btnMulti.Text = "x";
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BorderRadius = 6;
            this.btnDivision.CheckedState.Parent = this.btnDivision;
            this.btnDivision.CustomImages.Parent = this.btnDivision;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.HoverState.Parent = this.btnDivision;
            this.btnDivision.Location = new System.Drawing.Point(249, 143);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.ShadowDecoration.Parent = this.btnDivision;
            this.btnDivision.Size = new System.Drawing.Size(71, 51);
            this.btnDivision.TabIndex = 17;
            this.btnDivision.Text = "÷";
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BorderRadius = 6;
            this.btnBackspace.CheckedState.Parent = this.btnBackspace;
            this.btnBackspace.CustomImages.Parent = this.btnBackspace;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.Color.White;
            this.btnBackspace.HoverState.Parent = this.btnBackspace;
            this.btnBackspace.Location = new System.Drawing.Point(171, 143);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.ShadowDecoration.Parent = this.btnBackspace;
            this.btnBackspace.Size = new System.Drawing.Size(71, 51);
            this.btnBackspace.TabIndex = 16;
            this.btnBackspace.Text = "⌫";
            // 
            // btnC
            // 
            this.btnC.BorderRadius = 6;
            this.btnC.CheckedState.Parent = this.btnC;
            this.btnC.CustomImages.Parent = this.btnC;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.HoverState.Parent = this.btnC;
            this.btnC.Location = new System.Drawing.Point(13, 143);
            this.btnC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnC.Name = "btnC";
            this.btnC.ShadowDecoration.Parent = this.btnC;
            this.btnC.Size = new System.Drawing.Size(71, 51);
            this.btnC.TabIndex = 21;
            this.btnC.Text = "C";
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 452);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubs);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtDisplay;
        private Guna.UI2.WinForms.Guna2Button btn1;
        private Guna.UI2.WinForms.Guna2Button btn4;
        private Guna.UI2.WinForms.Guna2Button btn7;
        private Guna.UI2.WinForms.Guna2Button btn9;
        private Guna.UI2.WinForms.Guna2Button btn6;
        private Guna.UI2.WinForms.Guna2Button btn3;
        private Guna.UI2.WinForms.Guna2Button btn8;
        private Guna.UI2.WinForms.Guna2Button btn5;
        private Guna.UI2.WinForms.Guna2Button btn2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnDot;
        private Guna.UI2.WinForms.Guna2Button btnEqual;
        private Guna.UI2.WinForms.Guna2Button btn0;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnSubs;
        private Guna.UI2.WinForms.Guna2Button btnMulti;
        private Guna.UI2.WinForms.Guna2Button btnDivision;
        private Guna.UI2.WinForms.Guna2Button btnBackspace;
        private Guna.UI2.WinForms.Guna2Button btnC;
    }
}

