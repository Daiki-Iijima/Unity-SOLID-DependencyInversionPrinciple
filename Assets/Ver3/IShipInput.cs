using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver3 {
    public interface IShipInput {
        void ReadInput();
        float Rotation { get; }
        float Thrust { get; }
    }
}
