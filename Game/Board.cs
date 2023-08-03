using Pieces;

namespace Game
{
    public class Board {
        public Dictionary<Coordinates, Piece> pieces;

        public Board() {
            pieces = new Dictionary<Coordinates, Piece>();
            SetupDefaultPosition();
        }

        public void SetupDefaultPosition() {
            // white rooks
            SetPiece(new Coordinates(Files.A, 1), new Rook(new Coordinates(Files.A, 1), Color.White));
            SetPiece(new Coordinates(Files.H, 1), new Rook(new Coordinates(Files.A, 1), Color.White));

            // black rooks
            SetPiece(new Coordinates(Files.A, 8), new Rook(new Coordinates(Files.A, 8), Color.White));
            SetPiece(new Coordinates(Files.H, 8), new Rook(new Coordinates(Files.A, 8), Color.White));
        }

        public void SetPiece(Coordinates coordinates, Piece piece) {
            piece.coordinates = coordinates;
            pieces.Add(coordinates, piece);
        }

        public bool IsSquareFree(Coordinates coordinates) {
            return !pieces.ContainsKey(coordinates);
        }
    }
}