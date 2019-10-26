namespace Backomm.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
             
        public const string Version = "v1";
     
        public const string Base = Root + "/" + Version;   
        
        public static class Auth
        {
            public const string Login = Base + "/auth/login";

            public const string Register = Base + "/auth/register";
        }

        public static class Group
        {
            public const string Get = Base + "/groups";

            public const string JoinGroup = Base + "/groups";
            
            public const string GetById = Base + "/groups/{GroupId}";
        }

        public static class Category
        {
            public const string Get = Base + "/categories";
            
            public const string GetById = Base + "/categories/{CategoryId}";
        }

        public static class Event
        {
            public const string Get = Base + "/events";

            public const string CreateEvent = Base + "/events";
            
            public const string JoinEvent = Base + "/eventJoin";
            
            public const string GetById = Base + "/events/{EventId}";

        }

        public static class User
        {
            public const string Me = Base + "/user/me";

            public const string UserEvents = Base + "/user/events";

            public const string UserGroups = Base + "/user/groups";
        }

    }
}