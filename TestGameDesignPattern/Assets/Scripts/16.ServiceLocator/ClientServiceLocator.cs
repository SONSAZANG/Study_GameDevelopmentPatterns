using UnityEngine;

namespace Chapter.ServiceLocator
{
    public class ClientServiceLocator : MonoBehaviour
    {
        private void Start()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            ILoggerService logger = new Logger();
            ServiceLocator.RegisterService(logger);

            IAnlyticsService analytics = new Analytics();
            ServiceLocator.RegisterService(analytics);

            IAdvertisement advertisement = new Advertisement();
            ServiceLocator.RegisterService(advertisement);
        }

        private void OnGUI()
        {
            GUILayout.Label("Review output in the console:");

            if (GUILayout.Button("Log Event"))
            {
                ILoggerService logger = ServiceLocator.GetService<ILoggerService>();
                logger.Log("Hello World");
            }

            if (GUILayout.Button("Send Analytics"))
            {
                IAnlyticsService analytics = ServiceLocator.GetService<IAnlyticsService>();
                analytics.SendEvent("Hello World!");
            }

            if (GUILayout.Button("Display Advertisement"))
            {
                IAdvertisement advertisement = ServiceLocator.GetService<Advertisement>();
                advertisement.DisplayAd();
            }
        }
    }
}