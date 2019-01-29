﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cognitics.GeoPackage
{
    public class Table
    {
        public string Name;
        public string DataType;
        public string Identifier;
        public string Description;
        public DateTime LastChange;
        public double MinX;
        public double MinY;
        public double MaxX;
        public double MaxY;
        public long SpatialReferenceSystemID;
    }
}
