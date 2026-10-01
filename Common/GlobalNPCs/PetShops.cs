using Primrose.Items.Pets;
using Terraria.ID;
using Terraria.ModLoader;

namespace Primrose.Common.GlobalNPCs
{
    // the most powerful of the egypt 9!
    public class PetShops : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            if (shop.NpcType == NPCID.Dryad)
                shop.Add<RomajedaOrchid>();

            if (shop.NpcType == NPCID.BestiaryGirl)
                shop.Add<BearsEye>();
        }
    }
}
