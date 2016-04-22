using UnityEngine;
using System.Collections;

public class ballControlloer : MonoBehaviour {
    public GameObject ballEffPrefab;
    private GameObject agents;

    public delegate void DestinationUpdate(Transform dest);
    public static DestinationUpdate destUpdate;

    void Awake()
    {
        agents = GameObject.Find("Agents");
        StartCoroutine(ballEvent());
    }

    IEnumerator ballEvent()
    {
        yield return new WaitForSeconds(2f);

        //agents.BroadcastMessage("DestUpdate", this.transform);
        destUpdate(transform);

        GameObject balleff = Instantiate(ballEffPrefab, transform.position, Quaternion.identity) as GameObject;

        Destroy(this.gameObject);
        Destroy(balleff.gameObject, 2f);
    }
}
