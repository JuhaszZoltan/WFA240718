namespace WFA240718
{
    public partial class FrmHelloWorld : Form
    {
        public FrmHelloWorld()
        {
            InitializeComponent();
            tbName.TextChanged += TbName_TextChanged;
            btnHello.Click += BtnHello_Click;
        }

        private void TbName_TextChanged(object? sender, EventArgs e)
        {
            string rawText = tbName.Text.Trim();
            btnHello.Enabled = rawText.Length >= 3;
        }

        private void BtnHello_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                caption: "ÜDVÖZLÉS",
                text: $"Hello {tbName.Text}! Bezárod az alkalmazást?",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Information);

            if (result == DialogResult.Yes) Application.Exit();
        }
    }
}
