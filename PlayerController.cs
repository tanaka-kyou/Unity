using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController Chara;
    private float MoveSpeed = 10f;
    private float G = -10f;

    public static bool CanMove = true;

    // Start is called before the first frame update
    void Start()
    {
        Chara = GetComponent<CharacterController>();
    
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove() {

        if ( CanMove == true) {

            float v = Input.GetAxis( "Vertical" );
            float h = Input.GetAxis( "Horizontal" );

            Vector3 Dir = new Vector3( h, 0, v );
            Dir = transform.TransformDirection( Dir );
            Dir = Dir * MoveSpeed;
            Dir.y = G;

            Chara.Move( Dir * Time.deltaTime );
        }
    }
}
