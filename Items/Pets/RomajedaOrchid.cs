using Primrose.Buffs.Pets;
using Primrose.Projectiles.Pets;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Primrose.Items.Pets
{
    public class RomajedaOrchid : ModItem
    {
        public override void SetDefaults()
        {
            Item.DefaultToVanitypet(ModContent.ProjectileType<KendraPet>(), ModContent.BuffType<Kendra>());
            Item.UseSound = SoundID.Item44;
            Item.value = Item.buyPrice(gold: 40);
            Item.rare = ItemRarityID.Pink;
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(Item.buffType, 15, true);
            }
        }
    }
}
