using Microsoft.VisualStudio.TestTools.UnitTesting;
using TenMinuteMailApi;

namespace TenMinuteMailApiTest
{
    [TestClass]
    public class TenMinuteMailDotComTest
    {
        [TestMethod]
        public void ObtainEmailBox_CalledFirstTime_NewEmailAddressReturned()
        {
            var target = new TenMinuteMailDotCom();

            var actual = target.ObtainEmailBox();

            Assert.IsFalse(actual.Contains("@"));
        }
    }
}
