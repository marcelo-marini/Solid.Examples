﻿namespace Solid.Examples._3___LSP.Violacao {

    public class Square: Rectangle {

        public override double Height {  set => base.Height = base.Width = value; }
        public override double Width {  set => base.Height = base.Width = value; }
    }
}
