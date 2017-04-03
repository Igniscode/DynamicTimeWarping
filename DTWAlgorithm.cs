using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicTimeWarping
{

    public class DTWAlgorithm
    {
        public List<List<float>> DTWDistance(List<float> s , List<float> t)
        {
            List <List<float>> DTW = new List<List<float>>(s.Count);

            DTW.Add(new List<float>(t.Count));
            for (int i = 0; i < s.Count; i++)
            {
                DTW.Add(new List<float>());
            }
            DTW[0].Add(0);

            for (int i = 1; i < s.Count; i ++)
            {
                DTW[i].Add(999999.0f);
            }
            for (int i = 1; i < t.Count; i++)
            {
                DTW[0].Add(999999.0f);
            }
            

            for (int i = 1; i < s.Count; i++)
            {
                for(int j = 1; j < t.Count; j++)
                {
                    float cost = d(s[i], t[j]);
                    DTW[i].Add(cost + min(DTW[i - 1][j], min(DTW[i][j - 1], DTW[i - 1][j - 1])));
                }
            }
            return DTW;    
        }

        float d(float x, float y)
        {
            return Math.Abs(x - y);
        }

        float min(float a, float b)
        {
            if (a >= b)
            {
                return b;
            }
            return a;
        }
        public List<float> Initializer(int Limit_of_rand , int Size_of_list)
        {
            List<float> temp = new List<float>();
            Random rand = new Random();

            int init_Value = rand.Next(0, Limit_of_rand);

            for (int i = 0; i < Size_of_list; i++)
            {
                temp.Add(Accelator(init_Value, Limit_of_rand));
                System.Threading.Thread.Sleep(1);
            }
            return temp;
        }

        float Accelator(int v, int l)
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 50)
            {
                return rand.Next(0, l);
            }
            return v;
        }

    }
}
