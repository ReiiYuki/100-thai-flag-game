using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;
public class ConnectFacebook : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        if (Application.internetReachability == NetworkReachability.NotReachable||!FB.IsInitialized)
            gameObject.SetActive(false);
        SetText();
	}
	
    public void SetText()
    {
        if (FB.IsLoggedIn)
        {
            if (PlayerPrefs.GetString("lang") == "th")
                GetComponentInChildren<Text>().text = "ออกจาก Facebook";
            else
                GetComponentInChildren<Text>().text = "Disconnect From Facebook";
        }
        else
        {
            if (PlayerPrefs.GetString("lang") == "th")
                GetComponentInChildren<Text>().text = "เชื่อมต่อไปยัง Facebook";
            else
                GetComponentInChildren<Text>().text = "Connect to Facebook";
        }
    }

	public void OnClick()
    {
        if (FB.IsLoggedIn)
        {
            FB.LogOut();
            if (PlayerPrefs.GetString("lang") == "th")
                GetComponentInChildren<Text>().text = "เชื่อมต่อไปยัง Facebook";
            else
                GetComponentInChildren<Text>().text = "Connect to Facebook";
        }
        else
        {
            var perms = new List<string>() { "public_profile", "email", "user_friends" };
            FB.LogInWithReadPermissions(perms, AuthCallback);
        }
    }

    private void AuthCallback(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            FB.LogInWithPublishPermissions(new List<string>() { "publish_actions" });
            SetText();
        }
        else
        {
            Debug.Log("User cancelled login");
        }
    }
}
