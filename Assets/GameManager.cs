using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Lights
{
    Red,
    Green
}
public class GameManager : MonoBehaviour
{
    public Lights eLight;
    public GameObject cars;
    public Transform[] SpawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (eLight)
        {
            case Lights.Red:
                break;
            case Lights.Green:
                break;
            default:
                break;
        }
    }

    public void RedLight()
    {
        eLight = Lights.Red;
    } 
    public void GreenLight()
    {
        eLight = Lights.Green;
    }
    public void SpawnCars()
    {
        Instantiate(cars, SpawnPoints[0].transform.position, SpawnPoints[0].transform.rotation);
    }
}
