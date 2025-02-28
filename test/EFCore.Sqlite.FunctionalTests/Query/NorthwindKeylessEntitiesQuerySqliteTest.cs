// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Data.Sqlite;

namespace Microsoft.EntityFrameworkCore.Query;

public class NorthwindKeylessEntitiesQuerySqliteTest : NorthwindKeylessEntitiesQueryRelationalTestBase<
    NorthwindQuerySqliteFixture<NoopModelCustomizer>>
{
    public NorthwindKeylessEntitiesQuerySqliteTest(
        NorthwindQuerySqliteFixture<NoopModelCustomizer> fixture,
        ITestOutputHelper testOutputHelper)
        : base(fixture)
    {
        Fixture.TestSqlLoggerFactory.Clear();
        //Fixture.TestSqlLoggerFactory.SetTestOutputHelper(testOutputHelper);
    }

    public override void KeylessEntity_with_nav_defining_query()
        // FromSql mapping. Issue #21627.
        => Assert.Throws<SqliteException>(
            () => base.KeylessEntity_with_nav_defining_query());
}
