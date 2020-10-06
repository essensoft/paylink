using Essensoft.AspNetCore.Payment.Alipay.Parser;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Xunit;

namespace Essensoft.AspNetCore.Payment.Alipay.Tests
{
    public class AlipayOpenAuthTokenAppResponseTests
    {
        [Fact]
        public void Parse()
        {
            var respBody = @"{
    ""alipay_open_auth_token_app_response"": {
        ""code"": ""10000"",
        ""msg"": ""Success"",
        ""app_auth_token"": ""3947DD4AFCDF47D2B19B70B4EC2E6D95"",
        ""app_refresh_token"": ""90AAF89CCB5848EC9F1D9F80A0ACAEFD}"",
        ""auth_app_id"": ""2016000000000000"",
        ""expires_in"": 31536000,
        ""re_expires_in"": 32140800,
        ""tokens"": [
            {
                ""app_auth_token"": ""3947DD4AFCDF47D2B19B70B4EC2E6D95"",
                ""app_refresh_token"": ""90AAF89CCB5848EC9F1D9F80A0ACAEFD"",
                ""auth_app_id"": ""2016000000000000"",
                ""expires_in"": 31536000,
                ""re_expires_in"": 32140800,
                ""user_id"": ""2088100000000000""
            }
        ],
        ""userid"": ""2088100000000000"",
        ""sign"": ""PGhIW6oyPb0eZ5rdzvfk02LFQQDQ17UEgMOcDAbkf2yKrb9vvRR/44nVrtőkv4hS97hxEH9ppyqff8ltwrUtejrhisSiy6eH2v4lfzjgDkS9vp2OhSrmquorwAEhSXYKyap1GK2TRiprPFNJtfkFhcG/d838liJs4SWX2oCEtL3fOogpM4EOMayhEkV57yQPh4w2vIFsP519zvNSZ2DuNT8Td5VIGp1nwR4Tal1Rp7+Th0+7Jk6YHAMftXACiq40hN1NBr67IWBJ01+zzc6YsZecL2NQLvugu9kP2do0QB3aQ/SGXtlQShV7HdBTE3JseOCD1QONOKO7iKJRdJfzoYfg==""
    }
}";
            var parser = new AlipayJsonParser<AlipayOpenAuthTokenAppResponse>();
            var resp = parser.Parse(respBody);
            Assert.Equal("3947DD4AFCDF47D2B19B70B4EC2E6D95", resp.AppAuthToken);
            Assert.NotNull(resp.Tokens);
        }
    }
}
