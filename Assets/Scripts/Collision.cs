using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What the heck was that!");
    }
}
