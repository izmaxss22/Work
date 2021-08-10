using UnityEngine;
using UnityEngine.UI;

namespace CubeMover.Scripts
{
    public class GameUIManager : MonoBehaviour
    {
        [SerializeField] private InputField _inputFieldForTimeBetweenCreatingCubes;
        [SerializeField] private InputField _inputFieldForCubeMovingSpeed;
        [SerializeField] private InputField _inputFieldForCubeMovingDistance;

        public int TimeBetweenCreatingCubes
        {
            get => int.Parse(_inputFieldForTimeBetweenCreatingCubes.text);
        }
        public int CubeMovingSpeed
        {
            get => int.Parse(_inputFieldForCubeMovingSpeed.text);
        }
        public int CubeMovingDistance
        {
            get => int.Parse(_inputFieldForCubeMovingDistance.text);
        }

        public void Init()
        {
            SetInputFieldListeners();
            void SetInputFieldListeners()
            {
                _inputFieldForTimeBetweenCreatingCubes.onValueChanged.AddListener(
                    (newValue) => OnChangeTimeBetweenCreatingCubes(newValue));
                _inputFieldForCubeMovingSpeed.onValueChanged.AddListener(
                    (newValue) => OnChangeCubeMovingSpeed(newValue));
                _inputFieldForCubeMovingDistance.onValueChanged.AddListener(
                    (newValue) => OnChangeCubeMovingDistance(newValue));
            }
        }

        private void OnChangeTimeBetweenCreatingCubes(string newValue)
        {
            GameManager.Instance.OnChangeTimeBetweenCreatingCubes(TimeBetweenCreatingCubes);
        }
        private void OnChangeCubeMovingSpeed(string newValue)
        {
            GameManager.Instance.OnChangeCubeMovingSpeed(CubeMovingSpeed);
        }
        private void OnChangeCubeMovingDistance(string newValue)
        {
            GameManager.Instance.OnChangeCubeMovingDistance(CubeMovingDistance);

        }
    }
}