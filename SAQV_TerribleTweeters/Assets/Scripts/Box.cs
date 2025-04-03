using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    SpriteRenderer _sprite;

    // Start is called before the first frame update
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        //_sprite.flipX = Random.Range(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
