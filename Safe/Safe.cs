﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    public class Safe
    {
        private string contents = "cenne klejnoty";
        private string safeCombination = "12345";

        public string Open(string combination)
        {
            if (combination == safeCombination) return contents;
            return "";
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.Combination = safeCombination;
        }
    }
}
