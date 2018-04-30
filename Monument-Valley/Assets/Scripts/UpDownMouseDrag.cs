using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMouseDrag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    public float xPoint;
    public float zPoint;
    public float yMinRange;
    public float yMaxRange;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition) + offset;
        if (objPosition.y >= yMinRange && objPosition.y <= yMaxRange)
        {
            objPosition.x = xPoint;
            objPosition.z = zPoint;
            transform.position = objPosition;
        }
    }
}
