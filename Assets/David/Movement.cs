using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;
    public float jumpHeight = 10f; // Adjust this value to control movement speed

    // Update is called once per frame
    void Update()
    {
        // Check if the Right Arrow key is pressed
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Move the object to the right along the X-axis
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        // Check if the Right Arrow key is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Move the object to the left along the X-axis
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Move the object forward along the Y-axis
            transform.Translate(Vector3.up * jumpHeight * Time.deltaTime);
        }
    }

    void Rotate()
    {
        // if (this.transform.rotation)
        // {
            
        // }
    }
}
