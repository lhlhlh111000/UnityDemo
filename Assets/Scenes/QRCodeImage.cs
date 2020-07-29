using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class QRCodeImage : MonoBehaviour
{

    private string imageUrl = "https://img04.sogoucdn.com/app/a/100520076/a5ec7bf55c2e54146b92abf35e1b7503";


    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
    }

    public IEnumerator Show()
    {
        WWW www = new WWW(imageUrl);
        yield return www;

        if (null != www && string.IsNullOrEmpty(www.error))
        {
            gameObject.SetActive(true);
            Texture2D texture = www.texture;
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            transform.GetComponent<Image>().sprite = sprite;
            Debug.Log("qrcode");
        }else
        {
            Debug.Log("error");
        }
    }
}
