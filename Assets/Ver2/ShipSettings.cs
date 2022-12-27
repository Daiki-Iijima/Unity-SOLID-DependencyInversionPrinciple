using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver2 {
    /// <summary>
    /// 船のパラメーターの設定
    /// </summary>
    [CreateAssetMenu(menuName = "Ship/Settings", fileName = "ShipDataVer2")]
    public class ShipSettings : ScriptableObject {
        [SerializeField] private float _turnSpeed = 25f;
        [SerializeField] private float _moveSpeed = 10f;

        public float TurnSpeed { get { return _turnSpeed; } }
        public float MoveSpeed { get { return _moveSpeed; } }
    }
}
