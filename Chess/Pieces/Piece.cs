﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Piece
    {

        #region Constructors
        public Piece()
        {
            IsOnBoard = true;
            Square Coordinates = new Square();
            PieceColor PieceColor = PieceColor.White;
        }
        #endregion

        #region Fields

        bool IsPinned { get; set; }
        

        #endregion


        #region public methods

        public bool IsOnBoard
        {
            get;
            set;
        }


        public Square Coordinates
        {
            get;
            set;
        }

        public PieceColor PieceColor
        {
            get;
            set;
        }

		public bool MoveTo(Square coordinates, Board board)
		{
			bool hasMoved = false;
			
			if(IsPinned = false && IsOnBoard == true)
			{
				
			}
			
			return (hasMoved);
		}

        public void Die()
        {
            IsOnBoard = false;
        }

		#endregion

    }
}
