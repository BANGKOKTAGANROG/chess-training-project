namespace Pieces {
    public abstract class Piece {
        private readonly Color color;
        private Coordinates coordinates;
        public Coordinates Coordinates {
            get { 
                return coordinates; 
            }
            set {
                coordinates = value; 
            }
        }
        public Color Color {
            get { 
                return color; 
            }
        }

        protected Piece(Coordinates coordinates, Color color) {
            this.coordinates = coordinates;
            this.color = color;
        }
    }
}