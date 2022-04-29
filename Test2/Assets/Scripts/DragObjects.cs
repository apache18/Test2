using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{//размещён на камере

    public static Vector3 moffset;
    private float _mZCoord;
    bool click = true;

    void Update()
    {

    }

    void OnMouseDown()
    {
        _mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        moffset = gameObject.transform.position - GetMouseWorldPos();

        click = true;

        BlueWall.check = true;
    }

    private Vector3 GetMouseWorldPos()
    {

        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = _mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()
    {
        if (click == true && BlueWall.check == true) 
        {
            transform.position = GetMouseWorldPos() + moffset;
        }
    }

    public void DestroyCube()
    {
        Destroy(gameObject);
    }
}