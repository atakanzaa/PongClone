using UnityEngine.EventSystems;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{

    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>(); // carptigi andaki topun bilgilerini alir.

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current); //saga duvara carptiginda playerin score
            //sol duvara carptiginda computerin score artacak.
            //trigger kullanarak editörde duzenleme yapacaðiz.
            scoreTrigger.Invoke(eventData);
        }
    }
}
