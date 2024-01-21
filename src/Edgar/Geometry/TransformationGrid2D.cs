namespace Edgar.Geometry
{
    /// <summary>
    /// 转换类型枚举
    /// </summary>
    public enum TransformationGrid2D
    {
        /// <summary>
        /// 单位矩形转换 即不变
        /// </summary>
        Identity,

        /// <summary>
        /// 旋转90度 Rotations are clockwise
        /// </summary>
        Rotate90,

        /// <summary>
        /// 旋转180度 Rotations are clockwise
        /// </summary>
        Rotate180,

        /// <summary>
        /// 旋转270度 Rotations are clockwise
        /// </summary>
        Rotate270,

        /// <summary>
        /// 沿X轴镜像
        /// </summary>
        MirrorX,

        /// <summary>
        /// 沿Y轴镜像
        /// </summary>
        MirrorY,

        //<image url="$(ProjectDir)\DocumentImages\Diagonal13.png"/>
        /// <summary>
        /// 13对角线
        /// </summary>
        Diagonal13,

        //<image url="$(ProjectDir)\DocumentImages\Diagonal24.png"/>
        /// <summary>
        /// 24对角线
        /// </summary>
        Diagonal24
    }
}