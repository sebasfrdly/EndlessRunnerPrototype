using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float horizontalSpeed;
    [HideInInspector] 
    public Vector3 moveRequired = Vector3.zero;
    public float speedMultiplier = 1f;

    //variables for a screen boundary
    [HideInInspector] public Vector2 screenBoundaries;

    // Initializes all the variables that I need
    public void InitOnStart()
    {
        horizontalSpeed = 2f;
        screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // moves the objects during the update function
    public void MoveNPC()
    {
        moveRequired.x = horizontalSpeed * speedMultiplier;
        transform.position -= moveRequired * Time.deltaTime;

        if(transform.position.x > screenBoundaries.x)
        {
            Destroy(this.gameObject);
        }
    }
}
