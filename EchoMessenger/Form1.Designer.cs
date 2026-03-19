namespace EchoMessenger
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            myTextBox = new TextBox();
            sendButton = new Button();
            myListBox = new ListBox();
            countLabel = new Label();
            deleteButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 225);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "echo messenger";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 253);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 280);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 284);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // myTextBox
            // 
            myTextBox.Location = new Point(336, 144);
            myTextBox.Name = "myTextBox";
            myTextBox.Size = new Size(100, 23);
            myTextBox.TabIndex = 4;
            myTextBox.TextChanged += myTextBox_TextChanged;
            myTextBox.KeyDown += myTextBox_KeyDown;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(292, 79);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 5;
            sendButton.Text = "전송";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // myListBox
            // 
            myListBox.FormattingEnabled = true;
            myListBox.Location = new Point(157, 134);
            myListBox.Name = "myListBox";
            myListBox.Size = new Size(89, 49);
            myListBox.TabIndex = 6;
            myListBox.SelectedIndexChanged += myListBox_SelectedIndexChanged;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(181, 201);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(39, 15);
            countLabel.TabIndex = 7;
            countLabel.Text = "label5";
            countLabel.Click += label5_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(431, 221);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 8;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(534, 221);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 9;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(countLabel);
            Controls.Add(myListBox);
            Controls.Add(sendButton);
            Controls.Add(myTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox myTextBox;
        private Button sendButton;
        private ListBox myListBox;
        private Label countLabel;
        private Button deleteButton;
        private Button clearButton;
    }
}
