using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INSTANTIATOR : MonoBehaviour
{
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        ClonarCubo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonarCubo()
    {
        Instantiate(cubePrefab);
    }
}
