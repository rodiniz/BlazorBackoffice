using System.Collections.Generic;

namespace BackOffice.Helper
{
 public static class Constants
    {
        public const string HealthEndpoint = "health";
        public const string HealthDependenciesTagName = "Dependencies";
        public const string HealthInternalServicesTagName = "Internal";
        public const string SystemsTagName = "Systems";
        public const string GatewayApiHealthTagName = "Gateway API";
        public const string StsApiHealthTagName = "Sts API";

        public const string ApplicationDateFormat = "dd/MM/yyyy";
        public const string ApplicationDateTimeFrFormat = "dd/MM/yyyy HH:mm:ss";
        public const string ApplicationDateTimeEnFormat = "MM/dd/yyyy HH:mm:ss";
        public const string ApplicationTimeFormat = "HH:mm:ss";
        public const string CorrId = "CorrId";

        public const string MicroserviceDateFormat = "MM/dd/yyyy";
        public const string MicroserviceDateTimeFormat = "yyyy-MM-ddTHH:mm:ss";

        public const string StsClient = "StsClient";
        public const string TechnicalOnlyPolicy = "TechnicalOnlyPolicy";
        public const string OperatorsOnlyPolicy = "OperatorsOnlyPolicy";
        public const string OperatorsOrFinancialOnlyPolicy = "OperatorsOrFinancialOnlyPolicy";
        public const string SeniorOperatorOnlyPolicy = "SeniorOperatorOnlyPolicy";
        public const string BackOfficeOnlyPolicy = "BackOfficePolicy";

        public const int DefaultPageSize = 50;
        public const string NextPageRelationContent = "next-page";
        public const string PreviousPageRelationContent = "previous-page";

        public static class Roles
        {
            public const string JuniorOperator = "JuniorOperator";
            public const string SeniorOperator = "SeniorOperator";
            public const string Financial = "Financial";
            public const string Technical = "Technical";
            public const string BackOffice = "BackOffice";
        }

        public static readonly Dictionary<int, int> ErrorCodeMapping = new Dictionary<int, int>
        {
            // 1xx transactions
            // 2xx cards
            // 3xx beneficiaries
            // 4xx token
            // 5xx customers
            // 6xx cards
            // Left, bib error code. Right, ower error code
            { 147, 100 },
            { 825, 101 },
            { 356, 102 },
            { 110, 103 },
            { 111, 104 },
            { 149, 105 },
            { 344, 107 },
            { 703, 108 },
            { 710, 110 },
            { 715, 111 },
            { 1031, 112 },
            { 568, 113 },
            { 151, 114 },
            { 820, 115 },
            { 1025, 116 },
            { 112, 117 },
            { 127, 118 },
            { 177, 120 },
            { 343, 121 },
            { 345, 122 },
            { 362, 123 },
            { 500, 124 },
            { 701, 125 },
            { 702, 126 },                
         	

            // beneficiaries
            { 176, 300 },
            { 178, 301 },
            { 179, 302 },
            { 180, 303 },
            { 181, 304 },
            { 182, 306 },
            { 183, 306 },
            { 184, 307 },
            { 185, 308 },
            { 186, 309 },
            { 187, 310 },
            { 188, 311 },
            { 189, 312 },
            { 190, 313 },
            { 551, 314 },
            { 556, 315 },
            { 704, 316 },
            { 709, 317 },
            { 302, 318 },
            { 573, 319 },
            { 1050, 320 },
            // token  
            { 195, 400 },
            { 364, 401 },
            { 569, 402 },
            { 570, 403 },
            { 11053,404 },
            //customers
            { 567, 500 },
            { 719, 501 },
            { 377, 502 },
            { 312, 503 },
            { 350, 504 },
            { 514, 505 },
            { 515, 506 },
            { 378, 507 },
            { 5977, 508 },
            { 6001, 509 },
            { 6002, 510 },
            { 6003, 511 },
            { 6004, 512 },
            { 6005, 513 },
            { 550,  514 },
            { 1100, 515 },
            { 1101, 516 },
            { 1102, 517 },
            //cards
            { 717, 600},
            { 1066, 601 },
            { 1071, 602 },
            { 1068, 603}



        };
    }
    }
