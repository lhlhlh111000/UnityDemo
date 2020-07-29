using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG173 : MonoBehaviour
{

    GameObject QRCodeGO;

    void Start()
    {
        GameObject.Find("BtnLogin").GetComponent<Button>()
            .onClick
            .AddListener(ShowLoginQRCode);

        QRCodeGO = GameObject.Find("QRCodeImage");
        QRCodeGO.SetActive(false);

    }

    void Update()
    {
        
    }

    private void ShowLoginQRCode()
    {
        if (!QRCodeGO.activeSelf)
        {
            Debug.Log("Show");
            QRCodeImage qRCodeImage = QRCodeGO.GetComponent<QRCodeImage>();
            StartCoroutine(qRCodeImage.Show());
            //qRCodeImage.Show();
        }
        
        Debug.Log("Hello");
    }
}