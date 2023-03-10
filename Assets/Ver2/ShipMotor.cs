using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver2 {
    /// <summary>
    /// 船の移動
    /// </summary>
    [RequireComponent(typeof(ShipInput))]
    public class ShipMotor : MonoBehaviour {

        [SerializeField] private ShipSettings setting;

        private ShipInput _shipInput;

        private void Awake() {
            _shipInput = GetComponent<ShipInput>();
        }

        private void Update() {
            float rotation = _shipInput.Rotation;
            float thrust = _shipInput.Thrust;

            //  回転
            transform.Rotate(Vector3.up * rotation * Time.deltaTime * setting.TurnSpeed);
            //  前進
            transform.position += transform.forward * thrust * Time.deltaTime * setting.MoveSpeed;
        }
    }
}
