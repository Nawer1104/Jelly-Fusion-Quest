using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public Transform spawnPoint;

    public Block[] blocks;

    private int index;

    private int num_obj;

    private void Awake()
    {
        index = 0;

        num_obj = 0;
    }

    private void Start()
    {
        SpawnObj();
    }

    public void SpawnObj()
    {
        Instantiate(blocks[index], spawnPoint);

        num_obj += 1;

        if (num_obj % 3 == 0)
        {
            index += 1;

            if (index >= blocks.Length - 1)
            {
                index = blocks.Length - 1;
            }
        }
    }

    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
