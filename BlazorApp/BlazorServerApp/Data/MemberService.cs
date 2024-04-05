using BlazorServerApp.Models.Entities;
using BlazorServerApp.Models.ViewModels;

namespace BlazorServerApp.Data
{
    public class MemberService : IMemberService
    {
        private readonly AppDbContext _dbContext;

        public MemberService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Member> GetMembers()
        {
            return _dbContext.Members.ToList();
        }

        public Member GetMemberById(int memberId)
        {
            return _dbContext.Members.FirstOrDefault(m => m.Id == memberId);
        }

        public void AddMember(Member member)
        {
            _dbContext.Members.Add(member);
            _dbContext.SaveChanges();
        }

        public void UpdateMember(Member member)
        {
            var existingMember = _dbContext.Members.FirstOrDefault(m => m.Id == member.Id);
            if (existingMember != null)
            {
                existingMember.Name = member.Name;
                existingMember.Email = member.Email;
                existingMember.Age = member.Age;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteMember(int memberId)
        {
            var memberToDelete = _dbContext.Members.FirstOrDefault(m => m.Id == memberId);
            if (memberToDelete != null)
            {
                _dbContext.Members.Remove(memberToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}
