using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver3 {
    public class Ship : MonoBehaviour {
        [SerializeField] private ShipSettings _shipSettings;

        private IInputFactory _inputFactory;
        private IShipInput _shipInput;
        private ShipMotor _shipMotor;

        void Start() {

            _inputFactory = new ShipInputFactory();

            _shipInput = _inputFactory.Create(_shipSettings.InputType);

            _shipMotor = new ShipMotor(_shipInput,this.transform,_shipSettings);
        }

        void Update() {
            //  入力の読み取り
            _shipInput.ReadInput();

            //  船の更新
            _shipMotor.Tick();
        }
    }
}
