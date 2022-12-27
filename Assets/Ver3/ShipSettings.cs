using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver3 {
    /// <summary>
    /// 船のパラメーターの設定
    /// </summary>
    [CreateAssetMenu(menuName = "Ship/Settings", fileName = "ShipData")]
    public class ShipSettings : ScriptableObject {
        [SerializeField] private float _turnSpeed = 25f;
        [SerializeField] private float _moveSpeed = 10f;
        [SerializeField] private ShipInputType _inputType = ShipInputType.AI;

        public float TurnSpeed { get { return _turnSpeed; } }
        public float MoveSpeed { get { return _moveSpeed; } }
        public ShipInputType InputType { get { return _inputType; } }
    }
}
