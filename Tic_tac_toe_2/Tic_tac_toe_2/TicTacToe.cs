using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
		//Khoi tao
        public TicTacToe(){
            play();
        }
        
        //Luot choi
        public void play() {
            int moveCounter = 0;
            Board gameBoard = new Board();
            
            Player playerX = new Player('X');
            Player playerO = new Player('O');
            Player currentPlayer = playerX;
            
            bool play = true;
            while (play)
            {
                
                gameBoard.printBoard();
                if(currentPlayer.getSign() == 'O')
                {
                    Console.WriteLine("Robot chuan bi danh: {0} . . . ", currentPlayer.getSign());
                } else
                Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                try
                {
                    //Kiểm tra Robot đánh
                    if (currentPlayer.getSign() == 'O')
                    {
                        gameBoard.putMark(currentPlayer, Robot_O());
                    }
                    else
                        gameBoard.putMark(currentPlayer, playerX.takeTurn());
                    gameBoard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameBoard))
                    {
                        if(currentPlayer.getSign() != 'O')
                        Console.WriteLine("Player: {0} win!", currentPlayer.getSign());
                        else
                        {
                            Console.WriteLine("ROBOT win!");
                        }
                        gameBoard.printBoard();
                        play = false;
                    }
                    else if (checkDraw(moveCounter))
                    {
                        Console.WriteLine("DRAW");
                        gameBoard.printBoard();
                        play = false;
                    }
                    currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
      
        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }

        // Robot chơi
        public static int Robot_O()
        {
            Thread.Sleep(500);
            Random rd = new Random();
            return rd.Next(1, 9);

        }



    }

}

