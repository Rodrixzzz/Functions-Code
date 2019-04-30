using Functions_Code.SharedCode.Models;
namespace Functions_Code.SharedCode.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }         
        public string Email { get; set; }         
        public string Role {get;set;}
        public string Birthdate {get;set;}
    
        public UserDTO()
        {
            
        }
        public UserDTO(User user)
        {
            Id = user.Id;
            Email = user.Email;
            Role = user.Role;
            Birthdate = user.Birthdate.ToString("dd-MM-yyyy");
        }
    }
}