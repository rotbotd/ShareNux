// WinForms enums needed for compilation
namespace System.Windows.Forms
{
    [Flags]
    public enum AnchorStyles
    {
        None = 0,
        Top = 1,
        Bottom = 2,
        Left = 4,
        Right = 8
    }

    public enum ContentAlignment
    {
        TopLeft = 1,
        TopCenter = 2,
        TopRight = 4,
        MiddleLeft = 16,
        MiddleCenter = 32,
        MiddleRight = 64,
        BottomLeft = 256,
        BottomCenter = 512,
        BottomRight = 1024
    }

    public enum Orientation
    {
        Horizontal = 0,
        Vertical = 1
    }

    [Flags]
    public enum BoundsSpecified
    {
        None = 0,
        X = 1,
        Y = 2,
        Location = 3,
        Width = 4,
        Height = 8,
        Size = 12,
        All = 15
    }

    public enum DockStyle
    {
        None = 0,
        Top = 1,
        Bottom = 2,
        Left = 3,
        Right = 4,
        Fill = 5
    }
}

namespace System.Drawing
{
    public enum DashStyle
    {
        Solid = 0,
        Dash = 1,
        Dot = 2,
        DashDot = 3,
        DashDotDot = 4,
        Custom = 5
    }
}

namespace System.Drawing.Imaging
{
    public sealed class BitmapData
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Stride { get; set; }
        public PixelFormat PixelFormat { get; set; }
        public IntPtr Scan0 { get; set; }
        public int Reserved { get; set; }
    }

    public enum ImageLockMode
    {
        ReadOnly = 1,
        WriteOnly = 2,
        ReadWrite = 3,
        UserInputBuffer = 4
    }

    public sealed class ImageFormat
    {
        private readonly Guid guid;
        private ImageFormat(Guid g) { guid = g; }
        
        public Guid Guid => guid;
        
        public static ImageFormat Bmp { get; } = new ImageFormat(new Guid("b96b3cab-0728-11d3-9d7b-0000f81ef32e"));
        public static ImageFormat Gif { get; } = new ImageFormat(new Guid("b96b3cb0-0728-11d3-9d7b-0000f81ef32e"));
        public static ImageFormat Jpeg { get; } = new ImageFormat(new Guid("b96b3cae-0728-11d3-9d7b-0000f81ef32e"));
        public static ImageFormat Png { get; } = new ImageFormat(new Guid("b96b3caf-0728-11d3-9d7b-0000f81ef32e"));
        public static ImageFormat Tiff { get; } = new ImageFormat(new Guid("b96b3cb1-0728-11d3-9d7b-0000f81ef32e"));
        public static ImageFormat Icon { get; } = new ImageFormat(new Guid("b96b3cb5-0728-11d3-9d7b-0000f81ef32e"));
    }
}
