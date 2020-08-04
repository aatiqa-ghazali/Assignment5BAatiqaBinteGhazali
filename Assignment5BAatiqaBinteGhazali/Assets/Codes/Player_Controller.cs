using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
   
    public float speed ;
    private Rigidbody rb;
    public int count = 0;
    public TextMesh countText;
    // public Text textview;
    public AudioSource ticksource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ticksource = GetComponent<AudioSource>();
        //   textview.text = count.ToString();
        countText.text = "";
    }
 static Boolean IsBalanced(char character1, char character2) 
    { 
        if (character1 == '(' && character2 == ')') 
            return true; 
       
        else
            return false; 
    } 
public static bool IsValid(string myString)
    {
        char[] exp = myString.ToCharArray();
        Stack<char> st = new Stack<char>();

        for (int i = 0; i < exp.Length; i++)
        {

            /*If the exp[i] is a starting  
                parenthesis then push it*/
            if (exp[i] == '(')
                st.Push(exp[i]);

            /* If exp[i] is an ending parenthesis  
                then pop from stack and check if the  
                popped parenthesis is a matching pair*/
            if (exp[i] == ')')
            {

                /* If we see an ending parenthesis without  
                    a pair then return false*/
                if (st.Count == 0)
                {
                    return false;
                }

                /* Pop the top element from stack, if  
                    it is not a pair parenthesis of character  
                    then there is a mismatch. This happens for  
                    expressions like {(}) */
                else if (!IsBalanced(st.Pop(), exp[i]))
                {
                    return false;
                }
            }
        }

        if (st.Count == 0)
            return true; /*balanced*/
        else
        { /*not balanced*/
            return false;
        }
}

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(mov * speed);
    }
    void OnTriggerEnter(Collider other
        )
    {
        string n = other.GetComponent<Rotate_>().x;
        Spawner_ ss = new Spawner_();
        if (IsValid(n))
        {
            count++;
            SetCountText(ss.NoOfPalind());
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
           
            
        }
        else if(!(IsValid(n)))
        {
           

            ticksource.Play(0);
            Debug.Log("started");

        }



    }
    

  

    void SetCountText(int parenthesis)
    {
 Debug.Log(parenthesis)
        if parenthesis== count)
        {
  
            countText.text = "All Balanced parenthesis are eaten."+"\n"+"The number of eaten parenthesis which are balanced is" + " " + parenthesis.ToString();
        }
        
    }
}
