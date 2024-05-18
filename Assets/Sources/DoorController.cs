using System.Collections;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimator;  // Reference to the Animator component on the Door Object
    public float delayBeforeClose = 3f;

    private void Start()
    {
        if (doorAnimator == null)
        {
            Debug.LogError("Door Animator not set on " + gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopAllCoroutines();
            doorAnimator.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimator.SetTrigger("Close");
        }
    }

    /*private IEnumerator CloseDoorAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeClose);
        doorAnimator.SetTrigger("Close");
    }*/
}
