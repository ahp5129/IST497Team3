using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    // Start is called before the first frame update
    public class BackgroundScrolling : MonoBehaviour
{
    public float additionalScrollSpeed;
    public GameObject[] BQ;
    public float[] scrollSpeed;
    private void FixedUpdate(){
        for(int background = 0; background < BQ.Length; background++)
       { Renderer rend = BQ[background].GetComponent<Renderer>();
        float offset = Time.time * (scrollSpeed[background] + additionalScrollSpeed);
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
       }
    }
    
}

