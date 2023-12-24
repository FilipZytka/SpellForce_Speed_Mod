using System.Diagnostics;


namespace SpellForce_Speed_Mod_WinForms
{
    public class ProcessChecker
    {
        public bool IsGameRunning { get; set; } = false;

        public bool CheckProcess()
        {
            try
            {
                Process[] pname = Process.GetProcessesByName("SpellForce");
                if (pname.Length == 0)
                {
                    IsGameRunning = false;
                    return false;
                }
                else
                {
                    IsGameRunning = true;
                    GameInstance gameInstance = new GameInstance();

                    return true;
                }
            }
            catch
            {
                return false;

            }
        }
    }

}
