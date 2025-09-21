using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0f;
    [SerializeField] float regularSpeed = 5f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] private GameObject textUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveSpeed = regularSpeed;
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
            moveSpeed = boostSpeed;
            textUI.SetActive(true);
            Destroy(collision.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = regularSpeed;
        textUI.SetActive(false);
    }
    void Update()
    {


        float steer = 0f;
        float move = 0f;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;

        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;

        }

        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }





        float steerAmount = steer * steerSpeed * Time.deltaTime;
        transform.Translate(0, move * moveSpeed * Time.deltaTime, 0);
        transform.Rotate(0, 0, steerAmount);


    }
}
