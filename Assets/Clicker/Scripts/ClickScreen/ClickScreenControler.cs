

public class ClickScreenControler
{
    private readonly ClickScreenView _clickScreenView;
    private readonly ClickScreenModel _clickScreenModel;

    public ClickScreenControler(ClickScreenView clickScreenView, ClickScreenModel clickScreenModel)
    {
        _clickScreenView = clickScreenView;
        _clickScreenModel = clickScreenModel;

        SetViewEvents();
        SetModelEvents();

        void SetViewEvents()
        {
            _clickScreenView.ONClickButtonForClicks += OnClickButtonForClicks;
        }
        void SetModelEvents()
        {
            _clickScreenModel.ONChangeClickCounts += OnChangeClickCounts;
        }
    }

    #region EVENTS FROM VIEW
    private void OnClickButtonForClicks()
    {
        _clickScreenModel.OnClickButtonForCliks();
    }
    #endregion

    #region  EVENTS FROM MODEL
    private void OnChangeClickCounts(int clickCounts)
    {
        _clickScreenView.OnChangeClickCounts(clickCounts);
    }
    #endregion
}
