using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    internal class ArrClass
    {
        int[] arr= new int[100];
        int last_Index = 0;
        public void clear()
        {
            last_Index = 0;
        }
        public bool isEmpty()
        {
            return last_Index == 0;
        }
        public int SaveArr(string value)
        {
            value = value.Trim();
            string[] arrs = value.Split(' ');
            if(arrs.Length == 0)
            {
                return -1;
            }
            foreach(string it in arrs)
            {
                arr[last_Index++] = int.Parse(it);
            }
            return 0;
        }
        public override string ToString()
        {
            string st = string.Empty;
            for (int i =0; i< last_Index ; ++i)
            {
                st += arr[i] + " ";
            }
            return st;
        }
        public int Search(int value,bool vl)
        {
            for (int i =0;i< last_Index;++i)
            {
                if (value == arr[i])
                    return i;
            }
            return -1;
        }
        public int Search (int index)
        {
            return arr[index];
        }
        public int SortAsc()
        {
            try
            {
                for (int i = 0; i < last_Index; ++i)
                {
                    for (int j = 0; j < last_Index; ++j)
                    {
                        if (arr[j] < arr[i])
                        {
                            int temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                return 1;
            }  
            catch
            {
                return -1;
            }
        }
        public int SortDsc()
        {
            try
            {
                for (int i = 0; i < last_Index; ++i)
                {
                    for (int j = 0; j < last_Index; ++j)
                    {
                        if (arr[j] > arr[i])
                        {
                            int temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public int delete(int value , bool val)
        {
            int idx = Search(value, true);
            if(idx != -1)
            {
                for(int i = idx; i <last_Index; ++i)
                {
                    arr[i] = arr[i + 1];
                }
                return 1;
            }
            return -1;
        }
        public int delete(int indx)
        {
            if (indx != -1)
            {
                for (int i = indx; i < last_Index; ++i)
                {
                    arr[i] = arr[i + 1];
                }
                return 1;
            }
            return -1;
        }
        public int Add(int idx ,int value )
        {
            if(idx >=-1)
            {
                for(int i = last_Index-1; i > idx; --i)
                {
                    arr[i] = arr[i - 1];
                }
                arr[idx] = value;
                return 1;
            }
            return -1;
        }
        public int TongMang()
        {
            int sum = 0;
            for (int i = 0; i < last_Index; ++i)
            {
                    sum += arr[i];
            }
            return sum;
        }
        public int TongChan()
        {
            int sum = 0;
            for(int i =0;i<last_Index;++i)
            {
                if (arr[i] % 2 ==0)
                sum += arr[i];
            }
            return sum;
        }
        public int TongLe()
        {
            int sum = 0;
            for (int i = 0; i < last_Index; ++i)
            {
                if (arr[i] % 2 != 0)
                    sum += arr[i];
            }
            return sum;
        }
    }
}
