using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag_pickup : MonoBehaviour
{
    [SerializeField] GameObject Flag;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Flag was picked up");
            Destroy(Flag);
        }
    }
}
