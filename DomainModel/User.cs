namespace DomainModel
{
    public class User
    {
        public virtual int UserId { get; set; }

        public virtual string UserName { get; set; }

        public virtual string UserPw { get; set; }
    }
}
