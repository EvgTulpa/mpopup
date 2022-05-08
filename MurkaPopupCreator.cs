using System;
using System.Linq;
using UnityEngine;

namespace main.popups
{
    [RequireComponent(typeof(CloseablePopup))]
    public sealed class MurkaPopupCreator : AbstractPopup
    {
        [SerializeField] private MurkaPopupCreatorData Data;
        [SerializeField][ValidateField(typeof(IPopupProcessor))] private MonoBehaviour[] BeforeCreatePopupProcessors;
        [SerializeField][ValidateField(typeof(IPopupProcessor))] private MonoBehaviour[] AfterCreatePopupProcessors;
        public void AddPopup()
        {
            BeforeCreatePopupProcessors.OfType<IPopupProcessor>().ToList().ForEach(e=>e.Process(this, Data));
            PopupCreator.addPopup(new PopupInfo(Data.PopupName, gameObject, Data.Priority));
        }
        
        private void Start()
        {
            AfterCreatePopupProcessors.OfType<IPopupProcessor>().ToList().ForEach(e=>e.Process(this, Data));
        }

        public override void setParams(object param)
        {
            
        }
    }

    [Serializable]
    public class MurkaPopupCreatorData
    {
        public bool OnlyView;
        public string PopupName;
        public int Priority;
        public bool IgnoringPopup;
    }
}