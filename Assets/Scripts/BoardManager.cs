using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private GameObject[] fenItems;
    void Awake()
    {
        fenItems = GameObject.FindGameObjectsWithTag("Fen");
    }

    void Start()
    {
    }

    void Update()
    {

    }
}
