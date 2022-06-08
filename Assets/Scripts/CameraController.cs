using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Move
    public float moveSpeed = 1f;
    private Vector3 lastFrameMousePos;


    //Zoom
    //public float zoomSpeed = 1f;
    //public float MaxDistance = 10f;
    //public float minDistance = 3f;

    private void Update()
    {
        if (GameManager.instance.isActive == true)
        {
            RotateTargetObject();
            MoveCamera();
            lastFrameMousePos = Input.mousePosition;
        }
    }

    private void RotateTargetObject()
    {
        if (Input.GetMouseButton(0) && lastFrameMousePos != null)
        {
            Vector3 rotateVector = Input.mousePosition - lastFrameMousePos;
            GameManager.instance.targetObject.transform.Rotate(rotateVector); //자연스러운 돌리기로 고치기
        }
    }

    private void MoveCamera()
    {
        if (Input.GetMouseButton(1) && lastFrameMousePos != null)
        {
            Vector3 moveVector = Input.mousePosition - lastFrameMousePos;
            Camera.main.transform.position += - moveVector * Time.deltaTime * moveSpeed;
        }
    }
}
