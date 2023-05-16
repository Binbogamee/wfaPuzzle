using System;
using System.IO;
using System.Windows.Forms;

namespace wfaPuzzle
{
    internal class Game
    {
        public int CountResources { get; private set; }
        public int SizePic { get; set; }
        public object Picture { get; set; }
        public bool win { get; private set; }

        private int[,] locationDetail;

        public void DoReset()
        {
            locationDetail = null;
            CountResources = new DirectoryInfo(@"../../../Resources").GetFiles().Length - 2;
            SizePic = 0;
            Picture = null;
            win = false;
        }

        public void CreateArray()
        {
            if (SizePic > 0)
            {
                int count = 1;
                locationDetail = new int[SizePic, SizePic];
                for (int i = 0; i < SizePic; i++)
                {
                    for (int j = 0; j < SizePic; j++)
                    {
                        locationDetail[i, j] = count;
                        count++;
                    }
                }
            }
        }

        public void CheckFinish(Control pic, int i, int j)
        {
            win = false;
            if (pic != null)
            {
                if (locationDetail[i, j] == Convert.ToInt32(pic.Tag))
                {
                    win = true;
                }
                else
                {
                    win = false;
                }
            }

        }
    }
}