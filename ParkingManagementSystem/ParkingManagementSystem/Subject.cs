﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public interface Subject
    {
        public void NotifyObservers() { }
        public void AddObserver(int id) { }
        public void RemoveObserver(int id) { }
    }
}