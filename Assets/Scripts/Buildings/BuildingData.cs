using UnityEngine;

namespace Buildings
{
    [CreateAssetMenu(fileName = "buildingData", menuName = "Buildings/BuildingData")]
    public class BuildingData : ScriptableObject
    {
        [SerializeField] private int _maxWorker;
        [SerializeField] private int _coinCost;
        [SerializeField] private GameObject _model;
    }
}
