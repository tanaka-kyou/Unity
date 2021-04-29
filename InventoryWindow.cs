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

                Inventory.gameObject.SetActive(false); //�\����؂�
                isInventory = false; //�t���O��of�ɃZ�b�g����

                //�E�B���h�E��������ɃJ�����ƃL�����𓮂���悤�ɖ߂��B
                PlayerController.CanMove = true; 
                CameraController.CanCamera = true;

                //�J�[�\�������b�N�A�������Ȃ�
                Cursor.lockState = CursorLockMode.Locked;
               
            }
             else if(isInventory == false){

                Inventory.gameObject.SetActive( true );//�\��������
                isInventory = true;     //�t���O��on�ɃZ�b�g����

                //�E�B���h�E���J�������ɁA�J�������L�������~�߂�
                PlayerController.CanMove = false;
                CameraController.CanCamera = false;

                //�J�[�\�������b�N�����A��������悤��
                Cursor.lockState = CursorLockMode.None;

            }
        }
    }
}
