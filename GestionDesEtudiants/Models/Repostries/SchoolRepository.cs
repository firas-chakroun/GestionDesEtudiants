using GestionDesEtudiants.Models.ViewModels;

namespace GestionDesEtudiants.Models.Repostries
{
    public class SchoolRepository : ISchoolRepository
    {
        readonly StudentContext context;
        public SchoolRepository(StudentContext context)
        {
            this.context = context;
        }
        public IList<School> GetAll()
        {
            return context.Schools.OrderBy(s => s.SchoolName).ToList();
        }
        public School GetById(int id)
        {
            return context.Schools.Find(id);
        }
        public void Add(School s)
        {
            context.Schools.Add(s);
            context.SaveChanges();
        }
        public void Edit(School s)
        {
            School s1 = context.Schools.Find(s.SchoolID);
            if (s1 != null)
            {
                s1.SchoolName = s.SchoolName;
                s1.SchoolAdress = s.SchoolAdress;
                context.SaveChanges();
            }
        }

        public void Delete(School s)
        {
            throw new NotImplementedException();
        }

        public double StudentAgeAverage(int schoolId)
        {
            throw new NotImplementedException();
        }

        public int StudentCount(int schoolId)
        {
            throw new NotImplementedException();
        }
    }
}
