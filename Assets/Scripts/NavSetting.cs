using UnityEngine;
using System.Collections;

public class NavSetting : MonoBehaviour {

	void Start () {
        ballControlloer.destUpdate += DestUpdate;
    }

    void DestUpdate(Transform goal)
    {
        //たまに無視
        if(Random.Range(0,20) > 0)
        {
            GetComponent<NavMeshAgent>().SetDestination(goal.transform.position);
        }

    }
}
