using System;
using System.Linq;
using System.Windows.Forms;
using task1_stack.Models;

namespace task1_stack.Forms
{
    public partial class MainForm : Form
    {
        private readonly StackModel<string> _stack;

        public MainForm()
        {
            InitializeComponent();
            _stack = new StackModel<string>();
            UpdateUI();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                _stack.Push(inputTextBox.Text);
                inputTextBox.Clear();
                UpdateUI();
            }
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            _stack.Pop();
            UpdateUI();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _stack.Clear();
            UpdateUI();
        }

        private void UpdateUI()
        {
            listBox.Items.Clear();
            foreach (var item in _stack.GetAll())
            {
                listBox.Items.Add(item);
            }

            currentLabel.Text = _stack.Current ?? "—";
            countLabel.Text = _stack.Count.ToString();
            isEmptyLabel.Text = _stack.IsEmpty ? "Да" : "Нет";
        }
    }
}