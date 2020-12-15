using System.Threading.Tasks;
using LYP.BH.Models.TokenAuth;
using LYP.BH.Web.Controllers;
using Shouldly;
using Xunit;

namespace LYP.BH.Web.Tests.Controllers
{
    public class HomeController_Tests: BHWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}