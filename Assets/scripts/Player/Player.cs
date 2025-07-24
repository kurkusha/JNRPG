using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float movingspeed = 5f;  

    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
     
    private void FixedUpdate()
    {
        Vector2 inputVector = GameInput.Instance.GetMovementVector();
        inputVector = inputVector.normalized;
        rb.MovePosition(rb.position + inputVector * (movingspeed * Time.fixedDeltaTime));
    }

    int armor;
	
	public List<Item> inventory = new List<Item>(10);

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
