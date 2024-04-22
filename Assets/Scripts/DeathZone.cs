using UnityEngine;
using UnityEngine.EventSystems;

public class DeathZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent liveTrigger;
    void OnCollisionEnter2D(Collision2D coll)
    {
        Ball ball = coll.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            BaseEventData eventData = new(EventSystem.current);
            this.liveTrigger.Invoke(eventData);
        }
    }
}