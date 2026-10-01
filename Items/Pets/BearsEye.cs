using Primrose.Buffs.Pets;
using Primrose.Projectiles.Pets;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Primrose.Items.Pets
{
    [LegacyName("BearEye")]
    public class BearsEye : ModItem
    {

        public override void SetDefaults()
        {
            Item.DefaultToVanitypet(ModContent.ProjectileType<Bear>(), ModContent.BuffType<BearBuff>());
            Item.UseSound = SoundID.Meowmere;
            Item.value = Item.buyPrice(platinum: 5);
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
