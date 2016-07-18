﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Proxy.RealWorld
{
    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }

    class Math : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }
    }

    class MathProxy : IMath
    {
        private Math _math = new Math();

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }

        public double Div(double x, double y)
        {
            return _math.Div(x, y);
        }

        public double Mul(double x, double y)
        {
            return _math.Mul(x, y);
        }

        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }
    }
}
