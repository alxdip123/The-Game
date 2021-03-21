using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCombatGrid : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    // Change this script so it creates cube gameobjects and attaches CombatTile.cs which contains the components for cube.
    {
        GameObject[,] Tiles = new GameObject[3,6];
        for (int z = 1; z < 3; z++)
        {
            for (int x = 1; x < 6; x++)
            {
                Tiles[z,x] = new GameObject();
                Tiles[z,x].AddComponent<CombatTile>();
                CombatTile tile = Tiles[z,x].GetComponent<CombatTile>();
                Vector3 temp = tile.transform.position;
                temp.z = z;
                temp.x = x; 
                tile.transform.position = temp;
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
