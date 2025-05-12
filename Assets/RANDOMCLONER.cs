using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANDOMCLONER : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;

    public int randomNumber;
    public int min = 0;
    public int max = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CloneRandom()
    {
        randomNumber = Random.Range(min, max);
        switch (randomNumber)
        {
            case 0:
                ClonarCubo();
                break;
            case 1:
                ClonarSphere();
                break;
            case 2:
                ClonarCylinder();
                break;
        }
    }

    public void ClonarCubo()
    {
        Instantiate(cubePrefab);
    }

    public void ClonarSphere()
    {
        Instantiate(spherePrefab);
    }

    public void ClonarCylinder()
    {
        Instantiate(cylinderPrefab);
    }
}
