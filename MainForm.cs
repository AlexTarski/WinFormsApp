namespace WinFormsApp1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            ClientSize = new Size(400, 400);

            var label = new Label
            {
                Text = "Input number",
                Dock = DockStyle.Fill,
            };

            var input = new TextBox
            {
                SelectedText = "0",
                Dock = DockStyle.Fill,
            };

            var button = new Button
            {
                Text = "Increment!!!",
                Dock = DockStyle.Fill,
            };

            var buttonMagic = new Button
            {
                Text = "!!!Do Magic!!!",
                Dock = DockStyle.Fill,
            };

            var output = new TextBox
            {
                Dock = DockStyle.Fill,
                PlaceholderText = "Result",
                ForeColor = Color.Green,
            };

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
            };

            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));


            table.Controls.Add(new Panel(), 1, 0);
            table.Controls.Add(label, 1, 1);
            table.Controls.Add(input, 1, 2);
            table.Controls.Add(button, 1, 3);
            table.Controls.Add(output, 1, 4);
            table.Controls.Add(buttonMagic, 2, 5);
            table.Controls.Add(new Panel(), 0, 6);

            Controls.Add(table);

            button.Click += (sender, args) =>
            {
                var num = int.Parse(input.Text);
                num++;
                output.Text = num.ToString();
            };

            buttonMagic.Click += (sender, args) =>
            {
                Animation animation = new();
                animation.ShowDialog();
            };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you wish to close this window?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
