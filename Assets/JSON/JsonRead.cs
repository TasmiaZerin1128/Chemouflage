using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsonRead : MonoBehaviour
{
    public TextAsset JSONtext;
    public string info;
    public Text infoText;

    [System.Serializable]
    public class element
    {
        public string name;
        public string atomic_mass;
        public string symbol;
        public int atomic_number;
    }

    [System.Serializable]
    public class elementslist
    {
        public element[] elements;
    }

    public elementslist elemlist = new elementslist();
    void Start()
    {
        elemlist = JsonUtility.FromJson<elementslist>(JSONtext.text);
        info = "Name: " + elemlist.elements[0].name+ " "+ elemlist.elements[0].symbol + "\nAppearance: " + "\n\n\n\nhi\nhi\nhi" +
            "\nhi\nhi\nhi\n\n\n\n\nhi\nhi\nhi\nhi\nhi\nhi";
        infoText.text = info;
    }
}
