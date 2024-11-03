using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace SphereController
{
    public class TeleportationSphereController : MonoBehaviour
    {
        [SerializeField] Material material1;
        [SerializeField] Material material2;
        [SerializeField] Material material3;
        [SerializeField] Material materialVideo1;
        [SerializeField] GameObject lobbyElements;
        [SerializeField] VideoPlayer videoPlayer;
        [SerializeField] VideoClip videoClip1;
        [SerializeField] VideoClip videoClip2;
        //[SerializeField] GameObject mat1Elements;
        //[SerializeField] GameObject mat2Elements;

        public void OnTeleport(int mat)
        {
            Debug.Log("sqwdfsqdfsqd");
            switch (mat)
            {
                case 1:
                    RenderSettings.skybox = material1;
                    /*mat1Elements.SetActive(true);*/
                    //lobbyElements.SetActive(false);
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

        public void OnButtonClick(string type)
        {
            if (type == "Forward")
            {
                if (RenderSettings.skybox == material3)
                {
                    RenderSettings.skybox = material1;
                    //mat1Elements.SetActive(true);
                    lobbyElements.SetActive(false);
                }
                else if (RenderSettings.skybox == material1)
                {
                    RenderSettings.skybox = material2;
                    /*mat1Elements.SetActive(false);
                    mat2Elements.SetActive(true);*/
                    lobbyElements.SetActive(false);
                }
                else if (RenderSettings.skybox == material2)
                {
                    RenderSettings.skybox = material3;
                    /*mat1Elements.SetActive(false);
                    mat2Elements.SetActive(false);*/
                    lobbyElements.SetActive(true);
                }
            }
            else
            {
                if (RenderSettings.skybox == material3)
                {

                }
                else if (RenderSettings.skybox == material1)
                {
                    RenderSettings.skybox = material3;
                    /*mat1Elements.SetActive(false);
                    mat2Elements.SetActive(false);*/
                    lobbyElements.SetActive(true);
                }
                else if (RenderSettings.skybox == material2)
                {
                    RenderSettings.skybox = material1;
                    /*mat2Elements.SetActive(false);
                    mat1Elements.SetActive(true);*/
                    lobbyElements.SetActive(false);
                }
            }
        }

        public void OnHover()
        {
            Debug.Log("Hover");
        }
    }
}

