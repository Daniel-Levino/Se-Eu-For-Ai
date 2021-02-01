using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelContoller : MonoBehaviour
{
    public GameObject proxLevel;
    public int contadorItens=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contadorItens>=3)
        {
            proxLevel.SetActive(true);
        }
    }
}
