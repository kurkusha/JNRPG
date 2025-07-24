using UnityEngine;

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

    


}
