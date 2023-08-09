using Pieces;

namespace Game {
    public class Board {
        public Dictionary<Coordinates, Piece> pieces;

        public Board() {
            pieces = new Dictionary<Coordinates, Piece>();
        }

        public void SetupDefaultPosition() {
            pieces.Clear();

            // pawns
            foreach (Files file in Enum.GetValues(typeof(Files))) {
                SetPiece(new Coordinates(file, 2), new Pawn(new Coordinates(file, 2), Color.White));
                SetPiece(new Coordinates(file, 7), new Pawn(new Coordinates(file, 7), Color.Black));
            }

            // white rooks
            SetPiece(new Coordinates(Files.A, 1), new Rook(new Coordinates(Files.A, 1), Color.White));
            SetPiece(new Coordinates(Files.H, 1), new Rook(new Coordinates(Files.A, 1), Color.White));

            // black rooks
            SetPiece(new Coordinates(Files.A, 8), new Rook(new Coordinates(Files.A, 8), Color.White));
            SetPiece(new Coordinates(Files.H, 8), new Rook(new Coordinates(Files.A, 8), Color.White));

            // white knights
            SetPiece(new Coordinates(Files.B, 1), new Knight(new Coordinates(Files.B, 1), Color.White));
            SetPiece(new Coordinates(Files.G, 1), new Knight(new Coordinates(Files.G, 1), Color.White));

            // black knights
            SetPiece(new Coordinates(Files.B, 8), new Knight(new Coordinates(Files.B, 8), Color.White));
            SetPiece(new Coordinates(Files.G, 8), new Knight(new Coordinates(Files.G, 8), Color.White));

            // white bishops
            SetPiece(new Coordinates(Files.C, 1), new Bishop(new Coordinates(Files.C, 1), Color.White));
            SetPiece(new Coordinates(Files.F, 1), new Bishop(new Coordinates(Files.F, 1), Color.White));

            // black bishops
            SetPiece(new Coordinates(Files.F, 8), new Bishop(new Coordinates(Files.F, 8), Color.Black));
            SetPiece(new Coordinates(Files.C, 8), new Bishop(new Coordinates(Files.C, 8), Color.Black));

            // queens
            SetPiece(new Coordinates(Files.D, 1), new Queen(new Coordinates(Files.F, 1), Color.White));
            SetPiece(new Coordinates(Files.D, 8), new Queen(new Coordinates(Files.F, 8), Color.Black));

            // kings
            SetPiece(new Coordinates(Files.E, 1), new King(new Coordinates(Files.E, 1), Color.White));
            SetPiece(new Coordinates(Files.E, 8), new King(new Coordinates(Files.E, 8), Color.Black));
        }

        public void SetPiece(Coordinates coordinates, Piece piece) {
            piece.Coordinates = coordinates;
            pieces.Add(coordinates, piece);
        }

        public bool IsSquareFree(Coordinates coordinates) {
            return !pieces.ContainsKey(coordinates);
        }
    }
}