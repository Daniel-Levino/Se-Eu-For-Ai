using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestruirItem()
    {
        //Debug.Log("Item destuido!");
        GameController.instance.contadorItens += 1;
        Destroy(gameObject);
    }
}
