﻿using Geometry.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Shape2D
    {

        private float _x;
        private float _y;
        private Vector2 _p1;
        private Vector2 _p2;
        private Vector2 _p3;

        public override float Circumference => Vector2.Distance(_p1, _p2) + Vector2.Distance(_p2, _p3) + Vector2.Distance(_p3, _p1);
  

        public override float Area => MathF.Abs(0.5f * (_p1.X * (_p2.Y - _p3.Y) + (_p2.X * (_p3.Y - _p1.Y)) + (_p3.X * (_p1.Y - _p2.Y))));

        public override string ToString() => $"triangle @({_x}, {_y}): p1({_p1.X}, {_p1.Y}), p2({_p2.X}, {_p2.Y}), p3({_p3.X}. {_p3.Y})";
     
        public override Vector3 Center => new Vector3(_x, _y, 0);
    
        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3 )
        {

            _p1 = p1;
            _p2 = p2;
            _p3 = p3;

            float _x = (_p1.X + _p2.X + _p3.X) / 3;
            float _y = (_p1.Y + _p2.Y + _p3.Y) / 3;

        }

    }
}