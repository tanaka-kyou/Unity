using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform PlayerTransform;
    public static bool CanCamera = true;
    
    void Start()
    {
        PlayerTransform = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        FirstParson();
    }

    private void FirstParson() {

        if ( CanCamera ) {

            float mouseX = Input.GetAxis( "Mouse X" );
            float mouseY = Input.GetAxis( "Mouse Y" );

            transform.Rotate( mouseY * -1, 0, 0 );
            PlayerTransform.Rotate( 0, mouseX, 0 );
        }
    }
}
