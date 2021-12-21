using System.Collections.Generic;

namespace _21_11_2021.Models
{
    public static class Repository
    {
        private static List<Member> members = new List<Member>();

        private static List<Training> trainings = new List<Training>();

        public static IEnumerable<Training> Trainings => trainings;

        public static IEnumerable<Member> Members => members;

        public static void AddMember(Member member)
        {
            members.Add(member);
        }
    }
}
