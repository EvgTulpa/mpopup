using DG.Tweening;
using UnityEngine;

namespace main.popups
{
    public class FeatureOneMurkaOnlyViewPopupProcessor : MurkaOnlyViewPopupProcessor
    {
        protected override void AfterPopupClosedProcess()
        {
            base.AfterPopupClosedProcess();
            CloseablePopup.transform.DOLocalMove(new Vector3(1000, 0, 0), 3.0f).OnComplete(MoveComplete);
        }
        
        private void MoveComplete()
        {
            DestroyImmediate(CloseablePopup.gameObject);   
        }
    }
}