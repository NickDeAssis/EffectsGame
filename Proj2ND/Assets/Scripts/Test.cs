using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Variables that run the tests
    private int dayNum = 1;
    private bool isMale = true;
    private bool isTall = true;
    // creates a variable named cubedNum which is equal to the returned value of the method Cube with the value of 5 passed in
    private int cubedNum = Cube(5);
    private int index = 1;
    int[] luckyNumbers = { 1, 6, 15, 16, 24, 40 };
    int[,] myArray =
    {
        {7,8 },
        {9,19 }
    };
    
    Book book1 = new Book("GreenWeen","Batman","400", "R321"); 
    // Start is called before the first frame update
    void Start()
    {
        //Using the method SayHi which we have to pass in a string and a int  which will say hi and tell me my age
        SayHi("Nick", 28);

        //writes to console the value of the cubedNum variable which is calculed using the cubed method
        Debug.Log(cubedNum);


        //if statement logic using the variables declared above testing  writes and out put if the two condtions are true and if not writes a different out put 
        if (isMale && isTall)
        {
            Debug.Log("You are a tall man!");
        }
        else
        {
            Debug.Log("You are either not male or not tall");
        }

        //writes to console the out put of the GetDay method which uses a switch statement to get the day of the week
        Debug.Log(GetDay(dayNum));


        //while loops to write to console the current index
        while (index <= 5)
        {
            Debug.Log(index);
            index++;
        }


        // do while loops which write to console the current index
        do
        {
            Debug.Log(index);
            index++;
        } while (index <= 5);

        
        //for loop that writes to console the luckyNumber in an Array inistlised in the variable section 
        //for loops takes an initializing variable ,then the consitions to itirate through, then the a itiration
        for(int i=0; i < luckyNumbers.Length; i++)
        {
            Debug.Log(luckyNumbers[i]);
        }
        Debug.Log(luckyNumbers.Length);

        Debug.Log(myArray[1, 1]);


    }
      
    // Update is called once per frame
    void Update()
    {

    }

    //SayHi method 
    static void SayHi(string name, int age)
    {
        //takes string and int and put them into this brick of code
        Debug.Log("Hello " + name + " you are " + age);
    }

    //Cube method
    static int Cube(int num)
    {
        //Cubes the inputed interger by timesing by itself 3 times returns the result
        int result = num * num * num;
        return result;
    }

    //GetDay Method take the inter passed and returns the day of weeke related unfinished
    static string GetDay(int dayNum)
    {
        string dayName;

        //switch statement that returns day of the week or invalid if a incorrect value is passed through
        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            default:
                dayName = "Invalid Day";
                break;
        }

        return dayName;
    }
}
