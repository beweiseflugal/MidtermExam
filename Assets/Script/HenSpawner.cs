using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenSpawner : MonoBehaviour
{
    public float layingT = 30;
    public float deathT = 40;
    public Transform spawn;
    public GameObject egg;
    // Start is called before the first frame update
    void Start(){
        ChickenCount.Instance.increaseHen();

        Invoke(nameof(LayEggs), layingT);
        Invoke(nameof(killHen), deathT);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void killHen(){
        ChickenCount.Instance.decreaseHen();
        Destroy(gameObject);
    }

    private void LayEggs(){
        int randomEgg = Random.Range(2, 11); 
        for (int i = 0; i < randomEgg; i++)
        {
            Instantiate(egg, spawn.position, Quaternion.identity);
        }
    }

}

