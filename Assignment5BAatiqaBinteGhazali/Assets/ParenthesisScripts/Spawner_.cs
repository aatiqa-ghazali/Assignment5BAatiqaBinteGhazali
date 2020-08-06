using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

using UnityEngine.UI;

public class Spawner_ : MonoBehaviour
{
    public GameObject[] collectables;

    private GameObject g;

    public static int total = 0;

    int randEnemy;

    void Start()
    {

        add();


    }

    public void add()
    {

         int counter = 1;
        //for 10 cubes
        for (int i = 0; i < 31; i++)
        {

            GameObject gameobject;


            randEnemy = Random.Range(0, 4);
            float x = Random.Range(-9, 9);
            float z = Random.Range(-7, 7);
            //y is set to 1
            Vector3 spawnPosition = new Vector3(Random.Range(-12, 10), 2f, Random.Range(-10, 7));
            //generate random no between 0 and 2
            int r = Random.Range(0, 2);
            // Debug.Log(r);

            //generate random no between 9 and 15
            int size = Random.Range(9, 15);
            //Debug.Log(size);
            string putTheText = "";
            //if generate no is zero then a  string made up of x,a,1  is added inside a varibale nn\
            

            if (i < 10)

            {

                putTheText = "" + randBlanced(size);
total = total + 1;

            }
            //if generated no is not zero 1 or 2 then in the string we will add the palindrome
            else 
            {
                
                putTheText = "" + RandomString(size);

            }
            //here the spawner is spawing the cubes at random position
            gameobject = Instantiate(collectables[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            g = gameobject;
            //the value of text-string is added on a string x decalred in rorate.cs file
            gameobject.GetComponent<Rotate_>().x = putTheText;
            //the string in whihc either the palindrom or not a palindrom no is added is adjusted on the text on cube
            g.GetComponentInChildren<TextMesh>().text = putTheText;
        }
    }
    //we have to generate the random number between 9 and 15 so in the function the integare size have a random no between 9 to 15
    private string RandomString(int limit)
    {
        //my string
        string my_name = "(xa1)";
        //char abc= _chars[Random.Range(0, 3)];
        //Debug.Log(abc);
        //an array of characters is created 
        char[] place = new char[limit];
        //here we are foricng the random no function to generate the random number from x or a or 1  and it will do it for the number of times between 9 to 15 then make an array of these number with in the range of 9 to 15 and return it as a string and wew will get a zero number a the top it will show that string whihc is not surely a palindrome upon the cube as text

        int i;
        for (i = 0; i < limit; i++)
        {
            //let say 0 is generated and in the array of _chars  x is at the first location so in te array  x will go 
            place[i] = my_name[Random.Range(0, 3)];

        }

        return new string(place);
    }
    //the case when we got a random number 1 or 2 
    public string randBlanced(int args)
    {
string name="(a1)";

        char[] place_palindrome = new char[args];
        
        //in 2 blocks of array x is add endis no of  blocks left to fill
        int back = args - 2;

        int i;
char c=name[Random.Range(0,3)];
 
       
if(args == 9 || args ==11 ||args == 13 || args ==15)
{
 
place_palindrome[0] = 'x';
        place_palindrome[args - 2] = 'x';
place_palindrome[1] = '(';
        place_palindrome[2] = ')';
 for (i = 2; i < args+2; i++)
        {
if(c=='a')
{

place_palindrome[i+1] = 'a';
                place_palindrome[back-1] = '1';
}
else if(c=='1')
{

place_palindrome[i+1] = '1';
                place_palindrome[back-1] = 'a';
}
else if(c=='(')
{

place_palindrome[i+1] = 'a';
                place_palindrome[back-1] = '1';

}

else 
{

place_palindrome[i+1] = '1';
                place_palindrome[back-1] = 'a';
}
                back--;
                //array is filled
                if (back <= i)
                {
                    break;
                }
            }
        }
else 
{
place_palindrome[0] = 'x';
        place_palindrome[args - 1] = 'x';
for (i = 1; i < args; i++)
        {
if(c=='a')
{
place_palindrome[i] = '(';
                place_palindrome[back] = ')';
place_palindrome[i+1] = 'a';
                place_palindrome[back-1] = '1';
}
else if(c=='1')
{
place_palindrome[i] = '(';
                place_palindrome[back] = ')';
place_palindrome[i+1] = '1';
                place_palindrome[back-1] = 'a';
}
else if(c=='(')
{
place_palindrome[i] = '(';
                place_palindrome[back] = ')';
place_palindrome[i+1] = 'a';
                place_palindrome[back-1] = '1';

}

else 
{
place_palindrome[i] = '(';
                place_palindrome[back] = ')';

place_palindrome[i+1] = '1';
                place_palindrome[back-1] = 'a';
}
                back--;
                //array is filled
                if (back <= i)
                {
                    break;
                }
            }
           
            //one block is filled again now end will be decremented
           
        }

        return new string(place_palindrome);
    }
    public int NoOfPalind()
    {
        return total;
    }
}