﻿using System;
namespace NRedisTimeSeries.Commands
{
    public class CommandArgs
    {
        public static string RETENTION => "RETENTION";
        public static string LABELS => "LABELS";
        public static string UNCOMPRESSED => "UNCOMPRESSED";
        public static string COUNT => "COUNT";
        public static string AGGREGATION => "AGGREGARION";
        public static string FILTER => "FILTER";
        public static string WITHLABELS => "WITHLABELS";
        public static string TIMESTAMP => "TIMESTAMP";
    }
}
