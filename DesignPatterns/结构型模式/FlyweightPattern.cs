using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_FlyweightPattern
{
    class FlyweightPattern
    {
        Dictionary<string, Dictionary<Color, ChessUnit>> unitConfig = new Dictionary<string, Dictionary<Color, ChessUnit>>();

        public void Run()
        {
            ChessUnit[] chessUnits = new ChessUnit[4];

            ChessUnit unit01 = new ChessUnit(Color.Red, "车");
            chessUnits[0] = unit01;
            ChessUnit unit02 = new ChessUnit(Color.Black, "车");
            chessUnits[1] = unit02;
            ChessUnit unit03 = new ChessUnit(Color.Red, "马");
            chessUnits[2] = unit03;
            ChessUnit unit04 = new ChessUnit(Color.Black, "马");
            chessUnits[3] = unit04;

            for (int i = 0; i < chessUnits.Length; i++)
            {
                if (!unitConfig.ContainsKey(chessUnits[i].Content))
                {
                    unitConfig.Add(chessUnits[i].Content, new Dictionary<Color, ChessUnit>());
                }

                if (!unitConfig[chessUnits[i].Content].ContainsKey(chessUnits[i].ChessColor))
                {
                    unitConfig[chessUnits[i].Content].Add(chessUnits[i].ChessColor, chessUnits[i]);
                }
            }

            Chess chess01 = new Chess(1, unitConfig["车"][Color.Red], 0, 0);
            Chess chess02 = new Chess(2, unitConfig["车"][Color.Black], 1, 1);
            Chess chess03 = new Chess(3, unitConfig["马"][Color.Red], 2, 2);
            Chess chess04 = new Chess(4, unitConfig["马"][Color.Black], 3, 3                                                                                                                                                       );
        }
    }

    enum Color
    {
        Black,
        Red
    }

    class ChessUnit
    {
        public Color ChessColor;
        public string Content;

        public ChessUnit(Color chessColor, string content)
        {
            ChessColor = chessColor;
            Content = content;
        }
    }

    class Chess
    {
        public int ID;
        public ChessUnit Unit;
        public int PosX;
        public int PosY;

        public Chess(int iD, ChessUnit unit, int posX, int posY)
        {
            ID = iD;
            Unit = unit;
            PosX = posX;
            PosY = posY;
        }
    }
}
