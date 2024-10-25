using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterRot : MonoBehaviour
{
    Vector3 rot;

    // Start is called before the first frame update
    void Start()
    {
        rot = new Vector3(0,0.1f,0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rot);
    }
}
