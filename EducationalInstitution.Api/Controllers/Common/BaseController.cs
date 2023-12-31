﻿using EducationalInstitution.Api.Models.Common;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Common.Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EducationalInstitution.Api.Controllers.Common
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TService, TEntity, TInput> : ControllerBase
            where TService : IBaseService<TEntity, TInput>
            where TEntity : BaseEntity, new()
            where TInput : class
    {
        private readonly TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        [EnableCors("PublicApi")]
        public ListResponse<TEntity> GetAll()
        {
            return _service.GetAll<TEntity>();
        }

        [HttpGet("id")]
        [EnableCors("PublicApi")]
        public SingleResponse<TEntity> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public SingleResponse<TEntity> Create(TInput input)
        {
            return _service.Create(input);
        }

        [HttpPut]
        public SingleResponse<TEntity> Update(int id, TInput input)
        {
            return _service.Update(id, input);
        }

        [HttpDelete]
        public SingleResponse<bool> Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}