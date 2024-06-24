using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardLoad : MonoBehaviour
{
    public GameObject hexTilePrefab;

    void Start()
    {
    }

    void OnValidate()
    {
        generateBoard();
    }

    void Update()
    {
    }

    void generateBoard()
    {
        Vector3 size = hexTilePrefab.GetComponent<SpriteRenderer>().bounds.size;
        Debug.Log(size.x);
        for (var row = 9; row >= -9; row--)
        {
            bool isEvenRow = row % 2 == 0;
            float offset = isEvenRow ? 0 : size.x / 2;

            for (var col = isEvenRow ? -4 : -5; col <= 4; col++)
            {
                Instantiate(hexTilePrefab, new Vector3(col * size.x + offset, row * (2 * size.x - size.y), 0), Quaternion.identity, transform);
            }
        }
    }
}
