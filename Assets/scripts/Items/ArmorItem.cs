using UnityEngine;

public abstract class ArmorItem : Item
{
	protected int armor = 0;
	
	public ArmorItem(int armor) 
	{
		this.armor = armor;
	}
	
	public void equip(Player player) 
	{
		player.setArmor(armor);
	}
	
	public void unequip(Player player)
	{
		player.setArmor(player.getArmor() - this.armor);
	}
}