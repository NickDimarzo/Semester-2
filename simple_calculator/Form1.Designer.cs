namespace simple_calculator
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
            num_1 = new TextBox();
            result = new TextBox();
            num_2 = new TextBox();
            add_op = new Button();
            result_op = new Button();
            div_op = new Button();
            mul_op = new Button();
            sub_op = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // num_1
            // 
            num_1.Location = new Point(117, 6);
            num_1.Margin = new Padding(3, 4, 3, 4);
            num_1.Name = "num_1";
            num_1.Size = new Size(59, 25);
            num_1.TabIndex = 0;
            num_1.TextAlign = HorizontalAlignment.Center;
            // 
            // result
            // 
            result.Location = new Point(119, 208);
            result.Margin = new Padding(3, 4, 3, 4);
            result.Name = "result";
            result.Size = new Size(60, 25);
            result.TabIndex = 1;
            result.TextAlign = HorizontalAlignment.Center;
            // 
            // num_2
            // 
            num_2.Location = new Point(117, 131);
            num_2.Margin = new Padding(3, 4, 3, 4);
            num_2.Name = "num_2";
            num_2.Size = new Size(60, 25);
            num_2.TabIndex = 2;
            num_2.TextAlign = HorizontalAlignment.Center;
            // 
            // add_op
            // 
            add_op.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            add_op.Location = new Point(52, 83);
            add_op.Margin = new Padding(3, 4, 3, 4);
            add_op.Name = "add_op";
            add_op.Size = new Size(61, 36);
            add_op.TabIndex = 3;
            add_op.Text = "+";
            add_op.UseVisualStyleBackColor = true;
            add_op.Click += add_op_Click;
            // 
            // result_op
            // 
            result_op.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            result_op.Location = new Point(117, 164);
            result_op.Margin = new Padding(3, 4, 3, 4);
            result_op.Name = "result_op";
            result_op.Size = new Size(60, 36);
            result_op.TabIndex = 4;
            result_op.Text = "=";
            result_op.UseVisualStyleBackColor = true;
            result_op.Click += result_op_Click;
            // 
            // div_op
            // 
            div_op.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            div_op.Location = new Point(115, 39);
            div_op.Margin = new Padding(3, 4, 3, 4);
            div_op.Name = "div_op";
            div_op.Size = new Size(61, 36);
            div_op.TabIndex = 5;
            div_op.Text = "/";
            div_op.UseVisualStyleBackColor = true;
            div_op.Click += div_op_Click;
            // 
            // mul_op
            // 
            mul_op.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mul_op.Location = new Point(50, 39);
            mul_op.Margin = new Padding(3, 4, 3, 4);
            mul_op.Name = "mul_op";
            mul_op.Size = new Size(61, 36);
            mul_op.TabIndex = 6;
            mul_op.Text = "*";
            mul_op.UseVisualStyleBackColor = true;
            mul_op.Click += mul_op_Click;
            // 
            // sub_op
            // 
            sub_op.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sub_op.Location = new Point(115, 83);
            sub_op.Margin = new Padding(3, 4, 3, 4);
            sub_op.Name = "sub_op";
            sub_op.Size = new Size(61, 36);
            sub_op.TabIndex = 7;
            sub_op.Text = "-";
            sub_op.UseVisualStyleBackColor = true;
            sub_op.Click += sub_op_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 8;
            label1.Text = "number 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 131);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 9;
            label2.Text = "number 2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 208);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 10;
            label3.Text = "result";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(193, 248);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sub_op);
            Controls.Add(mul_op);
            Controls.Add(div_op);
            Controls.Add(result_op);
            Controls.Add(add_op);
            Controls.Add(num_2);
            Controls.Add(result);
            Controls.Add(num_1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num_1;
        private TextBox result;
        private TextBox num_2;
        private Button add_op;
        private Button result_op;
        private Button div_op;
        private Button mul_op;
        private Button sub_op;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}