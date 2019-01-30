using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckOrNot : MonoBehaviour
{
    public Sprite check, cross;
    public Image username, password, confirmPassword;

    public InputField user, pas, conPas;


    void Start()
    {
        user.onValueChanged.AddListener(delegate { OnValueChanged(); });
        pas.onValueChanged.AddListener(delegate { OnValueChanged(); });
        conPas.onValueChanged.AddListener(delegate { OnValueChanged(); });
    }


    private void Awake()
    {
        username.sprite = cross;
        password.sprite = cross;
        confirmPassword.sprite = cross;
    }
    
    void OnValueChanged()
    {
        print("Value changed...");
        if (user.text != "")
        {
            username.sprite = check;
        }
        else
        {
            username.sprite = cross;
        }

        if (pas.text != "")
        {
            password.sprite = check;
        }
        else
        {
            password.sprite = cross;
        }

        if (conPas.text.Equals(pas.text) && conPas.text != "")
        {
            confirmPassword.sprite = check;
        }
        else
        {
            confirmPassword.sprite = cross;
        }
    }

    public void Register()
    {
        if(username.sprite == check && password.sprite == check && confirmPassword.sprite == check)
        {
            print("Username: " + user.text + ", Password: " + pas.text);
        }
        else
        {
            print("Fill the form out correctly :)");
        }
    }

}
