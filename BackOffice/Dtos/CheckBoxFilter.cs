namespace BackOffice.Dtos
{
    public class CheckBoxFilter
    {
        public string Label { get; set; }
        public bool Checked { get; set; }

        public CheckBoxFilter(string label , bool @checked)
        {
            Label = label;
            Checked = @checked;

        }
    }
}