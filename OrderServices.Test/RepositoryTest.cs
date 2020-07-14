using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace OrderServices.Test
{
    public class RepositoryTest
    {
        [Fact]
        public async Task EmptyString_Accept()
        {
            var content = new StringContent(string.Empty);
            Stream result = await content.ReadAsStreamAsync();
            Assert.Equal(0, result.Length);
        }
    }
}
