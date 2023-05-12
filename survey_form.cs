using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class signinScript : MonoBehaviour
{

    [SerializeField] InputField feedback1;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSenW0Q4yML2_R4bfOg0-5MPz65IIQ8KQmstsssusfg1haV3Ig/formResponse";

    
    public void Send()
    {
        StartCoroutine(Post(feedback1.text));
    }

    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.432430516", s1);



        debug.log(s1+ " +"url);
        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        
        yield return www.SendWebRequest();

    
    if (www.isNetworkError)
{
     Debug.Log("Error: " + www.error);
}
    else
{
      Debug.Log("Success Message: " + www.downloadHandler.text);
}
}
}


}
