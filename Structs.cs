namespace Structs{
    internal readonly record struct MainTableMove(
        string PFen,
        string AlgMove,
        bool HasEval,
        string FenAfterMove,
        int MoveScore,
        double WhiteWP,
        double BlackWP,
        double DrawP,
        int GamesPlayedWithThisOpening);
}