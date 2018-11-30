namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{

		}

		private void TextBox_Enter(object sender, System.EventArgs e)
		{
			// کادرمحاوره‌ای جاری که وارد آن شده‌ایم
			System.Windows.Forms.TextBox
				currentTextBox = sender as System.Windows.Forms.TextBox;

			if (currentTextBox != null)
			{
				currentTextBox.Font =
					new System.Drawing.Font(currentTextBox.Font, System.Drawing.FontStyle.Bold);
			}
		}

		private void TextBox_Leave(object sender, System.EventArgs e)
		{
			// کادر محاوره‌ای جاری که از آن خارج شده‌ایم
			System.Windows.Forms.TextBox
				currentTextBox = sender as System.Windows.Forms.TextBox;

			if (currentTextBox != null)
			{
				currentTextBox.Font =
					new System.Drawing.Font(currentTextBox.Font, System.Drawing.FontStyle.Regular);
			}
		}
	}
}
