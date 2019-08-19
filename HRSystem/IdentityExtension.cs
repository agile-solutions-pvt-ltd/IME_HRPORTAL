using System.Security.Claims;
using System.Security.Principal;

namespace HRSystem
{
    public static class IdentityExtension
    {
        public static string GetEmployeeNo(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
            Claim claim = claimsIdentity?.FindFirst("EmployeeNo");

            if (claim == null)
                return "";

            return claim.Value;
        }

        public static string GetUserName(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
            Claim claim = claimsIdentity?.FindFirst("UserName");

            if (claim == null)
                return "";

            return claim.Value;
        }

        public static string GetPassword(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
            Claim claim = claimsIdentity?.FindFirst("Password");

            if (claim == null)
                return "";

            return claim.Value;
        }

        public static string GetCompanyName(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
            Claim claim = claimsIdentity?.FindFirst("CompanyName");

            if (claim == null)
                return "";

            return claim.Value;
        }
    }
}
