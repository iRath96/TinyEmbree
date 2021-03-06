﻿using System.Numerics;

namespace TinyEmbree {
    public struct Ray {
        public Vector3 Origin;
        public Vector3 Direction;
        public float MinDistance;

        public Vector3 ComputePoint(float t) => Origin + t * Direction;
    }
}
