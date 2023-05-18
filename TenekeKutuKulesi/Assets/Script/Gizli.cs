using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizli : MonoBehaviour
{
    Camera camera;
    Vector2 baslangicPozisyon;



    private void OnMouseDrag()
    {
        Vector3 pozisyon=camera.ScreenToViewportPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }

    
    void Start()
    {
        camera=GameObject.Find("Camera").GetComponent<Camera>();
        baslangicPozisyon=transform.position;
    }

    
    void Update()
    {
        
    }
}
