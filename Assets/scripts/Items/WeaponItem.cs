public abstract class WeaponItem : Item
{
	protected int damage;
	
	public WeaponItem(int damage) 
	{
		this.damage = damage;
	}
	
	public int getDamage() 
	{
		return damage;
	}
}