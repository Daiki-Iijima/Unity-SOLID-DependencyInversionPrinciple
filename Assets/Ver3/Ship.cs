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
            //  ì¸óÕÇÃì«Ç›éÊÇË
            _shipInput.ReadInput();

            //  ëDÇÃçXêV
            _shipMotor.Tick();
        }
    }
}
