using UnityEngine;

public abstract class Item
{
	public string itemName;
	public Sprite icon;

	public abstract void Use(Player player);
}
