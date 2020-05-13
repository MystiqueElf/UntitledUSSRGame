using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonC : MonoBehaviour
{
    public GameObject img;
    public void Up()
    {
        Vector2 pos = img.transform.position;
        pos.y += 10;
        transform.position = pos;
    }
    public void Down()
    {
        Vector2 pos = img.transform.position;
        pos.y -= 10;
        transform.position = pos;
    }
    public void Right()
    {
        Vector2 pos = img.transform.position;
        pos.x += 10;
        transform.position = pos;
    }
    public void Left()
    {   
        Vector2 pos = img.transform.position;
        pos.x -= 10;
        transform.position = pos;
    }
}
