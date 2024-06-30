using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenManager : MonoBehaviour
{
    [SerializeField] private string color;
    [SerializeField] private GameObject currentHT;
    [SerializeField] private bool isSelected;


    void Start()
    {
        isSelected = false;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        col.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        col.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
