using Terraria.ModLoader;

namespace Primrose.Common.Players
{
    public class PetPlayer : ModPlayer
    {
        public bool Kendra;
        public bool Bear;

        public override void ResetEffects()
        {
            Kendra = false;
            Bear = false;
        }

        public override void UpdateDead()
        {
            ResetEffects();
        }
    }
}
