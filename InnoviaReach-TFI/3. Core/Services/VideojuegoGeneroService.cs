﻿using Core.Business.Services;
using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Domain.Models;
using Core.Domain.Request.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Core.Services
{
    public class VideojuegoGeneroService : GenericService<VideojuegoGeneroModel>, IVideojuegoGeneroService
    {
        public VideojuegoGeneroService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IVideojuegoGeneroRepository>())
        {

        }

        public async Task RegistrarGeneneroVid(VideojuegoGeneroModel videojuegoGeneroModel)
        {
            try
            {
                await _repository.Insert(videojuegoGeneroModel);
            }
            catch (Exception)
            {

                throw new Exception($"Error al registrar genero");
            }
            
        }
    }
}
