using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject blaster;
    [SerializeField] GameObject cube;
    [SerializeField] GameObject sphere;
    Vector3 blasterSpawnPos;
    bool moved;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TESTDebug()
    {
        Debug.Log("Button pressed");
    }

    public void SpawnBlaster()
    {
        Instantiate(blaster, this.transform);
    }

    public void SpawnCube()
    {
        Instantiate(cube, this.transform);
    }

    public void SpawnSphere()
    {
        Instantiate(sphere, this.transform);
    }
}
