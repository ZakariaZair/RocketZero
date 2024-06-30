using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardLoad : MonoBehaviour
{
    public GameObject hexTilePrefab;

    void Start()
    {
        generateBoard();
    }

    void LateUpdate()
    {
    }

    void generateBoard()
    {
        Vector3 size = hexTilePrefab.GetComponent<SpriteRenderer>().bounds.size;
        for (var row = 8; row >= -8; row--)
        {
            bool isEvenRow = row % 2 == 0;
            float offset = isEvenRow ? 0 : size.x / 2;
            for (var col = isEvenRow ? -4 : -5; col <= 4; col++)
            {
                Instantiate(hexTilePrefab, new Vector3(col * size.x + offset, row * (2 * size.x - size.y), transform.position.z), Quaternion.identity, transform);
            }
        }
    }
}
