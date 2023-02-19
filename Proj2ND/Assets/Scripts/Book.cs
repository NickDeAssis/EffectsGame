using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{

    public string title;
    public string author;
    public string pages;
    private string rating;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Book(string aTitle,string aAuthor,string aPages, string aRating)
    {
        title = aTitle;
        author = aAuthor;
        pages = aPages;
        Rating = aRating;

        Debug.Log("You made a book!");
        Debug.Log("Your book's name is "+ title );
        Debug.Log("Your book's author is " + author);
        Debug.Log("Your book has " + pages + " pages");
        Debug.Log("Your book is rated " + Rating);
    }

    public string Rating
    {
        get { return rating; }
        set { 
        
            if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
            {
                rating = value;
            }
            else
            {
                rating = "NR";
            }
        }
    }
}
