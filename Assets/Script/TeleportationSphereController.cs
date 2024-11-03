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

        public void OnTeleport(int mat)
        {
            switch (mat)
            {
                case 1:
                    RenderSettings.skybox = material1;
                    lobbyElements.SetActive(false);
                    break;
                case 2:
                    RenderSettings.skybox = material2;
                    lobbyElements.SetActive(false);
                    break;
                case 3:
                    RenderSettings.skybox = material3;
                    lobbyElements.SetActive(true);
                    break;
                case 4:
                    videoPlayer.Stop();
                    videoPlayer.clip = null;
                    RenderSettings.skybox = materialVideo1;
                    lobbyElements.SetActive(false);
                    videoPlayer.clip = videoClip1;
                    videoPlayer.Play();
                    break;
                case 5:
                    videoPlayer.Stop();
                    videoPlayer.clip = null;
                    RenderSettings.skybox = materialVideo1;
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
                    lobbyElements.SetActive(false);
                }
                else if (RenderSettings.skybox == material1)
                {
                    RenderSettings.skybox = material2;
                    lobbyElements.SetActive(false);
                }
                else if (RenderSettings.skybox == material2)
                {
                    videoPlayer.Stop();
                    videoPlayer.clip = null;
                    RenderSettings.skybox = materialVideo1;
                    lobbyElements.SetActive(false);
                    videoPlayer.clip = videoClip1;
                    videoPlayer.Play();
                }
                else if (RenderSettings.skybox == materialVideo1 && videoPlayer.clip  == videoClip1)
                {
                    videoPlayer.Stop();
                    videoPlayer.clip = null;
                    RenderSettings.skybox = materialVideo1;
                    lobbyElements.SetActive(false);
                    videoPlayer.clip = videoClip2;
                    videoPlayer.Play();
                }
                else if (videoPlayer.clip  == videoClip2)
                {
                    RenderSettings.skybox = material3;
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
                    lobbyElements.SetActive(true);
                }
                else if (RenderSettings.skybox == material2)
                {
                    RenderSettings.skybox = material1;
                    lobbyElements.SetActive(false);
                }
                else if (RenderSettings.skybox == materialVideo1 && videoPlayer.clip  == videoClip1)
                {
                    RenderSettings.skybox = material2;
                    lobbyElements.SetActive(false);
                }
                else if (RenderSettings.skybox == materialVideo1 && videoPlayer.clip  == videoClip2)
                {
                    videoPlayer.Stop();
                    videoPlayer.clip = null;
                    RenderSettings.skybox = materialVideo1;
                    lobbyElements.SetActive(false);
                    videoPlayer.clip = videoClip1;
                    videoPlayer.Play();
                }
            }
        }

        public void OnHover()
        {
            Debug.Log("Hover");
        }
    }
}

