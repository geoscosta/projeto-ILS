using System.Collections.Generic;
using System.Threading.Tasks;
using ILS.Services.DTO;

namespace ILS.Services.Interfaces {
    public interface IUserServices {
        Task<UserDTO> Create(UserDTO userDTO);
        Task<UserDTO> Update(UserDTO userDTO);
        Task Remove(long id);
        Task<UserDTO> Get(long id);
        Task<List<UserDTO>> Get();
    }
}