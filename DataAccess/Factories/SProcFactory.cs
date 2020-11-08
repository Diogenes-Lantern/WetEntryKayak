﻿using DataAccess.Constants;

namespace DataAccess.Factories
{
    internal static class SProcFactory
    {
        internal static string RetrieveCreateSProcName<T>()
        {
            string sProc;
            switch (typeof(T))
            {
                default:
                    sProc = SProcNames.CreateCustomerSProcName;
                    break;
            }
            return sProc;
        }

        internal static string RetrieveRetrievalSProcName<T>()
        {
            string sProc;
            switch (typeof(T))
            {
                default:
                    sProc = SProcNames.CreateCustomerSProcName;
                    break;
            }
            return sProc;
        }
    }
}
