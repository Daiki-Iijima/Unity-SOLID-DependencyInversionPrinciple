using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ver3 {
    public interface IInputFactory {
        IShipInput Create(ShipInputType type);
    }
}
