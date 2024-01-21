using System.Collections.Generic;
using System;
using System.Linq;

namespace Edgar.Legacy.Utils.Statistics
{
    /// <summary>
    /// 箱形/箱线图数据类
    /// 通过四分位法来识别离群值
    /// </summary>
    public class BoxPlotValues
    {
        private double q1;
        private double q3;

        /// <summary>
        /// 最小值
        /// </summary>
        public double Minimum { get; set; }

        /// <summary>
        /// 第一个四分位值
        /// </summary>
        public double Q1 { get => q1; set => q1 = value; }

        /// <summary>
        /// 中位数值
        /// </summary>
        public double Median { get; set; }

        /// <summary>
        /// 第3个四分位值
        /// </summary>
        public double Q3 { get => q3; set => q3 = value; }

        /// <summary>
        /// 四分位间距
        /// </summary>
        public double IQR { get => q3 - q1; }

        /// <summary>
        /// 最大值
        /// </summary>
        public double Maximum { get; set; }
    }
}