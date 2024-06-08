using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterSpawner : MonoBehaviour
{
    public float deathT = 40;
    // Start is called before the first frame update
    void Start(){
        ChickenCount.Instance.increaseRooster();

        Invoke(nameof(killRooster), deathT);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void killRooster(){
        ChickenCount.Instance.decreaseRooster();
        Destroy(gameObject);
    }
}
