using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jingulak bazi
            SoundPlayer gameSound = new SoundPlayer();
            gameSound.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "04. 4 Bit 9d Api+E+6.wav";
            gameSound.PlayLooping();
            Console.Title = "<<Tic Tac Toe Game>>";
            Console.CursorVisible = false;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            //Console.SetWindowPosition(-2*Console.WindowLeft, -2*Console.WindowTop);
            Console.SetWindowPosition(0, 0);
            var titleHeight = 10;
            var titleWidth = 140;
            var cursorTop = (Console.WindowHeight - titleHeight - 1) / 3;
            var cursorLeft = (Console.WindowWidth - titleWidth) / 2;
            Console.SetCursorPosition(cursorLeft, cursorTop);
            ConsoleColor colorBG = ConsoleColor.DarkGray;
            Thread.Sleep(700);
            //if (Infection())
            //{
            //
            //}
            Console.BackgroundColor = colorBG;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorVisible = false;
            /*Jingul Song
            Console.Beep(5000, 333);
            Console.Beep(4000, 150);
            Console.Beep(5000, 333);
            Console.Beep(4000, 150);
            Console.Beep(5000, 333);
            Thread.Sleep(150);
            Console.Beep(5000, 150);
            Console.Beep(5000, 150);
            Thread.Sleep(150);
            Console.Beep(5000, 333);
            Console.Beep(4000, 150);
            Console.Beep(5000, 333);
            Console.Beep(4000, 150);
            Console.Beep(5000, 333);
            Thread.Sleep(150);
            Console.Beep(5000, 150);
            Console.Beep(12000, 150);
            Thread.Sleep(150);
            Console.Beep(5000, 333);
            Console.Beep(12000, 150);
            Console.Beep(5000, 333);
            Console.Beep(4000, 150);
            Console.Beep(5000, 333);
            Thread.Sleep(150);
            Console.Beep(5000, 150);
            Console.Beep(5000, 150);
            Thread.Sleep(150);
            Console.Beep(5000, 333);
            Console.Beep(4000, 150);
            Console.Beep(5000, 333);
            Console.Beep(4000, 150);
            Console.Beep(5000, 333);
            Thread.Sleep(150);
            */
            for (int i = 1, cursorRight, titleEnd, titleStart; i < 36; i += 2)
            {
                titleStart = cursorLeft - 1 + 2 * i;
                titleEnd = (titleWidth / 2) + 1 - i;
                cursorRight = cursorLeft - 1 + 2 * titleEnd;
                //Top Horizontal Line
                //  Begin
                if (i == 1 || i == 3 || i == 5 || i == 9 || i == 13 || i == 15 || i == 17 || i == 23 || i == 25 || i == 27 || i == 31 || i == 33 || i == 35)
                {
                    Console.SetCursorPosition(titleStart, cursorTop + 1);
                    Console.Write("    ");
                    Console.SetCursorPosition(titleStart, cursorTop + 2);
                    Console.Write("    ");
                }
                if (titleEnd == 70 || titleEnd == 68 || titleEnd == 66 || titleEnd == 62 || titleEnd == 60 || titleEnd == 58 || titleEnd == 54 || titleEnd == 52 || titleEnd == 50 || titleEnd == 44 || titleEnd == 42 || titleEnd == 40)
                {
                    Console.SetCursorPosition(cursorRight, cursorTop + 1);
                    Console.Write("    ");
                    Console.SetCursorPosition(cursorRight, cursorTop + 2);
                    Console.Write("    ");
                }
                //  End
                //Top Horizontal Line

                //Mid Horizontal Line
                //  Begin
                if (i == 3 || i == 9 || i == 13 || i == 25 || i == 31 || i == 33 || i == 35)
                {
                    Console.SetCursorPosition(titleStart, cursorTop + 5);
                    Console.Write("    ");
                    Console.SetCursorPosition(titleStart, cursorTop + 6);
                    Console.Write("    ");
                }
                if (titleEnd == 68 || titleEnd == 66 || titleEnd == 62 || titleEnd == 58 || titleEnd == 52 || titleEnd == 40)
                {
                    Console.SetCursorPosition(cursorRight, cursorTop + 5);
                    Console.Write("    ");
                    Console.SetCursorPosition(cursorRight, cursorTop + 6);
                    Console.Write("    ");
                }
                //  End
                //Mid Horizontal Line

                //Mid Vertical Line
                //  Begin
                if (i == 3 || i == 9 || i == 13 || i == 25 || i == 31 || i == 35)
                {
                    Console.SetCursorPosition(titleStart, cursorTop + 3);
                    Console.Write("    ");
                    Console.SetCursorPosition(titleStart, cursorTop + 4);
                    Console.Write("    ");
                    Console.SetCursorPosition(titleStart, cursorTop + 7);
                    Console.Write("    ");
                    Console.SetCursorPosition(titleStart, cursorTop + 8);
                    Console.Write("    ");
                }
                if (titleEnd == 66 || titleEnd == 62 || titleEnd == 58 || titleEnd == 52 || titleEnd == 40)
                {
                    Console.SetCursorPosition(cursorRight, cursorTop + 3);
                    Console.Write("    ");
                    Console.SetCursorPosition(cursorRight, cursorTop + 4);
                    Console.Write("    ");
                    Console.SetCursorPosition(cursorRight, cursorTop + 7);
                    Console.Write("    ");
                    Console.SetCursorPosition(cursorRight, cursorTop + 8);
                    Console.Write("    ");
                }
                //  End
                //Mid Vertical Line

                //Bottom Horizontal Line
                //  Begin
                if (i == 3 || i == 9 || i == 13 || i == 15 || i == 17 || i == 25 || i == 31 || i == 35)
                {
                    Console.SetCursorPosition(titleStart, cursorTop + 9);
                    Console.Write("    ");
                    Console.SetCursorPosition(titleStart, cursorTop + 10);
                    Console.Write("    ");
                }
                if (titleEnd == 70 || titleEnd == 68 || titleEnd == 66 || titleEnd == 62 || titleEnd == 60 || titleEnd == 58 || titleEnd == 52 || titleEnd == 44 || titleEnd == 42 || titleEnd == 40)
                {
                    Console.SetCursorPosition(cursorRight, cursorTop + 9);
                    Console.Write("    ");
                    Console.SetCursorPosition(cursorRight, cursorTop + 10);
                    Console.Write("    ");
                }
                //  End
                //Bottom Horizontal Line

                Thread.Sleep(103);
            }

            var cursorTop_IntroTxt = 2 * cursorTop + 11;//11 = 10 (Previous Title) + 1 (Current Title line)
            string introTxt = "Press any key to continue...";
            var introTxtWidth = introTxt.Length;
            var cursorLeft_IntroTxt = (Console.WindowWidth - introTxtWidth) / 2;
            Console.SetCursorPosition(cursorLeft_IntroTxt, cursorTop_IntroTxt);
            Console.CursorSize = 50;
            Console.BackgroundColor = colorBG;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(introTxt);
            Console.ReadKey();
            while (true)
            {
                Console.BackgroundColor = colorBG;
                if (Infection(ConsoleColor.DarkGray,ConsoleColor.Black))
                {

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.SetCursorPosition(cursorLeft, cursorTop + 1);
                Console.WriteLine("Enter player name for \"O\" sign:");
                Console.SetCursorPosition(cursorLeft, cursorTop + 3);
                Console.CursorVisible = true;
                var oPlayer_Name = Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(cursorLeft, cursorTop + 1);
                Console.WriteLine("Enter player name for \"X\" sign:");
                Console.SetCursorPosition(cursorLeft, cursorTop + 3);
                var xPlayer_Name = Console.ReadLine();
                if (Infection())
                {

                }
                Console.CursorVisible = false;
                var cursorTop_Table = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(Console.WindowHeight / 7)));
                var tableHeight = Console.WindowHeight - cursorTop_Table * 2;
                var tableWidth = tableHeight * 2;
                //cursorLeft_Table
                cursorLeft = (Console.WindowWidth - tableWidth) / 2;
                var cellWidth = (tableWidth - 8) / 3;// 8 = 4 * 2 & 4 = Width Of Column Vertical Seperation Lines.
                var cellHeight = (tableHeight - 4) / 3;
                int cursorLeft_VerticalLine_0 = cursorLeft + cellWidth + 1, cursorLeft_VerticalLine_1 = cursorLeft + 2 * cellWidth + 5;//5 = 4(Vertical Line Width) + 1
                Console.BackgroundColor = ConsoleColor.White;
                for (int i = 0; i < tableHeight; i++)
                {
                    Console.SetCursorPosition(cursorLeft_VerticalLine_0, cursorTop_Table + i);
                    Console.Write("    ");
                    Console.SetCursorPosition(cursorLeft_VerticalLine_1, cursorTop_Table + i);
                    Console.Write("    ");
                }
                string horizontalLine = new String(' ', tableWidth);
                Console.SetCursorPosition(cursorLeft, cursorTop_Table + cellHeight);
                Console.Write(horizontalLine);
                Console.SetCursorPosition(cursorLeft, cursorTop_Table + cellHeight + 1);
                Console.Write(horizontalLine);
                Console.SetCursorPosition(cursorLeft, cursorTop_Table + cellHeight * 2 + 2);
                Console.Write(horizontalLine);
                Console.SetCursorPosition(cursorLeft, cursorTop_Table + cellHeight * 2 + 3);
                Console.Write(horizontalLine);
                var playerTurn = 'O';
                int tableX = 1, tableY = 1;
                var tableFill = new String(' ', cellWidth);
                char[,] tableCells = new char[3, 3];
                while (true)
                {
                    ChangePlayerTurn(oPlayer_Name, xPlayer_Name, cursorLeft, tableWidth, playerTurn);
                    Console.BackgroundColor = ConsoleFill(
                        cursorLeft + 1 + tableX * (cellWidth + 4),
                        cursorTop_Table + tableY * (2 + cellHeight),
                        cellWidth, cellHeight, ConsoleColor.Gray
                        );
                    if (tableCells[tableX, tableY] != '\0')
                    {
                        WriteSign(
                            cursorLeft + tableX * (cellWidth + 4) + 1,//tableX*(cellWidth+4) :: each column is seperated by a vertical line with a width of 4 buffers;
                            cursorTop_Table + tableY * (cellHeight + 2),//tableY*(cellHeight+2) :: each row is seperated by a horizontal line with a height of 2 buffers;
                            tableCells[tableX, tableY], cellWidth, cellHeight, tableCells[tableX, tableY] == 'O' ? ConsoleColor.Blue : ConsoleColor.Red
                            );
                    }
                    //Get User Input For Transition Between Cells
                    ConsoleKey Key = Console.ReadKey().Key;
                    if (Key == ConsoleKey.Enter || Key == ConsoleKey.Spacebar)
                    {
                        if (tableCells[tableX, tableY] != '\0')
                        {
                            ShowAlarm(cursorTop_Table + tableHeight, "Please choose an empty cell.");
                            continue;
                        }
                        tableCells[tableX, tableY] = playerTurn;
                        Console.BackgroundColor = ConsoleFill(
                            cursorLeft + 1 + tableX * (cellWidth + 4),
                            cursorTop_Table + tableY * (2 + cellHeight),
                            cellWidth, cellHeight
                            );
                        Console.BackgroundColor = WriteSign(
                            cursorLeft + tableX * (cellWidth + 4) + 1,//tableX*(cellWidth+4) :: each column is seperated by a vertical line with a width of 4 buffers;
                            cursorTop_Table + tableY * (cellHeight + 2),//tableY*(cellHeight+2) :: each row is seperated by a horizontal line with a height of 2 buffers;
                            playerTurn, cellWidth, cellHeight, playerTurn == 'O' ? ConsoleColor.Blue : ConsoleColor.Red
                            );

                        char winner = HasWin(tableCells);
                        if (winner != '\0')
                        {
                            Console.BackgroundColor = colorBG;
                            switch (winner)
                            {
                                case 'O':
                                    ShowAlarm(3 * cursorTop_Table / 2 + tableHeight, $"Player {oPlayer_Name} has won.", ConsoleColor.Green);
                                    break;
                                case 'X':
                                    ShowAlarm(3 * cursorTop_Table / 2 + tableHeight, $"Player {xPlayer_Name} has won.", ConsoleColor.Green);
                                    break;
                                default:
                                    ShowAlarm(3 * cursorTop_Table / 2 + tableHeight, "It's a tie!!", ConsoleColor.Yellow);
                                    break;
                            }
                            Console.BackgroundColor = WriteSign(
                                cursorLeft + tableX * (cellWidth + 4) + 1,//tableX*(cellWidth+4) :: each column is seperated by a vertical line with a width of 4 buffers;
                                cursorTop_Table + tableY * (cellHeight + 2),//tableY*(cellHeight+2) :: each row is seperated by a horizontal line with a height of 2 buffers;
                                playerTurn, cellWidth, cellHeight, playerTurn == 'O' ? ConsoleColor.Blue : ConsoleColor.Red, ConsoleColor.DarkGray
                                );
                            break;
                        }
                        FindEmptyCell(ref tableX, ref tableY, ref tableCells,
                            cursorLeft + tableX * (cellWidth + 4) + 1,//tableX*(cellWidth+4) :: each column is seperated by a vertical line with a width of 4 buffers;
                            cursorTop_Table + tableY * (cellHeight + 2),//tableY*(cellHeight+2) :: each row is seperated by a horizontal line with a height of 2 buffers;);
                            cellWidth, cellHeight);
                        playerTurn = playerTurn == 'O' ? 'X' : 'O';
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleFill(
                            cursorLeft + 1 + tableX * (cellWidth + 4),
                            cursorTop_Table + tableY * (2 + cellHeight),
                            cellWidth, cellHeight
                            );
                        if (tableCells[tableX, tableY] != '\0')
                        {
                            Console.BackgroundColor = WriteSign(
                                cursorLeft + tableX * (cellWidth + 4) + 1,//tableX*(cellWidth+4) :: each column is seperated by a vertical line with a width of 4 buffers;
                                cursorTop_Table + tableY * (cellHeight + 2),//tableY*(cellHeight+2) :: each row is seperated by a horizontal line with a height of 2 buffers;
                                tableCells[tableX, tableY], cellWidth, cellHeight, tableCells[tableX, tableY] == 'O' ? ConsoleColor.Blue : ConsoleColor.Red, colorBG
                                );
                        }
                        PlayerAction(tableCells, ref tableX, ref tableY, Key);

                    }
                }
                var newGameTxt = "Play again? (Y/N)";
                var cursorLeft_FinalMsg = ((Console.WindowWidth - newGameTxt.Length) / 2) + 1;
                Console.SetCursorPosition(cursorLeft_FinalMsg, 3 * cursorTop_Table / 2 + tableHeight);
                Console.BackgroundColor = colorBG;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(newGameTxt);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop + 2);
                var newGame = Console.ReadLine().ToLower();
                Console.CursorVisible = true;
                if (newGame == "n")
                {
                    break;
                }
            }
        }
        static void PlayerAction(char[,] Table, ref int X, ref int Y, ConsoleKey Key)
        {
            switch (Key)
            {
                case ConsoleKey.LeftArrow:
                    if (X - 1 < 0)
                        X = 2;
                    else
                        X--;
                    //PlayerMove(Table, ref X, ref Y, Key);
                    break;
                case ConsoleKey.UpArrow:
                    if (Y - 1 < 0)
                        Y = 2;
                    else
                        Y--;
                    //PlayerMove(Table, ref X, ref Y, Key);
                    break;
                case ConsoleKey.RightArrow:
                    if (X + 1 > 2)
                        X = 0;
                    else
                        X++;
                    //PlayerMove(Table, ref X, ref Y, Key);
                    break;
                case ConsoleKey.DownArrow:
                    if (Y + 1 > 2)
                        Y = 0;
                    else
                        Y++;
                    //PlayerMove(Table, ref X, ref Y, Key);
                    break;
            }
        }
        static void PlayerMove(char[,] Table, ref int X, ref int Y, ConsoleKey Key)
        {
            if (Table[X, Y] != '\0')
            {
                switch (Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (X - 1 < 0)
                            X = 2;
                        else
                            X--;
                        PlayerMove(Table, ref X, ref Y, Key);
                        break;
                    case ConsoleKey.UpArrow:
                        if (Y - 1 < 0)
                            Y = 2;
                        else
                            Y--;
                        PlayerMove(Table, ref X, ref Y, Key);
                        break;
                    case ConsoleKey.RightArrow:
                        if (X + 1 > 2)
                            X = 0;
                        else
                            X++;
                        PlayerMove(Table, ref X, ref Y, Key);
                        break;
                    case ConsoleKey.DownArrow:
                        if (Y + 1 > 2)
                            Y = 0;
                        else
                            Y++;
                        PlayerMove(Table, ref X, ref Y, Key);
                        break;
                }
            }

        }
        static ConsoleColor ConsoleFill(int cursorLeft, int cursorTop, int cellWidth, int cellHeight, ConsoleColor colorBG = ConsoleColor.DarkGray)
        {
            var tempConsoleColor = Console.BackgroundColor;
            Console.BackgroundColor = colorBG;
            string line = new String(' ', cellWidth);
            for (int i = 0; i < cellHeight; i++)
            {
                Console.SetCursorPosition(cursorLeft, cursorTop + i);
                Console.Write(line);
            }
            Console.SetCursorPosition(cursorLeft, cursorTop);
            return tempConsoleColor;
        }
        static ConsoleColor WriteSign(int cursorLeft, int cursorTop, char sign, int cellWidth, int cellHeight, ConsoleColor colorFG, ConsoleColor colorBG = ConsoleColor.Gray)
        {
            var tempForeGroundColor = Console.ForegroundColor;
            Console.ForegroundColor = colorFG;
            Console.BackgroundColor = colorBG;
            var cellMarginLeft = (cellWidth - " .----------------. ".Length) / 2;
            var cellMargintop = (cellHeight - 11) / 2;//11 = number of lines each sign has;
            cursorLeft += cellMarginLeft;
            cursorTop += cellMargintop;
            switch (sign)
            {
                case 'O':
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.Write(" .----------------. ");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 1);
                    Console.Write("| .--------------. |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 2);
                    Console.Write("| |     ____     | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 3);
                    Console.Write("| |   .'    `.   | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 4);
                    Console.Write(@"| |  /  .--.  \  | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 5);
                    Console.Write("| |  | |    | |  | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 6);
                    Console.Write(@"| |  \  `--'  /  | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 7);
                    Console.Write("| |   `.____.'   | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 8);
                    Console.Write("| |              | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 9);
                    Console.Write("| '--------------' |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 10);
                    Console.Write(" '----------------' ");
                    break;
                case 'X':
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.Write(" .----------------. ");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 1);
                    Console.Write("| .--------------. |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 2);
                    Console.Write("| |  ____  ____  | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 3);
                    Console.Write("| | |_  _||_  _| | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 4);
                    Console.Write(@"| |   \ \  / /   | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 5);
                    Console.Write(@"| |    > `' <    | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 6);
                    Console.Write(@"| |  _/ /'`\ \_  | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 7);
                    Console.Write(@"| | |____||____| | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 8);
                    Console.Write("| |              | |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 9);
                    Console.Write("| '--------------' |");
                    Console.SetCursorPosition(cursorLeft, cursorTop + 10);
                    Console.Write(" '----------------' ");
                    break;
                default:
                    break;
            }
            Console.SetCursorPosition(cursorLeft, cursorTop);
            return colorFG;
        }
        static void FindEmptyCell(ref int X, ref int Y, ref char[,] Cells, int cursorLeft, int cursorTop, int cellWidth, int cellHeight)
        {
            WriteSign(cursorLeft, cursorTop, Cells[X, Y], cellWidth, cellHeight, Cells[X, Y] == 'O' ? ConsoleColor.Blue : ConsoleColor.Red, ConsoleColor.DarkGray);
            for (int i = 0; i < Cells.GetUpperBound(0); i++)
            {
                for (int j = 0; j < Cells.GetUpperBound(1); j++)
                {
                    if (Cells[i, j] == '\0')
                    {
                        X = i;
                        Y = j;
                    }
                }
            }
        }

        static void ShowAlarm(int cursorTop, string alarmTxt, ConsoleColor fontColor = ConsoleColor.Red, ConsoleColor backColor = ConsoleColor.DarkGray)
        {
            var currentFontColor = Console.ForegroundColor;
            Console.ForegroundColor = fontColor;
            var cursorLeft = ((Console.WindowWidth - alarmTxt.Length) / 2) + 1;
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.Write(alarmTxt);
            Console.ForegroundColor = currentFontColor;
            Console.BackgroundColor = backColor;
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Thread.Sleep(1500);
            var Line = new String(' ', alarmTxt.Length);
            Console.Write(Line);
        }
        static char HasWin(char[,] TableCells)
        {
            if (
                    TableCells[0, 0] == TableCells[1, 1] && TableCells[2, 2] == TableCells[1, 1] ||
                    TableCells[0, 1] == TableCells[1, 1] && TableCells[2, 1] == TableCells[1, 1] ||
                    TableCells[1, 0] == TableCells[1, 1] && TableCells[1, 2] == TableCells[1, 1] ||
                    TableCells[0, 2] == TableCells[1, 1] && TableCells[2, 0] == TableCells[1, 1]
                )
            {
                if (TableCells[1, 1] != '\0')
                {
                    return TableCells[1, 1];
                }
            }

            if (
                TableCells[0, 0] == TableCells[1, 0] && TableCells[2, 0] == TableCells[1, 0] ||
                TableCells[2, 0] == TableCells[2, 1] && TableCells[2, 1] == TableCells[2, 2])
            {
                if (TableCells[2, 0] != '\0')
                {
                    return TableCells[2, 0];
                }
            }
            if (TableCells[0, 0] == TableCells[0, 1] && TableCells[0, 1] == TableCells[0, 2] ||
                    TableCells[0, 2] == TableCells[1, 2] && TableCells[1, 2] == TableCells[2, 2])
            {
                if (TableCells[0, 2] != '\0')
                {
                    return TableCells[0, 2];
                }
            }
            return HasEmptyCell(TableCells);
        }
        static char HasEmptyCell(char[,] TableCells)
        {
            for (int i = 0; i <= TableCells.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= TableCells.GetUpperBound(1); j++)
                {
                    if (TableCells[i, j] == '\0')
                    {
                        return '\0';
                    }
                }
            }
            return 'T';
        }
        static bool HasNoColorCell(ConsoleColor[,] TableCells, ConsoleColor colorBG)
        {
            for (int i = 0; i < TableCells.GetUpperBound(0); i++)
            {
                for (int j = 0; j < TableCells.GetUpperBound(1); j++)
                {
                    if (TableCells[i, j] == colorBG)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool HasNoColorCell(ConsoleColor[,] TableCells, ConsoleColor colorBG, int X)
        {
            for (int j = 0; j < TableCells.GetUpperBound(1); j++)
            {
                if (TableCells[X, j] == colorBG)
                {
                    return true;
                }
            }
            return false;
        }
        static bool HasNoColorCell(ConsoleColor[,] TableCells, ConsoleColor colorBG, int X, int Y)
        {
            if (TableCells[X, Y] == colorBG)
            {
                return true;
            }
            return false;
        }
        static bool Infection(ConsoleColor colorBG = ConsoleColor.Black, ConsoleColor colorPaint = ConsoleColor.DarkGray)
        {
            var widthLength = Console.WindowWidth;
            var heightLength = Console.WindowHeight;
            ConsoleColor[,] screenRes = new ConsoleColor[widthLength, heightLength];
            var tempcolorCurrentBG = Console.BackgroundColor;
            for (int i = 0; i < widthLength; i++)
            {
                for (int j = 0; j < heightLength; j++)
                {
                    screenRes[i, j] = colorBG;
                }
            }
            Console.BackgroundColor = colorBG;
            Console.Clear();
            Console.BackgroundColor = colorPaint;
            var rand = new Random();
            var whileLength = (16*widthLength * heightLength)/5;
            var whileIndex = 0;
            while (whileIndex<= whileLength)
            {
                whileIndex++;
                var X = rand.Next(0, widthLength - 1);
                var Y = rand.Next(0, heightLength - 1);
                if (HasNoColorCell(screenRes, colorBG))
                {
                    if (!HasNoColorCell(screenRes, colorBG, X, Y))
                    {
                        continue;
                    }
                    screenRes[X, Y] = colorPaint;
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            Thread.Sleep(150);
            return true;
        }
        static void ChangePlayerTurn(string oPlayer_Name, string xPlayer_Name, int cursorLeft, int tablewidth,char playerTurn, ConsoleColor colorBG = ConsoleColor.DarkGray)
        {
            //TODO: Write ChangePlayerTurn Function
            oPlayer_Name = "  " + oPlayer_Name + "  ";
            xPlayer_Name = "  " + xPlayer_Name + "  ";
            switch (playerTurn)
            {
                case 'O':
                    WritePlayerName(oPlayer_Name, ((cursorLeft - oPlayer_Name.Length) / 2)+1);
                    WritePlayerName(xPlayer_Name, cursorLeft + tablewidth + ((cursorLeft - xPlayer_Name.Length) / 2)+1,ConsoleColor.DarkGray,ConsoleColor.Red);
                    break;
                case 'X':
                    WritePlayerName(xPlayer_Name,cursorLeft + tablewidth + ((cursorLeft - xPlayer_Name.Length) / 2) + 1 );
                    WritePlayerName(oPlayer_Name, ((cursorLeft - oPlayer_Name.Length) / 2) + 1, ConsoleColor.DarkGray, ConsoleColor.Blue);
                    break;
            }
        }
        static void WritePlayerName(string oPlayer_Name, string xPlayer_Name, int cursorLeft, int tablewidth,ConsoleColor colorBG = ConsoleColor.DarkGray)
        {
            Console.BackgroundColor = colorBG;
            Console.ForegroundColor = ConsoleColor.Blue;
            var windowHeight = Console.WindowHeight;
            var cursorTop = windowHeight / 2;
            Console.SetCursorPosition(((cursorLeft - oPlayer_Name.Length) / 2) + 1, cursorTop);
            Console.Write(oPlayer_Name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(((cursorLeft - xPlayer_Name.Length) / 2)+ tablewidth + cursorLeft+ 1, cursorTop);
            Console.Write(oPlayer_Name);
        }
        static void WritePlayerName(string Player_Name, int cursorLeft, ConsoleColor colorBG = ConsoleColor.White, ConsoleColor colorFG = ConsoleColor.Black)
        {
            Console.BackgroundColor = colorBG;
            Console.ForegroundColor = colorFG;
            var cursorTop = Console.WindowHeight / 2;
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.Write(Player_Name);
        }
        static void StartSong(SoundPlayer sp)
        {
            System.Threading.Thread t1 = new System.Threading.Thread
              (delegate ()
              {
                  sp.PlaySync();
              });
            t1.Start();
        }
    }
}
