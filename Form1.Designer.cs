namespace Restaurant
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
            groupBox1 = new GroupBox();
            ChickenRadio = new RadioButton();
            EggRadio = new RadioButton();
            label1 = new Label();
            amountQuantity = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            showEggQuality = new Label();
            button3 = new Button();
            label4 = new Label();
            listResults = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChickenRadio);
            groupBox1.Controls.Add(EggRadio);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(34, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // ChickenRadio
            // 
            ChickenRadio.AutoSize = true;
            ChickenRadio.Location = new Point(36, 83);
            ChickenRadio.Name = "ChickenRadio";
            ChickenRadio.Size = new Size(136, 42);
            ChickenRadio.TabIndex = 2;
            ChickenRadio.TabStop = true;
            ChickenRadio.Text = "Chicken";
            ChickenRadio.UseVisualStyleBackColor = true;
            // 
            // EggRadio
            // 
            EggRadio.AutoSize = true;
            EggRadio.Location = new Point(36, 36);
            EggRadio.Name = "EggRadio";
            EggRadio.Size = new Size(84, 42);
            EggRadio.TabIndex = 1;
            EggRadio.TabStop = true;
            EggRadio.Text = "Egg";
            EggRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(34, 192);
            label1.Name = "label1";
            label1.Size = new Size(145, 38);
            label1.TabIndex = 1;
            label1.Text = "Quantity : ";
            // 
            // amountQuantity
            // 
            amountQuantity.Location = new Point(185, 203);
            amountQuantity.Name = "amountQuantity";
            amountQuantity.Size = new Size(161, 27);
            amountQuantity.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(365, 201);
            button1.Name = "button1";
            button1.Size = new Size(286, 38);
            button1.TabIndex = 3;
            button1.Text = "Submit new request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(70, 267);
            button2.Name = "button2";
            button2.Size = new Size(538, 38);
            button2.TabIndex = 4;
            button2.Text = "Copy the previous request";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(431, 57);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 5;
            label2.Text = "Egg Quality";
            // 
            // showEggQuality
            // 
            showEggQuality.AutoSize = true;
            showEggQuality.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            showEggQuality.Location = new Point(570, 57);
            showEggQuality.Name = "showEggQuality";
            showEggQuality.Size = new Size(26, 31);
            showEggQuality.TabIndex = 6;
            showEggQuality.Text = "0";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(70, 323);
            button3.Name = "button3";
            button3.Size = new Size(538, 38);
            button3.TabIndex = 7;
            button3.Text = "Prepare Food";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(25, 375);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 8;
            label4.Text = "Results";
            // 
            // listResults
            // 
            listResults.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listResults.Location = new Point(34, 433);
            listResults.Multiline = true;
            listResults.Name = "listResults";
            listResults.Size = new Size(574, 168);
            listResults.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 613);
            Controls.Add(listResults);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(showEggQuality);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(amountQuantity);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Restaurant";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton ChickenRadio;
        private RadioButton EggRadio;
        private Label label1;
        private TextBox amountQuantity;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label showEggQuality;
        private Button button3;
        private Label label4;
        private TextBox listResults;
    }
}
