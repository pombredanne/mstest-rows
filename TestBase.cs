﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestRows
{
    public abstract class TestBase<DATAROW>
    {
        public abstract DATAROW GetNextDataRow(int rowNumber);

        public abstract void TestMethod(DATAROW dataRow, int rowNumber);

        public virtual void TestRowImplementation(int rowNumber)
        {
            DATAROW data = GetNextDataRow(rowNumber);
            TestMethod(data, rowNumber);
        }
    }
}
