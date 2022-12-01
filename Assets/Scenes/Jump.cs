using UnityEngine;

public class Jump : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //Debug.Log("jump");
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
    }
}
