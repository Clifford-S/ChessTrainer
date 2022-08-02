using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour

{
    private Vector3 mOffset;
    public float mXCoord;
    public float mYCoord;
    public float mZCoord;

    void OnMouseDown()
    {
        mXCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).x;
        mYCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).y;
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        //mousePoint.y = 0f;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }
}
