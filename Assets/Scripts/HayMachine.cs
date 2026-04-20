using UnityEngine;

public class HayMachine : MonoBehaviour
{
    public float movementSpeed = 50; 
    public float horizontalBoundary = 22; 

    void Update()
    {
        UpdateMovement(); 
    }

    private void UpdateMovement() 
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); 

        if (horizontalInput < 0 && transform.position.x > -horizontalBoundary) 
        {
            transform.Translate(transform.right * -movementSpeed * Time.deltaTime); 
        }
        else if (horizontalInput > 0 && transform.position.x < horizontalBoundary) 
        {
            transform.Translate(transform.right * movementSpeed * Time.deltaTime); 
        }
    }
}