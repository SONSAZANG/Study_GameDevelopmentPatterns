using UnityEngine;

namespace Chapter.EventBus
{

    public class HUDController : MonoBehaviour
    {
        private bool isDisplayOn;

        private void OnEnable()
        {
            RaceEventBus.Subscribe(RaceEventType.START, DisplayHUD);
        }

        private void OnDisable()
        {
            RaceEventBus.Unsubscribe(RaceEventType.START, DisplayHUD);
        }

        private void DisplayHUD()
        {
            isDisplayOn = true;
        }

        private void OnGUI()
        {
            if (isDisplayOn)
            {
                if (GUILayout.Button("Stop Race"))
                {
                    isDisplayOn = false;
                    RaceEventBus.Publish(RaceEventType.STOP);
                }
            }
        }
    }


}
