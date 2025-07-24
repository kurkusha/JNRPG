public abstract class HelmetItem : ArmorItem
{
	public HelmetItem(int armor) : base(armor) 
	{
	}
	
	public override void Use(Player player)
	{
		player.BroadcastMessage("");
	}
}