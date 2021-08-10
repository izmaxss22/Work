using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickScreenView : MonoBehaviour
{
    public Action ONClickButtonForClicks;
    [SerializeField] private Text _textForClickCounts;
    [SerializeField] private Button _buttonForClicks;

    private void Start()
    {
        _buttonForClicks.onClick.AddListener(OnClickButtonForClicks);
    }

    private void OnClickButtonForClicks()
    {
        ONClickButtonForClicks?.Invoke();
    }

    public void OnChangeClickCounts(int newClickCounts)
    {
        _textForClickCounts.text = newClickCounts.ToString();
    }
}
