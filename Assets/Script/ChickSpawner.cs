using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickSpawner : MonoBehaviour
{
    public HenSpawner hen;
    public RoosterSpawner rooster;

    public float matureT = 10;
    // Start is called before the first frame update
    void Start(){
        ChickenCount.Instance.increaseChick();
        Invoke(nameof(Mature), matureT);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Mature(){
        int i = Random.Range(0, 2);
        Vector3 offset = new Vector3(0.0f, 1.0f, 0.0f);

        if (ChickenCount.Instance.chicks == 1) {
            i = 0; 
        }

        if (i == 0){
            Instantiate(hen, transform.position += offset, Quaternion.identity);
        }else{
            Instantiate(rooster, transform.position += offset, Quaternion.identity);
        }
        ChickenCount.Instance.decreaseChick();

        Destroy(gameObject);
    }
}
