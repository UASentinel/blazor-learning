using BlazorServerApp.Models.Entities;
using BlazorServerApp.Models.ViewModels;

namespace BlazorServerApp.Data
{
    public interface IMemberService
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberById(int memberId);
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
    }
}
