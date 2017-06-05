public static class TextPosition
{
    public static class Right
    {
        public static readonly float RightToLeft_Z = 0;
        public static readonly N3dsButton Previous = N3dsButton.Up;
        public static readonly N3dsButton Next = N3dsButton.Down;
        public static readonly N3dsButton BigPrevious = N3dsButton.L;
        public static readonly N3dsButton BigNext = N3dsButton.R;
    }
    public static class Left
    {
        public static readonly float LeftToRight_Z = 180;
        public static readonly N3dsButton Previous = N3dsButton.B;
        public static readonly N3dsButton Next = N3dsButton.X;
        public static readonly N3dsButton BigPrevious = N3dsButton.R;
        public static readonly N3dsButton BigNext = N3dsButton.L;
    }
}
