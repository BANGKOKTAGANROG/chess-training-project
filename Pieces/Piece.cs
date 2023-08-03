namespace Pieces {
    public abstract class Piece {
        public readonly Color color;
        public Coordinates coordinates;

        public Piece(Coordinates coordinates, Color color) {
            this.coordinates = coordinates;
            this.color = color;
        }

        public void Move() {
            Console.WriteLine("move mf move");
        }
    }
}