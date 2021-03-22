using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCombatGrid : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    // Change this script so it creates cube gameobjects and attaches CombatTile.cs which contains the components for cube.
    {
        GameObject[,] Tiles = new GameObject[4,7];
        Renderer tileRender;
        for (int z = 1; z < 4; z++)
        {
            for (int x = 1; x < 7; x++)
            {
                var testTexture = Resources.Load<Texture2D>("cobblestone");

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, 0, z);

                tileRender = cube.GetComponent<Renderer>();
                tileRender.GetComponent<Renderer>().material.mainTexture = testTexture;
                Tiles[z,x] = cube;
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
