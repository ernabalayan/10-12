using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SimpleMouseClick : MonoBehaviour
{
    Camera mainCamera;
    public TMP_Text clickText;
    int points = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        mainCamera = Camera.main;
    }
    void Start()
    {
        
    }

    void ClickCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Input.mousePosition));

            if (ray.collider != null && ray.collider.CompareTag("ClickButton"))
            {
                points += 1;
                clickText.text = "Clicks: " + points;
                ray.collider.GetComponent<SimpleClickCircle>().ChangeColor(0);
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Input.mousePosition));

            if(ray.collider != null && ray.collider.CompareTag("ClickButton"))
            {

                ray.collider.GetComponent<SimpleClickCircle>().ChangeColor(1);
                points -= 1;
                clickText.text = $"Clicks: + points";
                clickText.text = "Clicks: " + points;
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        ClickCheck();
    }
}
