using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngine
{
    interface Constants
    {
        short WHITE
        {
            get
            {
                return 1;
            }
        }
        short BLACK
        {
            get
            {
                return -1;
            }
        }
short PAWN
        {
            get
            {
                return 1;
            }
        }
        short BISHOP
        {
            get
            {
                return 2;
            }
        }
        short KNIGHT
        {
            get
            {
                return 3;
            }
        }
        short ROOK
        {
            get
            {
                return 4;
            }
        }
        short QUEEN
        {
            get
            {
                return 5;
            }
        }
        short KING
        {
            get
            {
                return 6;
            }
        }
    }
}
