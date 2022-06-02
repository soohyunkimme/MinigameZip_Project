using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Move
    public float moveSpeed = 1f;
    [SerializeField]
    private Vector2 inputPostion;
    [SerializeField]
    private Vector2 outputPostion;

    //Zoom
    //public float zoomSpeed = 1f;
    //public float MaxDistance = 10f;
    //public float minDistance = 3f;

    private void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        if (Input.GetMouseButtonDown(1)) inputPostion = Input.mousePosition;
        if (Input.GetMouseButtonUp(1)) outputPostion = Input.mousePosition;
    }
}
