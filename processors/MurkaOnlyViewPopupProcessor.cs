using SRF;
using UnityEngine;

namespace main.popups
{
    public class MurkaOnlyViewPopupProcessor : MonoBehaviour, IPopupProcessor
    {
        protected CloseablePopup CloseablePopup;
        
        public void Process(MurkaPopupCreator popupCreator, MurkaPopupCreatorData data)
        {
            if (data.OnlyView)
            {
                CloseablePopup = popupCreator.gameObject.GetComponent<CloseablePopup>();
                if (CloseablePopup != null)
                {
                    CloseablePopup.SetDestroyWhenClosed(false);
                    CloseablePopup.OnClosePopup += PopupClosed;
                }
            }
        }

        private void OnDestroy()
        {
            if (CloseablePopup != null)
            {
                CloseablePopup.OnClosePopup -= PopupClosed;
            }
        }

        private void PopupClosed()
        {
            CloseablePopup.gameObject.tag = "Untagged";
            CloseablePopup.transform.ResetLocal();
            PopupCreator.PopupClosed();
            AfterPopupClosedProcess();
        }

        protected virtual void AfterPopupClosedProcess()
        {
            
        }
    }
}