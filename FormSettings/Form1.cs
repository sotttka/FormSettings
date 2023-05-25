namespace FormSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetColorsToFormColorComboBox();
            SetColorsToForegroundColorComboBox();
        }

        private void SetColorsToFormColorComboBox()
        {
            foreach (KnownColor color in GetKnownColors())
                _selectFormColorComboBox.Items.Add(color);
        }

        private void SetColorsToForegroundColorComboBox()
        {
            foreach (KnownColor color in GetKnownColors())
                _selectForegroundColorComboBox.Items.Add(color);
        }

        private KnownColor[] GetKnownColors()
        {
            return (KnownColor[])Enum.GetValues(typeof(KnownColor));
        }

        private void _selectFormColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.FromKnownColor((KnownColor)_selectFormColorComboBox.Items[_selectFormColorComboBox.SelectedIndex]);
            BackColor = color;
        }

        private void _selectForegroundColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.FromKnownColor((KnownColor)_selectForegroundColorComboBox.Items[_selectForegroundColorComboBox.SelectedIndex]);
            label1.ForeColor = color;
            label2.ForeColor = color;
        }
    }
}