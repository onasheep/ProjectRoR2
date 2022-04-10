using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public Transform Player;
    public LayerMask myPlayer;
    public Transform myRoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((myPlayer & (1 << other.gameObject.layer)) != 0)
        {
            myRoot.transform.SetParent(Player.transform);
            myRoot.transform.localScale -= new Vector3(0.9f, 0.9f, 0.9f);
        }
    }
}
