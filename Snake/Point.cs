﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char symbol;

        public Point(int x = 0, int y = 0, char symbol = '\0')
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }
        public virtual void Draw(ConsoleColor color = Config.COLOR_DEFAULT)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(2 * x, y);
            Console.Write(symbol);
            Console.ForegroundColor = Config.COLOR_DEFAULT;
        }

        public void Move(int offset, Direction direction)
        {
            switch(direction)
            {
                case Direction.LEFT:
                    x -= offset;
                    break;
                case Direction.RIGHT:
                    x += offset;
                    break;
                case Direction.UP:
                    y -= offset;
                    break;
                case Direction.DOWN:
                    y += offset;
                    break;
                default:
                    break;
            }
        }

        public void Clear()
        {
            symbol = Config.SYMBOL_EMPTY;
            Draw(Config.COLOR_DEFAULT);
        }
    }
}
