using UnityEngine;

public class PieceGenerator : MonoBehaviour
{
    [SerializeField] private Piece _BlackPiece;
    [SerializeField] private Piece _WhitePiece;
    [SerializeField] private MeshRenderer _Board;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlaceBlackPieces();
        PlaceWhitePieces();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceWhitePieces()
    {
        Piece whitePiece = Instantiate(_WhitePiece);
        Bounds bound = _Board.bounds;

        float whitePieceX = _Board.transform.position.x - bound.size.x / 2 + bound.size.x / 8 / 2;
        float whitePieceY = _Board.transform.position.y + whitePiece.MeshRenderer.bounds.size.y / 2;
        float whitePieceZ = _Board.transform.position.z + bound.size.z / 2 - bound.size.z / 8 / 2;

        whitePiece.transform.position = new Vector3(whitePieceX, whitePieceY, whitePieceZ);

        Vector3 basePosition = whitePiece.transform.position;
        Destroy(whitePiece.gameObject);

        int verticalPiecesCount = 3;
        int horizontalPiecesCount = 4;
        Vector3 horizontalDistance = new Vector3(bound.size.x / 8 * 2, 0, 0);
        Vector3 verticalDistance = new Vector3(0, 0, bound.size.z / 8);
        Vector3 currentPosition = basePosition;

        for (int i = 0; i < verticalPiecesCount; i++)
        {
            currentPosition = basePosition - i * verticalDistance;

            if (i % 2 != 0)
            {
                currentPosition += new Vector3(bound.size.x / 8, 0, 0); // Offset every other row
            }

            for (int j = 0; j < horizontalPiecesCount; j++)
            {
                Piece piece = Instantiate(_WhitePiece);
                piece.transform.position = currentPosition;
                currentPosition += horizontalDistance;
            }
        }


    }

    public void PlaceBlackPieces()
    {
        Piece blackPiece = Instantiate(_BlackPiece);
        Bounds bound = _Board.bounds;

        float blackPieceX = _Board.transform.position.x - bound.size.x / 2 + bound.size.x / 8 / 2;
        float blackPieceY = _Board.transform.position.y + blackPiece.MeshRenderer.bounds.size.y / 2;
        float blackPieceZ = _Board.transform.position.z - bound.size.z / 2 + bound.size.z / 8 / 2 + 2 * (bound.size.z / 8);

        blackPiece.transform.position = new Vector3(blackPieceX, blackPieceY, blackPieceZ);

        Vector3 basePosition = blackPiece.transform.position;
        Destroy(blackPiece.gameObject);

        int verticalPiecesCount = 3;
        int horizontalPiecesCount = 4;
        Vector3 horizontalDistance = new Vector3(bound.size.x / 8 * 2, 0, 0);
        Vector3 verticalDistance = new Vector3(0, 0, -bound.size.z / 8);
        Vector3 currentPosition = basePosition;

        for (int i = 0; i < verticalPiecesCount; i++)
        {
            currentPosition = basePosition + i * verticalDistance;

            if (i % 2 == 0)
            {
                currentPosition += new Vector3(bound.size.x / 8, 0, 0); // Offset every other row
            }

            for (int j = 0; j < horizontalPiecesCount; j++)
            {
                Piece piece = Instantiate(_BlackPiece);
                piece.transform.position = currentPosition;
                currentPosition += horizontalDistance;
            }
        }


    }
}
