using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ILS.Core.Exceptions;
using ILS.Domain.Entities;
using ILS.Infra.Interfaces;
using ILS.Services.DTO;
using ILS.Services.Interfaces;

namespace ILS.Services.Service
{
    public class UserService : IUserServices
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            var userExists = await _userRepository.GetByUserCpf(userDTO.Cpf);

            if (userExists != null)
                throw new DomainException("Já existe um usuário cadastrado com esse CPF");

            var user = _mapper.Map<User>(userDTO);
            user.Validate();

            var userCreated = await _userRepository.Create(user);

            return _mapper.Map<UserDTO>(userCreated);
        }

        public async Task<UserDTO> Update(UserDTO userDTO)
        {
            var userExists = await _userRepository.Get(userDTO.Id);

            if (userExists == null)
                throw new DomainException("Não existe nenhum usuário como Id informado");

            var user = _mapper.Map<User>(userDTO);
            user.Validate();

            var userUpdated = await _userRepository.Update(user);

            return _mapper.Map<UserDTO>(userUpdated);
        }

        public async Task Remove(long id)
        {
            await _userRepository.Remove(id);
        }

        public async Task<UserDTO> Get(long id)
        {
            var user = await _userRepository.Get();

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> Get()
        {
            var allUsers = await _userRepository.Get();

            return _mapper.Map<List<UserDTO>>(allUsers);
        }
    }
}