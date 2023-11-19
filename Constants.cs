namespace Constants{
    internal static class DBConstants{
        public static class Commands{
            public static readonly string[] MAKE_TABLES_COMMANDS = Array.Empty<string>();
        }
        public static class AccessConstants{
            public static class ColumnNames{
                public static class MainTable{
                    public const string P_FEN = "PFen";
                    public const string ALG_MOVE = "AlgebraicMove";
                    public const string HAS_EVAL = "HasEval";
                    public const string EVAL = "eval";
                    public const string FEN_AFTER_MOVE = "FenAfterMove";
                    public const string MOVE_SCORE = "MoveScore";
                    public const string WHITEWP = "WhiteWinPercentage";
                    public const string BLACKWP = "BlackWinPercentage";
                    public const string DRAWP = "DrawPercentage";
                    public const string GAMES_PLAYED_WTO = "GamesPlayedWithThisOpening";
                }
                public static class ColorTable{
                    public const string P_FEN = MainTable.P_FEN;
                    public const string ALG_MOVE = MainTable.ALG_MOVE;
                    public const string MOVE_TIMES = "MoveTimes";
                    public const string FEN_AFTER_MOVE = MainTable.FEN_AFTER_MOVE;
                }
                public static class ColorTimesTable{
                    public const string P_FEN = MainTable.P_FEN;
                    public const string NUM_OF_RESPONSES = "NumberOfResponses";
                    public const string TOTAL_TIMES_PLAYED_BY_COMPUTER = "TotalTimesPlayedByComputer";
                    public const string MEAN_TIMES_PLAYED_BY_COMPUTER = "MeanTimesPlayedByComputer";
                }
            }
            public static class TableNames{
                public const string MAIN_TABLE = "MainTable";
                public const string WHITE_TABLE = "WhiteTable";
                public const string WHITE_TIMES_TABLE = "WhiteTimesTable";
                public const string BLACK_TABLE = "BlackTable";
                public const string BLACK_TIMES_TABLE = "BlackTimesTable";

            }
        }
    }
}