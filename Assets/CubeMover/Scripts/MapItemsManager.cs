using System.Collections;
using UnityEngine;

namespace CubeMover.Scripts
{
    public class MapItemsManager : MonoBehaviour
    {
        [SerializeField] private Transform contForCreatedItems;
        [SerializeField] private GameObject _prefabForCube;
        private Coroutine _cubeCreatorCoroutine;

        private int _timeBetweenCreatingCubes;
        private int _cubeMovingSpeed;
        private int _cubeMovingDistance;

        private void OnDestroy()
        {
            StopCoroutine(_cubeCreatorCoroutine);
        }

        public void Init(
            int timeBetweenCreatingCubes,
            int cubeMovingSpeed,
            int cubeMovingDistance)
        {
            _timeBetweenCreatingCubes = timeBetweenCreatingCubes;
            _cubeMovingSpeed = cubeMovingSpeed;
            _cubeMovingDistance = cubeMovingDistance;

            _cubeCreatorCoroutine = StartCoroutine(CubeCreatorCoroutine());
        }

        private IEnumerator CubeCreatorCoroutine()
        {
            while (true)
            {
                var cube = Instantiate(_prefabForCube, contForCreatedItems);
                cube.GetComponent<MovableCube>().Init(_cubeMovingSpeed, _cubeMovingDistance);
                yield return new WaitForSeconds(_timeBetweenCreatingCubes);
            }
        }

        #region СОБЫТИЯ ИЗ ГМ
        public void OnChangeTimeBetweenCreatingCubes(int timeBetweenCreatingCubes)
        {
            _timeBetweenCreatingCubes = timeBetweenCreatingCubes;
        }
        public void OnChangeCubeMovingSpeed(int cubeMovingSpeed)
        {
            _cubeMovingSpeed = cubeMovingSpeed;
        }
        public void OnChangeCubeMovingDistance(int cubeMovingDistance)
        {
            _cubeMovingDistance = cubeMovingDistance;
        }
        #endregion
    }
}

