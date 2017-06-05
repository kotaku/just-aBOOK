using UnityEngine;


public static class TextColour
{
    public static class White
    {
        public static readonly Color TextColour = new Color(0f, 0f, 0f, 1f);
        public static readonly Color BackgroundColour = new Color(255f / 255f, 255f / 255f, 255f / 255f, 0f);
    }


    public static class Sepia
    {
        public static readonly Color TextColour = new Color(67f / 255f, 44f / 255f, 28f / 255f, 1f);
        public static readonly Color BackgroundColour = new Color(246f / 255f, 239f / 255f, 221f / 255f, 0f);
    }


    public static class Night
    {
        public static readonly Color TextColour = new Color(165f / 255f, 165f / 255f, 165f / 255f, 1f);
        public static readonly Color BackgroundColour = new Color(0f, 0f, 0f, 0f);
    }
}
