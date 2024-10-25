using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LeftUIController : MonoBehaviour
{
    [SerializeField] GameObject image;
    [SerializeField] GameObject canvas;
    [SerializeField] Animator animator;
    Image uiImage;

    // Start is called before the first frame update
    void Start()
    {
        //uiImage = image.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        OrientationUIController();
    }

    void OrientationUIController()
    {
        //if uielement is close enough to camera 
        //change opacity base on Y rotation of the UI

        float rotationX = image.transform.eulerAngles.x;

        /*float opacity = Mathf.InverseLerp(maxRotationAngle, minRotationAngle, rotationY);
        Color color = uiImage.tintColor;
        color.a = opacity;
        uiImage.tintColor = color;*/

        if (rotationX < 40 && rotationX > 5)
        {
            //image.SetActive(true);
            animator.SetBool("UIOpen", true);
        }
        else
        {
            //image.SetActive(false);
            animator.SetBool("UIOpen", false);
        }
        
        //Debug.Log(rotationX);
    }
}
