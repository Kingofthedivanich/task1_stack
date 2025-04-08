namespace task1_stack.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox inputTextBox;
        private Button pushButton;
        private Button popButton;
        private Button clearButton;
        private ListBox listBox;
        private Label currentText;
        private Label currentLabel;
        private Label countText;
        private Label countLabel;
        private Label isEmptyText;
        private Label isEmptyLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            pushButton = new Button();
            popButton = new Button();
            clearButton = new Button();
            listBox = new ListBox();
            currentText = new Label();
            currentLabel = new Label();
            countText = new Label();
            countLabel = new Label();
            isEmptyText = new Label();
            isEmptyLabel = new Label();

            SuspendLayout();

            // inputTextBox
            inputTextBox.Location = new System.Drawing.Point(12, 12);
            inputTextBox.Size = new System.Drawing.Size(260, 23);

            // pushButton
            pushButton.Location = new System.Drawing.Point(12, 45);
            pushButton.Size = new System.Drawing.Size(75, 23);
            pushButton.Text = "Push";
            pushButton.Click += pushButton_Click;

            // popButton
            popButton.Location = new System.Drawing.Point(105, 45);
            popButton.Size = new System.Drawing.Size(75, 23);
            popButton.Text = "Pop";
            popButton.Click += popButton_Click;

            // clearButton
            clearButton.Location = new System.Drawing.Point(197, 45);
            clearButton.Size = new System.Drawing.Size(75, 23);
            clearButton.Text = "Clear";
            clearButton.Click += clearButton_Click;

            // listBox
            listBox.Location = new System.Drawing.Point(12, 80);
            listBox.Size = new System.Drawing.Size(260, 120);

            // currentText
            currentText.Location = new System.Drawing.Point(12, 210);
            currentText.Size = new System.Drawing.Size(100, 15);
            currentText.Text = "Текущий элемент:";

            // currentLabel
            currentLabel.Location = new System.Drawing.Point(120, 210);
            currentLabel.Size = new System.Drawing.Size(150, 15);

            // countText
            countText.Location = new System.Drawing.Point(12, 230);
            countText.Size = new System.Drawing.Size(100, 15);
            countText.Text = "Количество:";

            // countLabel
            countLabel.Location = new System.Drawing.Point(120, 230);
            countLabel.Size = new System.Drawing.Size(150, 15);

            // isEmptyText
            isEmptyText.Location = new System.Drawing.Point(12, 250);
            isEmptyText.Size = new System.Drawing.Size(100, 15);
            isEmptyText.Text = "Пуст ли стек:";

            // isEmptyLabel
            isEmptyLabel.Location = new System.Drawing.Point(120, 250);
            isEmptyLabel.Size = new System.Drawing.Size(150, 15);

            // MainForm
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            ClientSize = new System.Drawing.Size(300, 350);
            Controls.Add(inputTextBox);
            Controls.Add(pushButton);
            Controls.Add(popButton);
            Controls.Add(clearButton);
            Controls.Add(listBox);
            Controls.Add(currentText);
            Controls.Add(currentLabel);
            Controls.Add(countText);
            Controls.Add(countLabel);
            Controls.Add(isEmptyText);
            Controls.Add(isEmptyLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Text = "Стек";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
