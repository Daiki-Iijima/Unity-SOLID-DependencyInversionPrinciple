using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver2 {
    /// <summary>
    /// �D�̈ړ�
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

            //  ��]
            transform.Rotate(Vector3.up * rotation * Time.deltaTime * setting.TurnSpeed);
            //  �O�i
            transform.position += transform.forward * thrust * Time.deltaTime * setting.MoveSpeed;
        }
    }
}
