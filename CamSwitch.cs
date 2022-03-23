using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject scam1;
    public GameObject scam2;
    public GameObject scam3;
    public GameObject scam4;
    public GameObject MainCamera;

    void Update()
    {
        if (Input.GetButtonDown("0Key"))
        {
            MainCamera.SetActive(true);
            scam1.SetActive(false);
            scam2.SetActive(false);
            scam3.SetActive(false);
            scam4.SetActive(false);

        }
        if (Input.GetButtonDown("1Key"))
        {
            MainCamera.SetActive(false);
            scam1.SetActive(true);
            scam2.SetActive(false);
            scam3.SetActive(false);
            scam4.SetActive(false);

        }
        if (Input.GetButtonDown("2Key"))
        {
            MainCamera.SetActive(false);
            scam1.SetActive(false);
            scam2.SetActive(true);
            scam3.SetActive(false);
            scam4.SetActive(false);

        }
        if (Input.GetButtonDown("3Key"))
        {
            MainCamera.SetActive(false);
            scam1.SetActive(false);
            scam2.SetActive(false);
            scam3.SetActive(true);
            scam4.SetActive(false);

        }
        if (Input.GetButtonDown("4Key"))
        {
            MainCamera.SetActive(false);
            scam1.SetActive(false);
            scam2.SetActive(false);
            scam3.SetActive(false);
            scam4.SetActive(true);

        }
    }
}
