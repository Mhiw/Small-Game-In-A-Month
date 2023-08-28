using UnityEngine;

public class MovementSystem : MonoBehaviour
{
	[Header("Refrences")]
	[SerializeField] private Rigidbody2D rb;

	[Header("Stats")]
	[SerializeField] private float movement_speed = 100f;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		if(Input.GetKey(KeyCode.D))
		{
			rb.velocity = new Vector2(movement_speed * Time.deltaTime, 0);
		} if(Input.GetKey(KeyCode.A))
		{
			rb.velocity = new Vector2(-movement_speed * Time.deltaTime, 0);
		}
	}
