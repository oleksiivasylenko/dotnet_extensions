namespace EverNetExtensionTests.Models
{

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RoleArea RoleArea { get; set; }

        public Role()
        {
        }

        public Role(int id, string name, RoleArea roleArea)
        {
            Id = id;
            Name = name;
            RoleArea = roleArea;
        }
    }
}
