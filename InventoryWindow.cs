using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryWindow : MonoBehaviour
{
    private bool isInventory = false;
    public GameObject Inventory;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {

            if(isInventory == true) {

                Inventory.gameObject.SetActive(false); //表示を切る
                isInventory = false; //フラグをofにセットする

                //ウィンドウを閉じた時にカメラとキャラを動けるように戻す。
                PlayerController.CanMove = true; 
                CameraController.CanCamera = true;

                //カーソルをロック、うごけない
                Cursor.lockState = CursorLockMode.Locked;
               
            }
             else if(isInventory == false){

                Inventory.gameObject.SetActive( true );//表示をする
                isInventory = true;     //フラグをonにセットする

                //ウィンドウを開いた時に、カメラをキャラを止める
                PlayerController.CanMove = false;
                CameraController.CanCamera = false;

                //カーソルをロック解除、うごけるように
                Cursor.lockState = CursorLockMode.None;

            }
        }
    }
}
