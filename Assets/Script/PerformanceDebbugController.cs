using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PerformanceDebbugController : MonoBehaviour
{
    int avgFrameRate;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DisplayFrameRate", 1, 1);
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
        textMeshProUGUI.text = avgFrameRate.ToString() + "FPS";
    }

    void CountTriangles()
    {
        int triangles;
        int vertices;

        //MeshFilter[] allMesh = UnityEngine.Object.FindObjectOfType<MeshFilter>();

        
    }
}
