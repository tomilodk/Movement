using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateUserManager : MonoBehaviour
{
    public Sprite check, cross;
    public Image username, password, confirmPassword;

    public InputField user, pas, conPas;

    public string url;

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
            StartCoroutine(ReachSite());
        }
        else
        {
            print("Fill the form out correctly :)");
        }
    }

    private IEnumerator ReachSite()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", user.text);
        form.AddField("password", pas.text);

        WWW www = new WWW(url, form);

        yield return www;


        if(www.text == "0")
        {
            print("User created successfully :)");
            
        }
        else
        {
            print(www.text);
        }
    }

}
