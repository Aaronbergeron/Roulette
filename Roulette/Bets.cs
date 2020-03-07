using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Functions
    {
        string answer = "";
        public string Colors(string[] rouletteColors, int numb)
        {           
            if (numb == 1)                                                  //Returning a string 'answer' to tell the user what they would have had to bet to 
            {                                                               //Win with their number
                answer = "A bet on red would be a win.";
            }
            else if (numb == 2)
            {
                answer = "A bet on black would be a win.";  
            }
            else if (numb == 3)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 4)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 5)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 6)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 7)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 8)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 9)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 10)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 11)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 12)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 13)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 14)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 15)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 16)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 17)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 18)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 19)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 20)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 21)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 22)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 23)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 24)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 25)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 26)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 26)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 27)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 28)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 29)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 30)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 31)
            {
                answer = "A bet on black would be a win.";
            }
            else if (numb == 32)
            {
                answer = "A bet on red would be a win.";
            }
            else if (numb == 33)
            {
                answer = "A bet on black would be a win.";
            }
            else if(numb == 34)
            {
                answer = "A bet on red would be a win.";
            }
            else if(numb == 35)
            {
                answer = "A bet on black would be a win.";
            }
            else if(numb == 36)
            {
                answer = "A bet on red would be a win.";
            }
            else if(numb == 0)
            {
                answer = "A bet on green would be a win.";
            }
            else if(numb == 00)
            {
                answer = "A bet on green would be a win.";
            }
            return answer;           
        }
        string save = "";
        public string EvenOdd(string[] rouletteNumbers, int input)          
        {
            if (input == 0)
            {
                save = "0 is not an even or odd number.";
            }
            else if(input == 37)
            {
                save = "00 is not an even or odd number.";                  
            }
            else if(input % 2 == 0)                                                 //If the int % 2 == 0, we know this is an even number.
            {
                save = ("A bet on an even number would be a win.");
            }
            else 
            {
                save = ("A bet on an odd number would be a win.");
            }
            return save;
        }
        string pos;
        public string LowtToHigh(string[] rouletteNumbers, int position)                    
        {
            if(position >= 1 && position <= 18)
            {
                pos = "A 'low' bet would win for your number.";
            }
            else if(position >= 19 && position <= 36)
            {
                pos = "A 'high' bet would win for your number.";
            }
            else if(position == 0 || position == 00)
            {
                pos = "There is no winning high or low bet for this number.";
            }
            return pos;
        }
        string thirds = "";
        public string Dozens(string[] rouletteNumbers, int thirdz)
        {
            if(thirdz >= 1 && thirdz <= 12)                                     //If the random number is 1-12 a bet on the first dozen would be a win, etc
            {
                thirds = "A first dozen bet would be a win.";
            }
            else if(thirdz >= 13 && thirdz <= 24)
            {
                thirds = "A second dozen bet would be a win.";
            }
            else if(thirdz >= 25 && thirdz <= 36)
            {
                thirds = "A third dozen bet would be a win.";
            }
            else if(thirdz == 0 || thirdz == 00)
            {
                thirds = "There is no winning dozens bet for your number.";
            }
            return thirds;
        }
        string col = "";
        public string Columns(string[] rouletteNumbers, int column)
        {
            if(column == 1)
            {
                col = "A left column bet would be a win.";
            }
            else if(column == 4)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 7)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 10)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 13)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 16)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 19)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 22)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 25)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 28)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 31)
            {
                col = "A left column bet would be a win.";
            }
            else if (column == 34)
            {
                col = "A left column bet would be a win.";
            }
            else if(column == 2)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 5)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 8)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 11)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 14)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 17)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 20)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 23)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 26)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 29)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 32)
            {
                col = "A middle column bet would be a win.";
            }
            else if (column == 35)
            {
                col = "A middle column bet would be a win.";
            }
            else if(column == 3)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 6)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 9)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 12)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 15)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 18)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 21)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 24)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 27)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 30)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 33)
            {
                col = "A right column bet would be a win.";
            }
            else if (column == 36)
            {
                col = "A right column bet would be a win.";
            }
            else if(column == 0 || column == 00)
            {
                col = "There is no winning column bet for your number.";
            }
            return col;
        }
        string row = "";
        public string Street(string[] rouletteNumbers, int rows)
        {
            if(rows == 1 || rows == 2 || rows == 3)
            {
                row = "A street one bet would be a win.";
            }
            else if(rows == 4 || rows == 5 || rows == 6)
            {
                row = "A street two bet would be a win.";
            }
            else if(rows == 7 || rows == 8 || rows == 9)
            {
                row = "A street 3 bet would be a win.";
            }
            else if(rows == 10 || rows == 11 || rows == 12)
            {
                row = "A street 4 bet would be a win.";
            }
            else if(rows == 13 || rows == 14 || rows == 15)
            {
                row = "A street 5 bet would be a win.";
            }
            else if(rows == 16 || rows == 17 || rows == 18)
            {
                row = "A street 6 bet would be a win.";
            }
            else if(rows == 19 || rows == 20 || rows == 21)
            {
                row = "A street 7 bet would be a win.";
            }
            else if(rows == 22 || rows == 23 || rows == 24)
            {
                row = "A street 8 bet would be a win.";
            }
            else if(rows == 25 || rows == 26 || rows == 27)
            {
                row = "A street 9 bet would be a win.";
            }
            else if(rows == 28 || rows == 29 || rows == 30)
            {
                row = "A street 10 bet would be a win.";
            }
            else if(rows == 31 || rows == 32 || rows == 33)
            {
                row = "A street 11 bet would be a win.";
            }
            else if(rows == 34 || rows == 35 || rows == 36)
            {
                row = "A street 12 bet would be a win.";
            }
            else if(rows == 0 || rows == 00)
            {
                row = "There is no winning street bet.";
            }
            return row;
        }
        string rows = "";
        public string DoubleStreet(string[] rouletteNumbers, int doub)
        {
            if (doub == 1 || doub == 2 || doub == 3)
            {
                rows = "A double street bet in rows 1 and 2 would be a win.";
            }
            else if (doub == 4 || doub == 5 || doub == 6)
            {
                rows = "A double street bet in rows 1 and 2 or 2 and 3 would be a win.";
            }
            else if (doub == 7 || doub == 8 || doub == 9)
            {
                rows = "A double street bet in 2 and 3 or 3 and 4 would be a win..";
            }
            else if (doub == 10 || doub == 11 || doub == 12)
            {
                rows = "A double street bet in rows 3 and 4 or 4 and 5 would be a win.";
            }
            else if (doub == 13 || doub == 14 || doub == 15)
            {
                rows = "A double street bet in rows 4 and 5 or 5 and 6 would be a win..";
            }
            else if (doub == 16 || doub == 17 || doub == 18)
            {
                rows = "A double street bet in rows 5 and 6 or 6 and 7 would be a win.";
            }
            else if (doub == 19 || doub == 20 || doub == 21)
            {
                rows = "A double street bet in rows 6 and 7 or 7 and 8 would be a win.";
            }
            else if(doub == 22 || doub == 23 || doub == 24)
            {
                rows = "A double street bet in rows 7 and 8 or 8 and 9 would be a win.";
            }
            else if(doub == 25 || doub == 26 || doub == 27)
            {
                rows = "A double street bet in rows 8 and 9 or 9 and 10 would be a win.";
            }
            else if(doub == 28 || doub == 29 || doub == 30)
            {
                rows = "A double street bet in rows 9 and 10 or 10 and 11 would be a win.";
            }
            else if(doub == 31 || doub == 32 || doub == 33)
            {
                rows = "A double street bet in rows 10 and 11 or 11 and 12 would be a win.";
            }
            else if(doub == 34 || doub == 35 || doub == 36)
            {
                rows = "A double street bet in rows 11 and 12 would be a win.";
            }
            else if(doub == 0 || doub == 00)
            {
                rows = "There is no winning double street bet.";
            }
            return rows;
        }
        string split = "";
        public string Split(string[] rouletteNumbers, int sp)
        {
            if (sp == 1)
            {
                split = "A split bet in 1/2 or 1/4 would be a win.";
            }
            else if (sp == 2)
            {
                split = "A split bet in 2/1, 2/3, or 2/5 would be a win.";
            }
            else if (sp == 3)
            {
                split = "A split bet in 3/2 or 3/6 would be a win.";
            }
            else if (sp == 4)
            {
                split = "A split bet in 4/1, 4/5, or 4/7 would be a win.";
            }
            else if (sp == 5)
            {
                split = "A split bet in 5/4, 5/2, 5/6 or 5/8 would be a win.";
            }
            else if (sp == 6)
            {
                split = "A split bet in 6/5, 6/3, or 6/9 would be a win.";
            }
            else if (sp == 7)
            {
                split = "A split bet in 7/4, 7/8, or 7/10 would be a win.";
            }
            else if (sp == 8)
            {
                split = "A split bet in 8/7, 8/5, 8/9 or 8/11 would be a win.";
            }
            else if (sp == 9)
            {
                split = "A split bet in 9/8, 9/6, or 9/12 would be a win.";
            }
            else if (sp == 10)
            {
                split = "A split bet in 10/7, 10/11, or 10/13 would be a win.";
            }
            else if (sp == 11)
            {
                split = "A split bet in 11/10, 11/8, 11/12, or 11/14 would be a win.";
            }
            else if (sp == 12)
            {
                split = "A split bet in 12/9, 12/11, or 12/15 would be a win.";
            }
            else if (sp == 13)
            {
                split = "A split bet in 13/10, 13/14, or 13/16 would be a win.";
            }
            else if (sp == 14)
            {
                split = "A split bet in 14/13, 14/11, 14/15, or 14/17 would be a win.";
            }
            else if (sp == 15)
            {
                split = "A split bet in 15/14, 15/12, or 15/18 would be a win.";
            }
            else if (sp == 16)
            {
                split = "A split bet in 16/13, 16/17, or 16/19 would be a win.";
            }
            else if (sp == 17)
            {
                split = "A split bet in 17/16, 17/14, 17/18 or 17/20 would be a win.";
            }
            else if (sp == 18)
            {
                split = "A split bet in 18/17, 18/15, or 18/21 would be a win.";
            }
            else if (sp == 19)
            {
                split = "A split bet in 19/16, 19/20, or 19/22 would be a win.";
            }
            else if (sp == 20)
            {
                split = "A split bet in 20/19, 20/17, 20/21, or 20/23 would be a win.";
            }
            else if (sp == 21)
            {
                split = "A split bet in 21/18, 21/20, or 21/24 would be a win.";
            }
            else if (sp == 22)
            {
                split = "A split bet in 22/19, 22/23, or 22/25 would be a win.";
            }
            else if (sp == 23)
            {
                split = "A split bet in 23/20, 23/22, 23/24, or 23/26 would be a win.";
            }
            else if (sp == 24)
            {
                split = "A split bet 24/23, 24/21, or 24/27 would be a win.";
            }
            else if (sp == 25)
            {
                split = "A split bet in 25/22, 25/26, or 25/28 would be a win.";
            }
            else if (sp == 26)
            {
                split = "A split bet in 26/25, 26/23, 26/27, or 26/29 would be a win.";
            }
            else if (sp == 27)
            {
                split = "A split bet in 27/26, 27/24, or 27/30 would be a win.";
            }
            else if (sp == 28)
            {
                split = "A split bet in 28/25, 28/29, or 28/31 would be a win.";
            }
            else if (sp == 29)
            {
                split = "A split bet in 29/28, 29/26, 29/30, or 29/32 would be a win.";
            }
            else if (sp == 30)
            {
                split = "A split bet in 30/27, 30/29, or 30/33 would be a win.";
            }
            else if (sp == 31)
            {
                split = "A split bet in 31/28, 31/32, or 31/34 would be a win.";
            }
            else if (sp == 32)
            {
                split = "A split bet in 32/31, 32/33, 32/29, or 32/35 would be a win.";
            }
            else if (sp == 33)
            {
                split = "A split bet in 33/32, 33/30, or 33/36 would be a win.";
            }
            else if (sp == 34)
            {
                split = "A split bet in 34/31 or 34/35 would be a win.";
            }
            else if (sp == 35)
            {
                split = "A split bet in 35/34, 35/32, or 35/36 would be a win.";
            }
            else if (sp == 36)
            {
                split = "A split bet in 36/35 or 33/33 would be a win.";
            }
            else if (sp == 0)
            {
                split = "There is no winning split bet for your number.";
            }
            else if (sp == 00)
            {
                split = "There is no winning split bet for your number.";
            }
            return split;
        }
        string corner = "";
        public string Corners(string[] rouletteNumbers, int corn)
        {
            if(corn == 1)
            {
                corner = "A winning corner bet would be 1/2/4/5.";
            }
            else if(corn == 2)
            {
                corner = "A winning corner bet would be 1/2/4/5 or 2/3/5/6.";
            }
            else if(corn == 3)
            {
                corner = "A winning corner bet would be 2/3/5/6.";
            }
            else if(corn == 4)
            {
                corner = "A winning corner bet would be 1/2/4/5 or 4/5/7/8.";
            }
            else if(corn == 5)
            {
                corner = "A winning corner bet would be 1/2/4/5, 2/3/5/6, 4/5/7/8, or 5/6/8/9.";
            }
            else if(corn == 6)
            {
                corner = "A winning corner bet would be 2/3/5/6 or 5/6/8/9.";
            }
            else if(corn == 7)
            {
                corner = "A winning corner bet would be 4/5/7/8 or 7/8/10/11.";
            }
            else if(corn == 8)
            {
                corner = "A winning corner bet would be 4/5/7/8, 5/6/8/9, 8/9/11/12, or 7/8/10/11.";
            }
            else if(corn == 9)
            {
                corner = "A winning corner bet would be 5/6/8/9 or 8/9/11/12.";
            }
            else if(corn == 10)
            {
                corner = "A winning corner bet would be 7/8/10/11 or 10/11/13/14.";
            }
            else if(corn == 11)
            {
                corner = "A winning corner bet would be 7/8/10/11, 8/9/11/12, 10/11/13/14, or 11/12/14/15.";
            }
            else if(corn == 12)
            {
                corner = "A winning corner bet would be 8/9/11/12 or 11/12/14/15.";
            }
            else if(corn == 13)
            {
                corner = "A winning corner bet would be 10/11/13/14 or 13/14/16/17.";
            }
            else if(corn == 14)
            {
                corner = "A winning corner bet would be 10/11/13/14, 11/12/14/15, 13/14/16/17 or 14/15/17/18.";
            }
            else if(corn == 15)
            {
                corner = "A winning corner bet would be 11/12/14/15 or 14/15/17/18.";
            }
            else if(corn == 16)
            {
                corner = "A winning corner bet would be 13/14/16/17 or 16/17/19/20.";
            }
            else if(corn == 17)
            {
                corner = "A winning corner bet would be 13/14/16/17, 14/15/17/18, 17/18/20/21 or 16/17/19/20.";
            }
            else if(corn == 18)
            {
                corner = "A winning corner bet would be 14/15/17/18 or 17/18/20/21.";
            }
            else if(corn == 19)
            {
                corner = "A winning corner bet would be 16/17/19/20 or 19/20/22/23.";
            }
            else if(corn == 20)
            {
                corner = "A winning corner bet would be 16/17/19/20, 17/18/20/21, 19/20/22/23 or 20/21/23/24.";
            }
            else if(corn == 21)
            {
                corner = "A winning corner bet would be 17/18/20/21 or 20/21/23/24.";
            }
            else if(corn == 22)
            {
                corner = "A winning corner bet would be 19/20/22/23 or 22/23/25/26.";
            }
            else if(corn == 23)
            {
                corner = "A winning corner bet would be 19/20/22/23, 20/21/23/24, 22/23/25/26 or 23/24/26/27.";
            }
            else if(corn == 24)
            {
                corner = "A winning corner bet would be 20/21/23/24 or 23/24/26/27.";
            }
            else if(corn == 25)
            {
                corner = "A winning corner bet would be 22/23/25/26 or 25/26/28/29.";
            }
            else if(corn == 26)
            {
                corner = "A winning corner bet would be 22/23/25/26, 23/24/26/27, 25/26/28/29 or 26/27/29/30.";
            }
            else if(corn == 27)
            {
                corner = "A winning corner bet would be 23/24/26/27 or 26/27/29/30.";
            }
            else if(corn == 28)
            {
                corner = "A winning corner bet would be 25/26/28/29 or 28/29/31/32.";
            }
            else if(corn == 29)
            {
                corner = "A winning corner bet would be 25/26/28/29, 26/27/29/30, 28/29/31/32 or 29/30/32/33.";
            }
            else if(corn == 30)
            {
                corner = "A winning corner bet would be 26/27/29/30 or 29/30/32/33.";
            }
            else if(corn == 31)
            {
                corner = "A winning corner bet would be 28/29/31/32 or 31/32/34/35.";
            }
            else if(corn == 32)
            {
                corner = "A winning corner bet would be 28/29/31/32, 29/30/32/33, 31/32/34/35 or 32/33/35/36.";
            }
            else if(corn == 33)
            {
                corner = "A winning corner bet would be 29/30/32/33 or 32/33/35/36.";
            }
            else if(corn == 34)
            {
                corner = "A winning corner bet would be 31/32/34/35.";
            }
            else if(corn == 35)
            {
                corner = "A winning corner bet would be 31/32/34/35 or 32/33/35/36.";
            }
            else if(corn == 36)
            {
                corner = "A winning corner bet would be 32/33/35/36.";
            }
            else if(corn == 0 || corn == 00)
            {
                corner = "There is no winning corner bet for your number.";
            }
            return corner;
        }
    }
    
}
