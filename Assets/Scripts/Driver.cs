using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("We are pushing forward");
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("We are pushing downard");
        }

        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("We are pushing left");
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("We are pushing right");
        }
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
