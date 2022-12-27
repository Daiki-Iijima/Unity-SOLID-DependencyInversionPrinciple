using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver3 {
    public enum ShipInputType {
        AI,
        Controller,
    }

    public class ShipInputFactory : IInputFactory {
        public IShipInput Create(ShipInputType type) {
            switch (type) {
                case ShipInputType.AI: {
                        return new AiInput();
                    }
                case ShipInputType.Controller: {
                        return new ControllerInput();
                    }
            }

            return null;
        }

    }
}
