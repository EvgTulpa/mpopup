using UnityEngine;

namespace main.popups
{
    public class TestPopupSpawner : MonoBehaviour
    {
        [SerializeField] private MurkaPopupCreator Popup;
        
        [ContextMenu("CreatePopup")]
        private void CreatePopup()
        {
            Popup.AddPopup();
        }
    }
}