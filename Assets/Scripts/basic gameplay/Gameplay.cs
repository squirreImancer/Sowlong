using UnityEngine;
using UnityEngine.InputSystem;

public class Gameplay : MonoBehaviour
{

    public int[] lane1;
    public int pit1;
    public int pit2;
    public int selection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartGame();
        selection = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
       lane1 = new int[14];
        pit1 = (lane1.Length / 2)-1;
        pit2 = lane1.Length - 1;
        for (int i = 0; i < lane1.Length; i++)
        {
            if(i != pit1 && i != pit2)
            {
                lane1[i] = 4;
            }
        
        }
    }

    public void IdxUP(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (selection != pit1-1 && selection != pit2-1)
            {
                selection++;
            }
            else if (selection == pit1-1)
            {
                selection = 0;
            }


        }
        
    }

    public void Select(InputAction.CallbackContext context) {

        if (context.performed) { 
        
            if (lane1[selection] != 0)
            {
                for (int i = 0; i < lane1[selection]; i++)
                {

                    lane1[i + selection]++;
                }
                lane1[selection] = 0;
            }

        
        }
    
    
    
    }


    #region EnemyAi



    #endregion
}
