using ModLoader;

namespace SaveManager
{
    public class Main : Mod
    {

        public override string ModNameID => "SaveManager";
        public override string DisplayName => "Save Manager";
        public override string Author => "NeptuneSky";
        public override string MinimumGameVersionNecessary => "1.5.9.8";
        public override string ModVersion => "v1.0.0";
        public override string Description => "Import and export save files from right inside the game.";

        public override void Load()
        {
        }

        public override void Early_Load()
        {
        }
    }
}