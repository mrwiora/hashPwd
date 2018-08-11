using hashPwd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashPwd_utest
{
    [TestClass]
    public class CryptoTest
    {
        [TestMethod]
        public void HashTests()
        {
            Assert.AreEqual("5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8", Crypto.GetHash("password", "", "SHA1", "NONE", false, false));
            Assert.AreEqual("59b3e8d637cf97edbe2384cf59cb7453dfe30789", Crypto.GetHash("password", "salt", "SHA1", "NONE", false, false));
            Assert.AreEqual("1619d7adc23f4f633f11014d2f22b7d8", Crypto.GetHash("password", "", "SHA1", "MD5", false, false));
            Assert.AreEqual("6ff26b6e030e508b957731f8951f27f9", Crypto.GetHash("password", "salt", "SHA1", "MD5", false, false));

            Assert.AreEqual("5f4dcc3b5aa765d61d8327deb882cf99", Crypto.GetHash("password", "", "MD5", "NONE", false, false));
            Assert.AreEqual("67a1e09bb1f83f5007dc119c14d663aa", Crypto.GetHash("password", "salt", "MD5", "NONE", false, false));
            Assert.AreEqual("55c3b5386c486feb662a0785f340938f518d547f", Crypto.GetHash("password", "", "MD5", "SHA1", false, false));
            Assert.AreEqual("4c18da5c9e2084ebc1ee0bf00204408a1bf19523", Crypto.GetHash("password", "salt", "MD5", "SHA1", false, false));

            Assert.AreNotEqual("this is a dummy text", Crypto.GetHash("", "", "", "", false, false));
        }
    }
}
