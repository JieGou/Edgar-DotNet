namespace Edgar.Geometry
{
    public enum TransformationGrid2D
    {
        Identity,
        Rotate90, Rotate180, Rotate270, // Rotations are clockwise
        MirrorX, MirrorY,

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