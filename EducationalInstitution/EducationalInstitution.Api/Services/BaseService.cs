using EducationalInstitution.Api.Models.Common;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using Mapster;

namespace EducationalInstitution.Api.Services
{
    public class BaseService<TEntity, TInput> : IBaseService<TEntity, TInput>
        where TEntity : BaseEntity, new()
        where TInput : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public IQueryable<TEntity> Get()
        {
            return _repository.GetAll();
        }

        public IQueryable<TCustomEntity> Get<TCustomEntity>()
            where TCustomEntity : BaseEntity
        {
            return _repository.GetAll<TCustomEntity>();
        }

        public virtual ListResponse<TEntity> GetAll()
        {
            var result = _repository.GetAll().ToList();

            if (result == null) return ResponseStatus.NotFound;

            return result;
        }

        public virtual ListResponse<TCustomEntity> GetAll<TCustomEntity>()
            where TCustomEntity : BaseEntity
        {
            var result = _repository.GetAll<TCustomEntity>().ToList();

            if (result == null) return ResponseStatus.NotFound;

            return result;
        }

        public virtual SingleResponse<TEntity> GetById(int id)
        {
            var result = _repository.GetById(id);

            if (result == null)
                return ResponseStatus.NotFound;

            return result;
        }


        public virtual SingleResponse<TEntity> Create(TInput input)
        {

            var entity = input.Adapt<TEntity>();
            var result = _repository.Create(entity);

            return result;
        }

        public virtual SingleResponse<TEntity> Update(int id, TInput input)
        {
            var result = _repository.GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var entity = input.Adapt<TEntity>();
            var resultExist = _repository.Update(id, entity);

            return resultExist;
        }

        public virtual SingleResponse<bool> Delete(int id)
        {
            var result = _repository.GetById(id);

            if (result == null) return ResponseStatus.NotFound;

            var resultExist = _repository.Delete(id);
            return resultExist;
        }
    }
}