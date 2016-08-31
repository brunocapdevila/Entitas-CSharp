﻿using System.Collections.Generic;
using Entitas;
using System;

public class ListGetItem : IPerformanceTest {
    const int n = 100000;
    Random _random;
    List<Entity> _l;

    public void Before() {
        _random = new Random();
        _l = new List<Entity>();
        for (int i = 0; i < n; i++) {
            var e = new Entity();
            e.Setup(0, CP.NumComponents, null);
            _l.Add(e);
        }
    }

    public void Run() {
        for (int i = 0; i < n; i++) {
            var e = _l[_random.Next(0, n)];
        }
    }
}

