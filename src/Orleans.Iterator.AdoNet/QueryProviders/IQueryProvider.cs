﻿namespace Orleans.Iterator.AdoNet.QueryProviders;
internal interface IQueryProvider
{
    string GetSelectGrainIdQuery(bool ignoreNullState, int grainTypeStringCount = 1);
}
