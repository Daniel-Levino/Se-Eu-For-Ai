using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject proxLevel;
    public int contadorItens = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(contadorItens>7)
        {
            proxLevel.SetActive(true);
        }
    }
}
