﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms.UnitTests
{
    public static class ExtensionMethods
    {
        public static bool IsArrayEqual(this int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                return false;
            if (array1.Length == 0 || array2.Length == 0)
                return false;
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
