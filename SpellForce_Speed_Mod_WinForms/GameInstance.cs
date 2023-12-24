using Swed32;

namespace SpellForce_Speed_Mod_WinForms
{
    public class GameInstance
    {
        public Swed swed;
        public ModuleCollection moduleCollection;

        public void Configure()
        {
            swed = new Swed("SpellForce");
            moduleCollection = new ModuleCollection();

            moduleCollection.BaseModule = swed.GetModuleBase("Spellforce.exe");
        }

    }
}
