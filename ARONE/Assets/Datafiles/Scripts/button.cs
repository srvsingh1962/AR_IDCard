using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/_singh_sourav_/");
    }
    public void OpenFacebook()
    {
        Application.OpenURL("https://www.facebook.com/");
    }
    public void Openlinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/sourav-singh-8a774a193/");
    }
    public void contact()
    {
        Application.OpenURL("tel:+917982517046");
    }
}


