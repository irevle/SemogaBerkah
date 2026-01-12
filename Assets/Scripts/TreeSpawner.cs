using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject treePrefab;
    public int treeCount = 100;
    public Vector2 areaSize = new Vector2(50f, 50f);
    public float minDistance = 2f;

    private List<Vector3> spawnedPositions = new List<Vector3>();

    void Start()
    {
        for (int i = 0; i < treeCount; i++)
        {
            Vector3 position;
            int attempts = 0;

            do
            {
                position = GetRandomPosition();
                attempts++;
            }
            while (!IsPositionValid(position) && attempts < 20);

            if (attempts < 20)
            {
                spawnedPositions.Add(position);
                Instantiate(treePrefab, position, Quaternion.identity);
            }
        }
    }

    Vector3 GetRandomPosition()
    {
        float xOffset = Random.Range(-areaSize.x / 2, areaSize.x / 2);
        float zOffset = Random.Range(-areaSize.y / 2, areaSize.y / 2);

        Vector3 origin = transform.position + new Vector3(xOffset, 100f, zOffset);

        if (Physics.Raycast(origin, Vector3.down, out RaycastHit hit, 200f))
        {
            return hit.point;
        }

        return origin;
    }

    bool IsPositionValid(Vector3 position)
    {
        foreach (Vector3 pos in spawnedPositions)
        {
            if (Vector3.Distance(position, pos) < minDistance)
                return false;
        }
        return true;
    }
}


//using UnityEngine;

//public class TreeSpawner : MonoBehaviour
//{
//    public GameObject treePrefab;
//    public int treeCount = 100;
//    public Vector2 areaSize = new Vector2(50f, 50f);
//    public float minDistance = 2f;

//    void Start()
//    {
//        for (int i = 0; i < treeCount; i++)
//        {
//            Vector3 position = GetRandomPosition();
//            Instantiate(treePrefab, position, Quaternion.identity);
//        }
//    }

//    //Vector3 GetRandomPosition()
//    //{
//    //    float x = Random.Range(-areaSize.x / 2, areaSize.x / 2);
//    //    float z = Random.Range(-areaSize.y / 2, areaSize.y / 2);

//    //    Vector3 origin = new Vector3(x, 300f, z);

//    //    if (Physics.Raycast(origin, Vector3.down, out RaycastHit hit, 200f))
//    //    {
//    //        return hit.point;
//    //    }

//    //    return origin;
//    //}

//    Vector3 GetRandomPosition()
//    {
//        float xOffset = Random.Range(-areaSize.x / 2, areaSize.x / 2);
//        float zOffset = Random.Range(-areaSize.y / 2, areaSize.y / 2);

//        Vector3 origin = transform.position + new Vector3(xOffset, 100f, zOffset);

//        if (Physics.Raycast(origin, Vector3.down, out RaycastHit hit, 200f))
//        {
//            return hit.point;
//        }

//        return origin;
//    }


//}
