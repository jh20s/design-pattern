using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlyWeigtPattern : MonoBehaviour
{
    const int r = 8;
    const int c = 8;
    Terrain[,] tiles = new Terrain[r,c];
    Terrain grassTerrain = new Terrain(false, 1, "Grass");
    Terrain hillTerrain = new Terrain(false, 2, "Hill");
    Terrain waterTerrain = new Terrain(true, 0, "Water");

    void Start()
    {
        for (int i = 0; i < r; i++)
        {
            for(int j=0; j<c; j++)
            {
                int randNum = Random.Range(0, 3);
                if(randNum == 0)
                {
                    tiles[i, j] = grassTerrain;
                }
                else if (randNum == 1)
                {
                    tiles[i, j] = hillTerrain;
                }
                else if (randNum == 2)
                {
                    tiles[i, j] = waterTerrain;
                }
            }
        }

        for(int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                print(tiles[i, j]);
                GameObject obj = Instantiate(Resources.Load(tiles[i, j].objectName)) as GameObject;
                obj.transform.position = new Vector3(i-r/2, j-c/2, 0);
                obj.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
