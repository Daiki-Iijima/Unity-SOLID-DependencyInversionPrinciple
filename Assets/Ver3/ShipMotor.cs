using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver3 {

    public class ShipMotor {

        private readonly IShipInput _shipInput;
        private readonly Transform _transformToMove;
        private readonly ShipSettings _shipSettings;

        public ShipMotor(IShipInput shipInput, Transform transformToMove, ShipSettings shipSettings) {
            _shipInput = shipInput;
            _transformToMove = transformToMove;
            _shipSettings = shipSettings;
        }

        /// <summary>
        /// 1フレームごとのアップデートで呼び出す予定
        /// </summary>
        public void Tick() {
            //  回転
            _transformToMove.Rotate(Vector3.up * _shipInput.Rotation * Time.deltaTime * _shipSettings.TurnSpeed);
            //  前進
            _transformToMove.position += _transformToMove.forward * _shipInput.Thrust * Time.deltaTime * _shipSettings.MoveSpeed;
        }
    }
}
