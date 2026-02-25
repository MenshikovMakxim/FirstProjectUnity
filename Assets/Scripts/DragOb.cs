using UnityEngine;

public class DragOb : MonoBehaviour
{
    private bool isDragging = false;

    void OnMouseDown() => isDragging = true;
    void OnMouseUp() => isDragging = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            transform.position = mousePos;
        }
    }
}
