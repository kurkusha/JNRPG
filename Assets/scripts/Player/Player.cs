using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
	int armor;
	
	public List<Item> inventory = new List<Item>(10);

	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	
	public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public void UseItem(int index)
    {
        inventory[index].Use(this);
        inventory.RemoveAt(index);
    }
	
	public void setArmor(int armor) 
	{
		this.armor = armor;
	}
	
	public int getArmor() 
	{
		return this.armor;
	}
}
