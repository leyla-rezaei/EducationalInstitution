using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;

namespace EducationalInstitution.Api.Services.Contracts
{
    public interface IInstructorService : IBaseService<Instructor, InstructorInput>
    { }
}