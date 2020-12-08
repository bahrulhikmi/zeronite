namespace Zeronite.Infra.Permissions
{
    public static class InfraPermissions
    {
        public const string GroupName = "Infra";

        
        public static class Books
        {
            public const string Default = GroupName + ".Books";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
        }
        
        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";
    }
}
