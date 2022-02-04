using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject model;
    public GameObject Name;
    public GameObject panel;
    public GameObject Aftertext;
    public GameObject BackButton;
    public GameObject Keys;

    void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward,out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if(go.name == "InfoKey")
            {
                model.SetActive(false);
                Name.SetActive(false);
                Aftertext.SetActive(true);
                Aftertext.GetComponent<Animator>().Play("Welcome");
                BackButton.SetActive(true);
                panel.SetActive(true);
                panel.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.GetComponent<Animator>().Play("InfoPanel");
                Keys.SetActive(false);
                
            }
            if(go.name == "Attendance")
            {
                panel.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                //panel.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                go.transform.GetChild(1).gameObject.SetActive(true);
                go.transform.GetChild(1).gameObject.GetComponent<Animator>().Play("AttendancePanel");
            }
            if (go.name == "TimeTable")
            {
                go.transform.GetChild(1).gameObject.SetActive(true);
                go.transform.GetChild(1).gameObject.GetComponent<Animator>().Play("InfoText");
                //panel.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                
            }
            if (go.name == "Notification")
            {
                panel.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                //panel.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                go.transform.GetChild(1).gameObject.SetActive(true);
                go.transform.GetChild(1).gameObject.GetComponent<Animator>().Play("Notification");
            }
            if (go.name == "Back")
            {
                model.SetActive(true);
                Name.SetActive(true);
                Aftertext.SetActive(false);
                BackButton.SetActive(false);
                panel.SetActive(false);
                Keys.SetActive(true);
                panel.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                panel.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
