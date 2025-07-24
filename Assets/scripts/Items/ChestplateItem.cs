public abstract class ChestplateItem : ArmorItem
{
	public ChestplateItem(int armor) : base(armor) 
	{
	}
	
	public override void Use(Player player)
	{
		player.BroadcastMessage("");
	}
}