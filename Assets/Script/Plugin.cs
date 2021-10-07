using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class Plugin : MonoBehaviour
{
    [DllImport("Plugin")]
    private static extern int RandomNumber(int min, int max);
    private float time = 0f;
    public Rigidbody rb;
    public Transform playerPos;

    int spawnPerPos = 3;

    // Start is called before the first frame update
    
    void Start()
    {
        time += Time.deltaTime;

    }

    private void Update()
    {
       

        if (time > 0.5)
        {
            Instantiate(rb, new Vector3(RandomNumber(29, 48), playerPos.position.y + 10, playerPos.position.z + 5), Quaternion.identity);
            time = 0;
        }

        time += Time.deltaTime;
    }
}
