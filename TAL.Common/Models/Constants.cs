namespace TAL.Common.Models
{
    public static class Constants
    {
        #region TAL API

        #region Startup     
        public const string TAL_API_nlog = "/nlog.config";
        public const string TAL_API_SqlConnection = "sqlConnection";
        public const string TAL_API_TAL_API_Assembly = "TAL API";
        public const string TAL_API_Cors_URL = "http://localhost:4200";
        public const string TAL_API_Configuration_MySettings = "MySettings";
        public const string TAL_API_Configuration_corsurl = "corsurl";

        public const string TAL_API_Swagger_Title = "TAL_API";
        public const string TAL_API_Swagger_Endpoint = "/swagger/v1/swagger.json";
        public const string TAL_API_Swagger_Version = "v1";
        #endregion

        #region ExceptionMiddleware & Extensions     
        public const string TAL_API_ContentType = "application/json";
        public const string TAL_API_LogError = "Something went wrong: ";
        public const string TAL_API_LogError1 = "A new violation exception has been thrown: ";
        public const string TAL_API_LogError2 = "Access violation error from the custom middleware";
        public const string TAL_API_LogError3 = "Internal Server Error from the custom middleware.";
        public const string TAL_API_InternalServerError = "Internal Server Error.";
        #endregion

        #endregion

        #region TAL DAL
        public const string TAL_DAL_Entity_Occupations = "Occupations";
        public const string TAL_DAL_Entity_Occupations_Cleaner = "Cleaner";
        public const string TAL_DAL_Entity_Occupations_Doctor = "Doctor";
        public const string TAL_DAL_Entity_Occupations_Author = "Author";
        public const string TAL_DAL_Entity_Occupations_Farmer = "Farmer";
        public const string TAL_DAL_Entity_Occupations_Mechanic = "Mechanic";
        public const string TAL_DAL_Entity_Occupations_Florist = "Florist";

        public const string TAL_DAL_Entity_OccupationRating = "OccupationRating";
        public const string TAL_DAL_Entity_OccupationRating_Professional = "Professional";
        public const string TAL_DAL_Entity_OccupationRating_White_Collar = "White Collar";
        public const string TAL_DAL_Entity_OccupationRating_Light_Manual = "Light Manual";
        public const string TAL_DAL_Entity_OccupationRating_Heavy_Manual = "Heavy Manual";

        public const string TAL_DAL_Model_nvarchar = "nvarchar(100)";
        public const string TAL_DAL_Model_Decimal = "decimal(5,2)";
        public const string TAL_DAL_Model_OccupationRatingRefId = "OccupationRatingRefId";
        #endregion

        #region Unit Test
        public const string TAL_Test_Context_TALDB = "TALDB";
        #endregion
    }
}
