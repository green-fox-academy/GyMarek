using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FrontendTest.TestFixtures
{
    [CollectionDefinition("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
    }
}
