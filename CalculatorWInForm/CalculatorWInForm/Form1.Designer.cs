namespace CalculatorWInForm
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
            panel1 = new Panel();
            textHistory = new Label();
            panel2 = new Panel();
            textResult = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textHistory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 59);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textHistory
            // 
            textHistory.AutoSize = true;
            textHistory.Dock = DockStyle.Right;
            textHistory.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textHistory.Location = new Point(334, 0);
            textHistory.Name = "textHistory";
            textHistory.Size = new Size(0, 45);
            textHistory.TabIndex = 0;
            textHistory.Click += textHistory_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textResult);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 62);
            panel2.TabIndex = 1;
            // 
            // textResult
            // 
            textResult.AutoSize = true;
            textResult.Dock = DockStyle.Right;
            textResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textResult.Location = new Point(334, 0);
            textResult.Name = "textResult";
            textResult.Size = new Size(0, 45);
            textResult.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 374);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 2;
            button1.Text = "+/-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNumberClick;
            // 
            // button2
            // 
            button2.Location = new Point(68, 374);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 3;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNumberClick;
            // 
            // button3
            // 
            button3.Location = new Point(124, 374);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 4;
            button3.Text = ",";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNumberClick;
            // 
            // button4
            // 
            button4.Location = new Point(180, 374);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 5;
            button4.Text = "=";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonResultClick;
            // 
            // button5
            // 
            button5.Location = new Point(236, 374);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 6;
            button5.Text = "SQRT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonOperationClick;
            // 
            // button6
            // 
            button6.Location = new Point(12, 318);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 7;
            button6.Text = "1";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNumberClick;
            // 
            // button7
            // 
            button7.Location = new Point(68, 318);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 8;
            button7.Text = "2";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNumberClick;
            // 
            // button8
            // 
            button8.Location = new Point(124, 318);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 9;
            button8.Text = "3";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonNumberClick;
            // 
            // button9
            // 
            button9.Location = new Point(180, 318);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 10;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonOperationClick;
            // 
            // button10
            // 
            button10.Location = new Point(124, 206);
            button10.Name = "button10";
            button10.Size = new Size(50, 50);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonNumberClick;
            // 
            // button11
            // 
            button11.Location = new Point(12, 262);
            button11.Name = "button11";
            button11.Size = new Size(50, 50);
            button11.TabIndex = 12;
            button11.Text = "4";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonNumberClick;
            // 
            // button12
            // 
            button12.Location = new Point(68, 262);
            button12.Name = "button12";
            button12.Size = new Size(50, 50);
            button12.TabIndex = 13;
            button12.Text = "5";
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonNumberClick;
            // 
            // button13
            // 
            button13.Location = new Point(124, 262);
            button13.Name = "button13";
            button13.Size = new Size(50, 50);
            button13.TabIndex = 14;
            button13.Text = "6";
            button13.UseVisualStyleBackColor = true;
            button13.Click += buttonNumberClick;
            // 
            // button14
            // 
            button14.Location = new Point(180, 262);
            button14.Name = "button14";
            button14.Size = new Size(50, 50);
            button14.TabIndex = 15;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += buttonOperationClick;
            // 
            // button15
            // 
            button15.Location = new Point(68, 206);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 16;
            button15.Text = "8";
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonNumberClick;
            // 
            // button16
            // 
            button16.Location = new Point(236, 206);
            button16.Name = "button16";
            button16.Size = new Size(50, 50);
            button16.TabIndex = 17;
            button16.Text = "1/X";
            button16.UseVisualStyleBackColor = true;
            button16.Click += buttonOperationClick;
            // 
            // button17
            // 
            button17.Location = new Point(236, 262);
            button17.Name = "button17";
            button17.Size = new Size(50, 50);
            button17.TabIndex = 18;
            button17.Text = "x^2";
            button17.UseVisualStyleBackColor = true;
            button17.Click += buttonOperationClick;
            // 
            // button18
            // 
            button18.Location = new Point(180, 150);
            button18.Name = "button18";
            button18.Size = new Size(50, 50);
            button18.TabIndex = 19;
            button18.Text = "*";
            button18.UseVisualStyleBackColor = true;
            button18.Click += buttonOperationClick;
            // 
            // button19
            // 
            button19.Location = new Point(180, 206);
            button19.Name = "button19";
            button19.Size = new Size(50, 50);
            button19.TabIndex = 20;
            button19.Text = "/";
            button19.UseVisualStyleBackColor = true;
            button19.Click += buttonOperationClick;
            // 
            // button20
            // 
            button20.Location = new Point(12, 206);
            button20.Name = "button20";
            button20.Size = new Size(50, 50);
            button20.TabIndex = 21;
            button20.Text = "7";
            button20.UseVisualStyleBackColor = true;
            button20.Click += buttonNumberClick;
            // 
            // button21
            // 
            button21.Location = new Point(12, 150);
            button21.Name = "button21";
            button21.Size = new Size(50, 50);
            button21.TabIndex = 22;
            button21.Text = "%";
            button21.UseVisualStyleBackColor = true;
            button21.Click += buttonOperationClick;
            // 
            // button22
            // 
            button22.Location = new Point(68, 150);
            button22.Name = "button22";
            button22.Size = new Size(50, 50);
            button22.TabIndex = 23;
            button22.Text = "CE";
            button22.UseVisualStyleBackColor = true;
            button22.Click += buttonClear;
            // 
            // button23
            // 
            button23.Location = new Point(124, 150);
            button23.Name = "button23";
            button23.Size = new Size(50, 50);
            button23.TabIndex = 24;
            button23.Text = "C";
            button23.UseVisualStyleBackColor = true;
            button23.Click += buttonClear;
            // 
            // button24
            // 
            button24.Location = new Point(236, 150);
            button24.Name = "button24";
            button24.Size = new Size(50, 50);
            button24.TabIndex = 25;
            button24.Text = "<-";
            button24.UseVisualStyleBackColor = true;
            button24.Click += buttonResetNumber;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 450);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(350, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Click += buttonNumberClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label textHistory;
        private Panel panel2;
        private Label textResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
    }
}