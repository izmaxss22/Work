
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ClickScreenView _clickScreenView;
    private ClickScreenControler _clickScreenControler;
    // Start is called before the first frame update
    void Start()
    {
        var clickScreenModel = new ClickScreenModel();
        _clickScreenControler = new ClickScreenControler(
            _clickScreenView,
            clickScreenModel);
    }
}
