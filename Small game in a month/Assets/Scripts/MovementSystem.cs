using UnityEngine;

public class MovementSystem : MonoBehaviour
{
	[Header("Refrences")]
	[SerializeField] private Rigidbody2D rb;

	[Header("Stats")]
	[SerializeField] private float movement_speed = 100f;
	[SerializeField] private float jump_force = 100f;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		if(Input.GetKey(KeyCode.D))
		{
			rb.velocity = new Vector2(movement_speed * Time.deltaTime, rb.velocity.y);
		} if(Input.GetKey(KeyCode.A))
		{
			rb.velocity = new Vector2(-movement_speed * Time.deltaTime, rb.velocity.y);
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			rb.velocity = new Vector2(rb.velocity.x, jump_force);
		}
	}
}
