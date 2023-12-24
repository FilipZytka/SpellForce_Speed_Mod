namespace SpellForce_Speed_Mod_WinForms
{
    public class GameSpeedModifier
    {

        private GameInstance _gameInstance = new GameInstance();

        public void SetGameSpeed(string gameSpeedValue)
        {
            _gameInstance.Configure();

            _gameInstance.swed.WriteBytes(_gameInstance.moduleCollection.BaseModule + _gameInstance.moduleCollection.SpeedOffset, gameSpeedValue);

        }

    }
}
