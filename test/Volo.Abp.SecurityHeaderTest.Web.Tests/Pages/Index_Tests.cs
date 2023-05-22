using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Volo.Abp.SecurityHeaderTest.Pages;

public class Index_Tests : SecurityHeaderTestWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
