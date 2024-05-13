using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Player : NetworkBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            
        }
    }

    void FixedUpdate()
    {
        if (!isLocalPlayer) {   
            Move();
        }
    }

    private void Move()
    {
        if (!IsMouseOverGameWindow()) {
            return;
        }

        // Get the mouse position in world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z; // Ensure the circle stays in the 2D plane

        // Calculate the direction towards the mouse position
        Vector3 direction = mousePosition - transform.position;

        // Move the circle towards the mouse position
        transform.position += direction.normalized * speed * Time.fixedDeltaTime;
    }

    private bool IsMouseOverGameWindow()
    {
        Vector3 mp = Input.mousePosition;
        return !(  0>mp.x || 0>mp.y || Screen.width<mp.x || Screen.height<mp.y );
    }
}
