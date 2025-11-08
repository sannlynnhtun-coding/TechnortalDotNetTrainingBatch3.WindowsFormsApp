namespace TechnortalDotNetTrainingBatch3.WindowsFormsApp
{
    partial class FrmProduct
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
            txtProductName = new TextBox();
            textBox2 = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(96, 40);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(451, 31);
            txtProductName.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(96, 163);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(451, 31);
            txtQuantity.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(96, 101);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(451, 31);
            txtPrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 4;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 5;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 135);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 6;
            label3.Text = "Quantity";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(96, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 386);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(textBox2);
            Controls.Add(txtProductName);
            Name = "FrmProduct";
            Text = "FrmProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private TextBox textBox2;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
    }
}