using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatTile : MonoBehaviour
{

    GameObject testObj;
    Renderer testObjRender;
    // Start is called before the first frame update
    void Start()
    {
        var testTexture = Resources.Load<Texture2D>("cobblestone");

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0, 0);

        testObjRender = cube.GetComponent<Renderer>();
        testObjRender.GetComponent<Renderer>().material.mainTexture = testTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
