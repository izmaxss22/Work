using UnityEngine;

namespace CubeMover.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        [SerializeField] private MapItemsManager _mapItemsManager;
        [SerializeField] private GameUIManager _gameUIManager;

        private void Awake()
        {
            Instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            _gameUIManager.Init();
            _mapItemsManager.Init(
                _gameUIManager.TimeBetweenCreatingCubes,
                _gameUIManager.TimeBetweenCreatingCubes,
                _gameUIManager.CubeMovingDistance);
        }

        #region СОБЫТИЯ ОТ UI MANAGER
        public void OnChangeTimeBetweenCreatingCubes(int timeBetweenCreatingCubes)
        {
            _mapItemsManager.OnChangeTimeBetweenCreatingCubes(timeBetweenCreatingCubes);
        }
        public void OnChangeCubeMovingSpeed(int cubeMovingSpeed)
        {
            _mapItemsManager.OnChangeCubeMovingSpeed(cubeMovingSpeed);

        }
        public void OnChangeCubeMovingDistance(int cubeMovingDistance)
        {
            _mapItemsManager.OnChangeCubeMovingDistance(cubeMovingDistance);
        }
        #endregion
    }
}