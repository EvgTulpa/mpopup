namespace main.popups
{
    public interface IPopupProcessor
    {
        void Process(MurkaPopupCreator popupCreator, MurkaPopupCreatorData data);
    }
}