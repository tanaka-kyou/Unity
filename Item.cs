using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Vector3 ScreenCenter;
    private int RayDistance = 2;
    [SerializeField]private List<GameObject> ItemDate = new List<GameObject>();
    GameObject Hitobj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetItem();
    }

    private void GetItem() {
        Debug.Log( Hitobj );
        int CenterX = Screen.width / 2;
        int CenterY = Screen.height / 2;
        ScreenCenter = new Vector3( CenterX, CenterY, 0.01f );

        Ray ray = Camera.main.ScreenPointToRay( ScreenCenter );
        RaycastHit hit;
        Debug.DrawRay(ray.origin,ray.direction,Color.red,0.1f,false);


        if ( Physics.Raycast( ray, out hit, RayDistance ) ) {

            Hitobj = hit.collider.gameObject; //例キャストされたオブジェクト

            if ( Input.GetKeyDown( KeyCode.Space ) ) {

                ItemDate.Add( Hitobj );
                
            } else {
                Hitobj = null;
            }
        }

    }
}
