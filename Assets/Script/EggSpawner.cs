using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public ChickSpawner chick;
    public float hatchT = 10;

    // Start is called before the first frame update
    void Start(){
        ChickenCount.Instance.increaseEgg();
        Invoke(nameof(hatchEgg), hatchT);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void hatchEgg(){
        Vector3 offset = new Vector3(0.0f, 1.0f, 0.0f);
        Instantiate(chick, transform.position += offset, Quaternion.identity);
        ChickenCount.Instance.decreaseEgg();
        Destroy(gameObject);
    }
}
