using Gma.System.MouseKeyHook;

namespace SpellForce_Speed_Mod_WinForms
{
    public class KeyHooks
    {
        private IKeyboardMouseEvents? m_GlobalHook;

        GameSpeedModifier gameSpeedModifier = new GameSpeedModifier();
        GameSpeedValues gameSpeedValues = new GameSpeedValues();

        public void Subscribe()
        {
            if (m_GlobalHook == null)
            {
                m_GlobalHook = Hook.GlobalEvents();
                m_GlobalHook.KeyPress += ChooseKeyHook;
            }

        }
        public void Unsubscribe()
        {
            if (m_GlobalHook != null)
            {
                m_GlobalHook.KeyPress -= ChooseKeyHook;
                m_GlobalHook.Dispose();
                m_GlobalHook = null;
            }

        }
        private void ChooseKeyHook(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'H':
                    gameSpeedModifier.SetGameSpeed(gameSpeedValues.Pause);
                    break;
                case 'h':
                    gameSpeedModifier.SetGameSpeed(gameSpeedValues.Pause);
                    break;
                case ',':
                    gameSpeedModifier.SetGameSpeed(gameSpeedValues.Speed_x1);
                    break;
                case '.':
                    gameSpeedModifier.SetGameSpeed(gameSpeedValues.Speed_x2);
                    break;
                case '/':
                    gameSpeedModifier.SetGameSpeed(gameSpeedValues.Speed_x5);
                    break;
                case ';':
                    gameSpeedModifier.SetGameSpeed(gameSpeedValues.Speed_x10);
                    break;
            }
        }
    }
}
