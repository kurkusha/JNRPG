public abstract class BootsItem : ArmorItem
{
	public BootsItem(int armor) : base(armor) 
	{
	}
	
	public override void Use(Player player)
	{
		player.BroadcastMessage("");
	}
}