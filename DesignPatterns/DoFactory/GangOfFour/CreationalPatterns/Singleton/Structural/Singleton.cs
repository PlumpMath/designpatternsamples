﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Singleton.Structural
{
    public class Singleton
    {
        private static Singleton _instance;

        protected Singleton() { }

        public static Singleton Instance() {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }
    }
}
