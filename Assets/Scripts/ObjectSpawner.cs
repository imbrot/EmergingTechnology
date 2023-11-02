using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public Transform myPrefab;

    public int numberOfInstances = 10;
    public float minX = -5.0f;
    public float maxX = 5.0f;
    public float minZ = -5.0f;
    public float maxZ = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfInstances; i++)
        {
            Vector3 position = new Vector3(Random.Range(minX, maxX), 1, Random.Range(minZ, maxZ));
            Transform newObject = Instantiate(myPrefab, position, Quaternion.identity);

            newObject.Rotate(Vector3.up * Random.Range(0, 360));
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
