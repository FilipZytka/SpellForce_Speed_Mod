namespace SpellForce_Speed_Mod_WinForms
{
    public partial class MainForm : Form
    {
        GameSpeedModifier gameSpeedModifier = new GameSpeedModifier();
        GameSpeedValues gameSpeedValues = new GameSpeedValues();
        ProcessChecker processChecker = new ProcessChecker();
        KeyHooks keyHooks = new KeyHooks();
        public MainForm()
        {

            InitializeComponent();
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            if (processChecker.IsGameRunning == true)
            {
                gameSpeedModifier.SetGameSpeed(gameSpeedValues.Pause);
            }
        }

        private void button_speed_x1_Click(object sender, EventArgs e)
        {
            if (processChecker.IsGameRunning == true)
            {

                gameSpeedModifier.SetGameSpeed(gameSpeedValues.Speed_x1);
            }
        }

        private void button_speed_x2_Click(object sender, EventArgs e)
        {
            if (processChecker.IsGameRunning == true)
            {
                gameSpeedModifier.SetGameSpeed(gameSpeedValues.Speed_x2);
            }
        }

        private void button_speed_x5_Click(object sender, EventArgs e)
        {
            if (processChecker.IsGameRunning == true)
            {
                gameSpeedModifier.SetGameSpeed(gameSpeedValues.Speed_x5);
            }
        }
        private void button_speed_x10_Click(object sender, EventArgs e)
        {
            if (processChecker.IsGameRunning == true)
            {
                gameSpeedModifier.SetGameSpeed(gameSpeedValues.Speed_x10);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (processChecker.CheckProcess() == true)
            {
                keyHooks.Subscribe();
            }
            else
            {
                keyHooks.Unsubscribe();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
