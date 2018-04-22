using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

    void OnMouseDrag()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); //
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition) + offset;

        //if (transform.position.x >= 9.97 || transform.position.x <= 20.97)
        //{
            objPosition.y = transform.position.y;
            objPosition.z = transform.position.z;
            transform.position = objPosition;
        //}
    }
}
