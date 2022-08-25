using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscarElementoEnArray : MonoBehaviour
{

    [SerializeField] GameObject[] arrayDeMesas;
    [SerializeField] string tagDeMesa;

    // Start is called before the first frame update
    void Start()
    {
        arrayDeMesas = GameObject.FindGameObjectsWithTag(tagDeMesa);    
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            FindObjectInArray();
        }
        
        
    }

    void FindObjectInArray()
    {
        bool isFound = false;
        int i = 0;
        // para buscar un elemento usamos while
        while (i<arrayDeMesas.Length && !isFound)
        {
            if (arrayDeMesas[i].GetComponent<Mesa>().owner == "Luciano" )
            {
                isFound = true;
                Destroy(arrayDeMesas[i]);
                return;
            }
            i++;
        }
    }
}
