namespace Solid.Examples._3___LSP.Violacao {
    public class Rectangle {

        public virtual double Height { get; set; }
        public virtual double Width { get; set; }
        public double Area { get { return Height * Width; } }
    }
}
