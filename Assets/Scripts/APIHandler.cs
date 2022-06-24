using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class ChallengerAPI : MonoBehaviour
{
    private const string URL = "https://api-game1.challengers.tech/v1/";
    private const string API_KEY = "ENTER_YOUR_API_KEY_HERE";

    public void GenerateRequest()
    {
        StartCoroutine(ProcessRequest(URL));
    }

    private IEnumerator ProcessRequest(string uri)
    {
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            request.SetRequestHeader("X-ChallengerAPI-Key", API_KEY);

            yield return request.SendWebRequest();

            if (request.isNetworkError)
            {
                Debug.Log("Error: " + request.error);
            }
            else
            {
                Debug.Log("Received: " + request.downloadHandler.text);
            }
        }
    }
}