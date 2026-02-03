using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class squaretest : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumnber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pickARandomColor(); 
        PickRandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the sprite please");
            PickRandomSprite();

            if (barrels.Count > 0)
            {
                PickRandomSprite();
            }
        }
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadDefaultValue());
        // get the mouse posistion 
        //is it over the shape?
        if (spriteRenderer.bounds.Contains(mousePos) == true)

        {
            // y: set the color with our col variable
            spriteRenderer.color = col;
        }
        else
        {

            //N: set the color to white
            spriteRenderer.color = Color.white;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)

        {
            barrels.RemoveAt(0);
        }
    }

    void pickARandomColor()

    {
        spriteRenderer.color = Random.ColorHSV();

    }
    void PickRandomSprite()
    {
        // spriteRenderer.sprite = mySprite;
        randomNumnber = Random.Range(0, barrels.Count);
        //pick a random number
        //use that sprite to the spirte renderer 

        spriteRenderer.sprite = barrels[randomNumnber];
    }
}