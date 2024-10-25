using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGravity : MonoBehaviour
{
    Vector3 spawnPos;
    Vector3 rot;
    Rigidbody _rigidbody;
    bool pickedUP;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = this.gameObject.GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
        rot = new Vector3(0,1f,0);
        spawnPos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pickedUP) {
            this.transform.Rotate(rot);
        }
        if (this.gameObject.transform.position != spawnPos && !pickedUP) {
            _rigidbody.useGravity = true;
            pickedUP = true;
        }
    }
}
