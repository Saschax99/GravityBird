using System.Collections;
using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
    public GameObject Plane;

    IEnumerator Wait(float waitTime)
    {
        Debug.Log("endwaiting");
        Vector3 spawn1 = new Vector3(Camera.main.transform.position.x + 4.22f, 4.22f, 0);
        yield return new WaitForSeconds(waitTime);
        Instantiate(this.Plane, spawn1, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnteredTrigger = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EnteredTrigger = false;
        targetTime = 4f;
    }
    void StartSpawning()
    {
        Debug.Log("startwaiting");
        StartCoroutine(Wait(4f));
    }

    float targetTime = 4f;
    bool EnteredTrigger = false;

    private void Update()
    {
        if (EnteredTrigger)
        {
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f)
            {
                if (EnteredTrigger)
                {
                    EnteredTrigger = false;
                    Vector3 spawn1 = new Vector3(Camera.main.transform.position.x + 4.22f, 4.22f, 0);
                    Instantiate(this.Plane, spawn1, Quaternion.identity);
                    targetTime = 4f;
                }
            }
        }
    }
}