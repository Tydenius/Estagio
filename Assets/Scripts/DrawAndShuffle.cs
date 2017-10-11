using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawAndShuffle : MonoBehaviour {

    public List<Transform> Children;
    GameObject hand = new GameObject();
    int e = 0;

    public void Update()
    {
       hand = GameObject.Find("Hand");
       int i = this.transform.childCount - 1; 

        if (this.transform.childCount > 0 && hand.transform.childCount < 5)
        {
            int n = Random.Range(0, this.transform.childCount);

            Children.Add(this.transform.GetChild(n));
            Children[e].SetParent(hand.transform);
            e++;
            
        }
        
        
    }
}
