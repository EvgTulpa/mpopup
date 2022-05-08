using UnityEngine;

namespace main.popups
{
    public class MurkaIgnorePopupProcessor : MonoBehaviour, IPopupProcessor
    {
        [SerializeField] private string IgnorePopupID;
        
        public void Process(MurkaPopupCreator popupCreator, MurkaPopupCreatorData data)
        {
            if (data.IgnoringPopup)
            {
                IgnorePopupID = data.PopupName;
                PopupCreator.AddCustomIgnorePopup(IgnorePopupID);
            }
        }

        private void OnDestroy()
        {
            PopupCreator.RemoveCustomIgnorePopup(IgnorePopupID);
        }
    }
}