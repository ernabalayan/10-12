using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleClickCircle : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public Color colorOne = Color.red;
    public Color colorTwo = Color.green;
    // Start is called before the first frame update

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();


    }
    void Start()
    {
        
    }

    public void ChangeColor(int n )
    {
        if (n == 0)
        {


            spriteRenderer.color = colorOne;
        }
        else if(n == 1)
        {
            spriteRenderer.color = colorTwo;
        }
    
    }
    // Update is called once per frame
    void Update()
    {
     
        
    }
}
