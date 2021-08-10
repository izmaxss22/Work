using System;

public class ClickScreenModel
{
    public Action<int> ONChangeClickCounts;

    private int _clickCounts;
    public int ClickCounts
    {
        get => _clickCounts;
        private set
        {
            _clickCounts = value;
            ONChangeClickCounts?.Invoke(_clickCounts);
        }
    }

    public void OnClickButtonForCliks()
    {
        ClickCounts++;
    }
}
