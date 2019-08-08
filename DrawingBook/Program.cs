using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {

        static int pageCount(int n, int p)
        {
            int minPageCountReverse=0, minPageCountStr=0, minPageCount=0;
            int curPageNum=1;
            int otherPage = 1;
            int ind = 0;

            do
            {
                if (curPageNum == p || otherPage==p)
                {
                    minPageCountStr = ind;
                    break;
                }
                ind++;

                if (curPageNum + 2 <= n)
                {
                    curPageNum += 2;
                    otherPage = curPageNum - 1;
                }
                else
                    curPageNum++;

            } while (curPageNum<=n);

            ind = 0;
            curPageNum = n;
            int lastPageBalance = 0;

            if ((n - 1) % 2 == 0)
            {
                otherPage = n - 1;
                lastPageBalance = 0;
            }
            else
            {
                otherPage = n;
                lastPageBalance = 2;
            }

            do
            {
                if (curPageNum == p || otherPage == p)
                {
                    minPageCountReverse = ind;
                    break;
                }
                ind++;

                if (curPageNum - 2 > 0)
                {
                    curPageNum -= 2;
                    otherPage = curPageNum - 1 + lastPageBalance;
                }
                else
                    curPageNum--;

            } while (curPageNum > 0);

            if (minPageCountStr < minPageCountReverse)
                minPageCount = minPageCountStr;
            else
                minPageCount = minPageCountReverse;

            return minPageCount;
        }
        static void Main(string[] args)
        {

            int n = 18183;

            int p = 18042;

            int result = pageCount(n, p);
        }
    }
}
