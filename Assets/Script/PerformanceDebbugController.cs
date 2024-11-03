using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PerformanceDebbugController : MonoBehaviour
{
    int avgFrameRate;
    [SerializeField] Canvas canvas;
    [SerializeField] TextMeshProUGUI fpsText;
    [SerializeField] TextMeshProUGUI trianglesText;
    [SerializeField] TextMeshProUGUI verticesText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DisplayFrameRate", 1, 1);
        InvokeRepeating("CountTriangles", 5, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DisplayFrameRate()
    {
        float current = 0;
        current = (int)(1f / Time.unscaledDeltaTime);
        avgFrameRate = (int)current;
        fpsText.text = avgFrameRate.ToString() + "FPS";
    }

    void CountTriangles()
    {
        int triangles = 0;
        int vertices = 0;

        MeshFilter[] allMesh = UnityEngine.Object.FindObjectsOfType<MeshFilter>();
        foreach (MeshFilter mesh in allMesh)
        {
            triangles += mesh.sharedMesh.triangles.Length / 3;
            vertices += mesh.sharedMesh.vertexCount;
        }

        trianglesText.text = ("Triangles = " + triangles);
        verticesText.text = ("Vertices = " + vertices);
    }

    public void OnButtonClick()
    {
        if (canvas.gameObject.activeSelf == false)
        {
            canvas.gameObject.SetActive(true);
        }
        else
        {
            canvas.gameObject.SetActive(false);
        }
    }
}
