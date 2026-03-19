using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent OnPulled;

    private bool isUsed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
   private void Update()
    {
        if (isUsed) return;

        if(Input.GetKeyDown(KeyCode.E))
        {
            isUsed = true;
            Debug.Log("레버를 당겼다.");
            OnPulled.Invoke();
        }
    }
}
