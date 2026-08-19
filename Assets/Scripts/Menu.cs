using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //ARRAY / LIST = Group of variables
    public Image[] sprites; //Fixed and we can not change it at runtiome.
    public List<Image> spritesList; //Can be changed at runtiome. Add/Remove

    public Image image;
    public Color[] colors;
    int colorIndex = -1;

    //SYNTAX
    // + Setting something to
    // - Minus
    // + Add
    // * Multiply
    // / Divide

    // && AND (Two things have to be true)
    // || OR (One OR the other thing has to be true.)
    
    // ! NOT

    // == SAME AS
    // != NOT THE SAME
    
    
    //FOR EACH / FOR LOOP = Iterate through a list or array.
    private void Start()
    {
        //foreach (var sprite in sprites)
        //{
        //    sprite.color = Color.red;
        //}

        //for (int i = 0; i < sprites.Length; i++)
        //{
        //    sprites[i].color = Color.blue;
        //}
    }

    public void ChangeColor()
    {
        //Color index to go up by 1 number.

        if (colorIndex == colors.Length - 1)
        {
            colorIndex = 0;
        }
        else
        {
            colorIndex++; // + 1.
        }
        image.color = colors[colorIndex];
    }




   public void ChangeScene(string sceneName) //void + () = function
    {
        //What dO I want to happen when my button is pressed?
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Debug.Log("Quittin game!");
        Application.Quit(); //Close our build.
    }



}
