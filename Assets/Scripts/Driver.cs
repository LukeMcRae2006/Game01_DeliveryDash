using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0f;
    float maxSpeed = 80f;
    float minSpeed = 10f;
    float lastMovDir = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveSpeed = minSpeed;
    }

    // Update is called once per frame
    void Update()
    {


        float steer = 0f;
        float move = 0f;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
            lastMovDir = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
            lastMovDir = -1f;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }


        if (move != 0)
        {
            if (moveSpeed < maxSpeed)
            {
                moveSpeed += Time.deltaTime * 15f;
            }

        }
        else
        {
            if (moveSpeed > minSpeed)
            {
                moveSpeed -= Time.deltaTime * 30f;
            }
        }
        float moveAmount;


        if (moveSpeed > minSpeed && move == 0)
        {

            moveAmount = moveSpeed * lastMovDir * Time.deltaTime;
        }
        else
        {
            moveAmount = move * moveSpeed * Time.deltaTime;
        }


        float steerAmount = steer * steerSpeed * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        if (moveSpeed > minSpeed)
        {
            transform.Rotate(0, 0, steerAmount);
        }

    }
}
