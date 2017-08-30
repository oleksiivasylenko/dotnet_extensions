namespace EverNetExtensionTests.Models
{
    public class RoleArea
    {
        public int Id { get; set; }

        public RoleAreaType Type { get; set; }

        public RoleArea()
        {
        }

        public RoleArea(int id, RoleAreaType type)
        {
            Id = id;
            Type = type;
        }
    }
}