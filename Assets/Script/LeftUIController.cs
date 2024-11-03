using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;

namespace LeftHandUIController
{
    public class LeftUIController : MonoBehaviour
    {
        [SerializeField] GameObject image;
        [SerializeField] GameObject canvas;
        [SerializeField] Animator animator;
        [SerializeField] Material material1;
        [SerializeField] Material material2;
        [SerializeField] Material material3;
        [SerializeField] Material materialVideo1;
        [SerializeField] GameObject lobbyElements;
        [SerializeField] GameObject mat1Elements;
        [SerializeField] GameObject mat2Elements;
        [SerializeField] VideoPlayer videoPlayer;
        [SerializeField] VideoClip videoClip1;
        [SerializeField] VideoClip videoClip2;
        Image uiImage;

        // Start is called before the first frame update
        void Start()
        {
            //uiImage = image.GetComponent<Image>();
            //OnButtonClick(4);
            //StartCoroutine(test());
        }

        // Update is called once per frame
        void Update()
        {
            OrientationUIController();

        }

        IEnumerator test()
        {
            yield return new WaitForSeconds(5);
            OnButtonClick(4);
            yield return new WaitForSeconds(5);
            OnButtonClick(5);
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

        public void OnButtonClick(int mat)
        {
            switch (mat)
            {
                case 1:
                    RenderSettings.skybox = material1;
                    /*mat1Elements.SetActive(true);*/
                    lobbyElements.SetActive(false);
                    break;
                case 2:
                    RenderSettings.skybox = material2;
                    /*mat1Elements.SetActive(false);
                    mat2Elements.SetActive(true);*/
                    lobbyElements.SetActive(false);
                    break;
                case 3:
                    RenderSettings.skybox = material3;
                    /*mat1Elements.SetActive(false);
                    mat2Elements.SetActive(false);*/
                    lobbyElements.SetActive(true);
                    break;
                case 4:
                    videoPlayer.Stop();
                    videoPlayer.clip = null;
                    RenderSettings.skybox = materialVideo1;
                    /*mat1Elements.SetActive(false);
                    mat2Elements.SetActive(false);*/
                    lobbyElements.SetActive(false);
                    videoPlayer.clip = videoClip1;
                    videoPlayer.Play();
                    break;
                case 5:
                    videoPlayer.Stop();
                    videoPlayer.clip = null;
                    RenderSettings.skybox = materialVideo1;
                    /*mat1Elements.SetActive(false);
                    mat2Elements.SetActive(false);*/
                    lobbyElements.SetActive(false);
                    videoPlayer.clip = videoClip2;
                    videoPlayer.Play();
                    break;
            }
        }
    }
}