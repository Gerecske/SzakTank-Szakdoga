namespace SzakTank2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunCode(object sender, EventArgs e)
        {
            if (textBox_Code.Text != null)
            {
                List<Command> commands = new List<Command>();
                string code = textBox_Code.Text;
                string[] lines = code.Split(';');
                for (int i = 0; i < lines.Length-1; i++)
                {
                    commands.Add(new Command()
                    {
                        CommandName = lines[i].Substring(0, lines[i].IndexOf('(')),
                        CommandValue = Convert.ToInt32(lines[i].Substring(lines[i].IndexOf('(') + 1, lines[i].IndexOf(')') - lines[i].IndexOf('(') - 1))
                    });
                }
                string err = "";
                foreach (var com in commands)
                {
                    err += com.CommandName + " " + com.CommandValue;
                }
                label_Error.Text = err;
            }
        }
    }
}