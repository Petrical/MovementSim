using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralTerrain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          public int xWidth = 30;
    public int zDepth = 30;
    Vector3[] vertices;
    private void OnDrawGizmos()
    {
        if (vertices == null) return;
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], .5f);
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
