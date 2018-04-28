using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;

    public float yPoint;
    public float zPoint;
    public float xMinRange;
    public float xMaxRange;
    public int rangeLength;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
       
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); //
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition) + offset;
        //objPosition.y = transform.position.y;
        //objPosition.z = transform.position.z;
        if (objPosition.x >= xMinRange && objPosition.x <= xMaxRange)
        {
            objPosition.y = yPoint;
            objPosition.z = zPoint;
            /*for (int i = 1; i <= rangeLength+1; i++)
            {
                if (objPosition.x > (xMinRange + i - 2) && objPosition.x < xMinRange + i)
                {
                    objPosition.x = xMinRange + i;
                }
            }*/   
            transform.position = objPosition;       
        }
    }
}
