using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChickenCount : MonoBehaviour
{
    public static ChickenCount Instance;

    public TextMeshProUGUI eggCounter;
    public TextMeshProUGUI chickCounter;
    public TextMeshProUGUI henCounter;
    public TextMeshProUGUI roosterCounter;

    public int eggs;
    public int chicks;
    public int hens;
    public int roosters;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake(){
        Instance = this;
    }

    public void increaseEgg(){
        eggs++;
        eggCounter.text = eggs.ToString();
    }

    public void decreaseEgg(){
        eggs--;
        eggCounter.text = eggs.ToString();
    }

    public void increaseChick(){
        chicks++;
        chickCounter.text = chicks.ToString();
    }

    public void decreaseChick(){
        chicks--;
        chickCounter.text = chicks.ToString();
    }

    public void increaseHen(){
        hens++;
        henCounter.text = hens.ToString();
    }

    public void decreaseHen(){
        hens--;
        henCounter.text = hens.ToString();
    }

    public void increaseRooster(){
        roosters++;
        roosterCounter.text = roosters.ToString();
    }

    public void decreaseRooster(){
        roosters--;
        roosterCounter.text = roosters.ToString();
    }
}

