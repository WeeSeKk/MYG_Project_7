using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRotationFollow : MonoBehaviour
{
    [SerializeField] Camera _camera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.LookAt(_camera.transform);
    }
}
