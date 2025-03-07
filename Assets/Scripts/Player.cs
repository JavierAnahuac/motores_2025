using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public float maxAcceleration = 3f;
    public float accelerationRate = 0.025f;
    public float decelerationRate = 0.05f;

    private float acceleration = 1f;

    void Update()
    {
        Debug.Log("1234512345");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            acceleration += accelerationRate;
            if (acceleration >= maxAcceleration)
            {
                acceleration = maxAcceleration;
            }
        }
        else
        {
            acceleration -= decelerationRate;
            if (acceleration < 1f)
            {
                acceleration = 1f;
            }
        }

        float finalSpeed = (speed * acceleration) * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(finalSpeed, 0f, 0f);
        }
    }
}