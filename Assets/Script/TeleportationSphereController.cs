using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationSphereController : MonoBehaviour
{
    [SerializeField] Material material1;
    [SerializeField] Material material2;
    [SerializeField] Material material3;
    [SerializeField] GameObject lobbyElements;
    [SerializeField] GameObject mat1Elements;
    [SerializeField] GameObject mat2Elements;

    public void OnTeleport(int mat)
    {
        Debug.Log("Teleporting");

        if (lobbyElements.activeSelf == true)
        {
            lobbyElements.SetActive(false);
        }

        if (mat == 1)
        {
            RenderSettings.skybox = material2;
            mat2Elements.SetActive(true);
        }
        else if (mat == 0)
        {
            RenderSettings.skybox = material1;
            mat1Elements.SetActive(true);
        }
        else
        {
            RenderSettings.skybox = material3;
            mat1Elements.SetActive(false);
            mat2Elements.SetActive(false);
            lobbyElements.SetActive(true);
        }
    }

    public void OnButtonClick(string type)
    {
        if (type == "Forward")
        {
            if (RenderSettings.skybox == material3)
            {
                RenderSettings.skybox = material1;
                mat1Elements.SetActive(true);
            }
            else if (RenderSettings.skybox == material1)
            {
                RenderSettings.skybox = material2;
                mat2Elements.SetActive(true);
            }
            else if (RenderSettings.skybox == material2)
            {
                RenderSettings.skybox = material3;
                mat1Elements.SetActive(false);
                mat2Elements.SetActive(false);
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
                mat1Elements.SetActive(false);
                mat2Elements.SetActive(false);
                lobbyElements.SetActive(true);
            }
            else if (RenderSettings.skybox == material2)
            {
                RenderSettings.skybox = material1;
                mat2Elements.SetActive(false);
                mat1Elements.SetActive(true);
            }
        }
    }
}
